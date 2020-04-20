using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public RaycastClick _raycastclick;
    public Animator batteryAnim;
    public Inventory _inventory;
    public Selected _selected;

    bool batteryOpen = false;


    public bool batteryOpenPublic;

    public GameObject newBatOne;
    public GameObject newBatTwo;

    public AudioSource aud;
    public AudioClip addNew;
    public AudioClip cover;

    // Start is called before the first frame update
    void Start()
    {
        batteryAnim = this.GetComponent<Animator>();
        _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
        _selected = GameObject.Find("GameManager").GetComponent<Selected>();


        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        addNew = Resources.Load("ADD") as AudioClip;
        cover = Resources.Load("BATTERYCOVER") as AudioClip;

    }


    private void Update()
    {
        batteryOpenPublic = batteryOpen;
    }

    // Update is called once per frame
    void CheckHit()
    {
        Debug.Log("Hit is checked");
            if (_raycastclick.ItemHit == this.gameObject.name && batteryOpen == false)
            {
                Debug.Log("Battery state is " + batteryOpen);
                Debug.Log("CLICK");
                batteryAnim.SetInteger("State", 1);
                batteryOpen = true;
            aud.PlayOneShot(cover);
            }
            else if (_raycastclick.ItemHit == this.gameObject.name && batteryOpen == true)
            {
                Debug.Log("Battery state is " + batteryOpen);
                Debug.Log("CLICK2");
                batteryAnim.SetInteger("State", 2);
                batteryOpen = false;
                aud.PlayOneShot(cover);
            }
        
    }


    public void addNewBatteries()
    {
        if (this.gameObject.name == "BackPanelTeal" && batteryOpen == true && _selected.selectOneName == "Robot")
        {
            newBatOne.SetActive(true);
            newBatTwo.SetActive(true);
            _inventory.batteryOne = false;
            _inventory.batteryTwo = false;
            aud.PlayOneShot(addNew);
        }
    }


}
