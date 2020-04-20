using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDown : MonoBehaviour
{

    public RaycastClick _raycastclick;
    public Selected _selected;
    public Positioning _positioning;
    public GameObject toBeReset;


    public AudioSource aud;
    public AudioClip putDownAud;


    private void Start()
    {
        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();

        putDownAud = Resources.Load("PUTDOWN") as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (_raycastclick.ItemHit == this.gameObject.name && _selected.selectedOne == true)
        {
            Debug.Log("Put Down");
            toBeReset = _selected.selectObj;
            _positioning = toBeReset.GetComponent<Positioning>();
            _positioning.PLACEBACK();
            aud.PlayOneShot(putDownAud);

        }
    }
}
