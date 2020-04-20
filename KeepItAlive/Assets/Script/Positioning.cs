using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioning : MonoBehaviour
{

    public Vector3 StartPos;
    public Vector3 SecondaryPos;
    public Quaternion StartRotation;
    public RaycastClick _raycastclick;
    public Selected _selected;
    public bool moved;
    public int speed;


    public AudioSource aud;
    public AudioClip pickupAud;

    public Component[] childcolliders;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = this.transform.position;
        StartRotation = this.transform.rotation;
        //Debug.Log(StartPos);
        moved = false;
        Debug.Log(this.gameObject.name);

        childcolliders = GetComponentsInChildren<Collider>();

        foreach (Collider cColider in childcolliders)
        {
            cColider.enabled = false;
        }


        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();

        pickupAud = Resources.Load("PICKUP") as AudioClip;

    }

    // Update is called once per frame
    void Update()
    {

        this.GetComponent<Collider>().enabled = true;


        //picking up handled here
        if (_raycastclick.ItemHit == this.gameObject.name) {
            //Debug.Log("numberOne");
            if (moved == false && _selected.selectedOne == false)
            {
                this.transform.position = SecondaryPos;
                moved = true;
                _selected.selectedOne = true;
                _selected.selectOneName = this.gameObject.name;
                _selected.selectObj = this.gameObject;

                aud.PlayOneShot(pickupAud);

                foreach (Collider cColider in childcolliders)
                {
                    cColider.enabled = true;
                }

            }
        }


        if (moved == true){
            if (Input.GetKey(KeyCode.A))
                transform.Rotate(Vector3.up * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
                transform.Rotate(-Vector3.up * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.S))
                transform.Rotate(Vector3.left * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.W))
                transform.Rotate(-Vector3.left * speed * Time.deltaTime);
        }


    }


    public void PLACEBACK(){
        Debug.Log("Place Back");
        this.transform.position = StartPos;
        this.transform.rotation = StartRotation;
        moved = false;
        _selected.selectedOne = false;

        foreach (Collider cColider in childcolliders)
        {
            cColider.enabled = false;
        }
    }
}
