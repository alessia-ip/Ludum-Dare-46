using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGoodScreen : MonoBehaviour
{
    

    public RaycastClick _raycastclick;
    public Inventory _inventory;
    public Selected _selected;


    public GameObject SCREENFIXED;


    public AudioSource aud;
    public AudioClip addNew;


    void Start()
        {
            _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
            _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
            _selected = GameObject.Find("GameManager").GetComponent<Selected>();


        aud = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        addNew = Resources.Load("ADD") as AudioClip;
    }


    public void AddNewScreen()
    {
        if (_selected.selectOneName == "Robot" && _inventory.originalScreen == true && _inventory.salvagedScreen == true)
        {
            SCREENFIXED.SetActive(true);
            _inventory.salvagedScreen = false;
            aud.PlayOneShot(addNew);

        }
    }


    
}
