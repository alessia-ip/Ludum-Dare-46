using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCollect : MonoBehaviour
{


    public RaycastClick _raycastclick;
    public Inventory _inventory;


    public bool Cracked;
    public bool NotCracked;

    public AudioSource aud;
    public AudioClip collectItem;

    // Start is called before the first frame update
    void Start()
    {
        _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();


        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        collectItem = Resources.Load("COLLECTITEM") as AudioClip;
    }

    void CheckHit()
    {
        if (_raycastclick.ItemHit == this.gameObject.name)
        {

            if (Cracked == true)
            {
                _inventory.originalScreen = true;
            }

            if (NotCracked == true)
            {
                _inventory.salvagedScreen = true;
            }
            aud.PlayOneShot(collectItem);

            this.gameObject.SetActive(false);
        }
    }
}
