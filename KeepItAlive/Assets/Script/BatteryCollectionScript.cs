using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCollectionScript : MonoBehaviour
{

    public RaycastClick _raycastclick;
    public Inventory _inventory;

    public bool batteryOneBool;
    public bool batteryTwoBool;

    void Start()
    {
        _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();

    }
   

    void CheckHit()
    {
        if (_raycastclick.ItemHit == this.gameObject.name)
        {
            if(batteryOneBool == true)
            {
                _inventory.batteryOne = batteryOneBool;
            } else { 
            _inventory.batteryTwo = batteryTwoBool;
            }
            this.gameObject.SetActive(false);
        }
    }

}