using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{


    public bool batteryOne = false;
    public bool batteryTwo = false;
    public bool salvagedScreen = false;
    public bool originalScreen = false;
    public bool extraWires = false;
    public bool yourCard = false;
    public bool USB = true;

    public GameObject btn_batteryOne;
    public GameObject btn_batteryTwo;
    public GameObject btn_salvagedScreen;
    public GameObject btn_originalScreen;
    public GameObject btn_extraWires;
    public GameObject btn_yourCard;
    public GameObject btn_USB;


    // Start is called before the first frame update
    void Start()
    {
        btn_batteryOne.active = false;
        btn_batteryTwo.active = false;
        btn_extraWires.active = false;
        btn_originalScreen.active = false;
        btn_salvagedScreen.active = false;
        btn_yourCard.active = false;
        btn_USB.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryOne == true)
        {
            btn_batteryOne.active = true;
        } else
        {
            btn_batteryOne.active = false;
        }
        if (batteryTwo == true)
        {
            btn_batteryTwo.active = true;
        }
        else
        {
            btn_batteryTwo.active = false;
        }
        if (extraWires == true)
        {
            btn_extraWires.active = true;
        }
        else
        {
            btn_extraWires.active = false;
        }
        if (originalScreen == true)
        {
            btn_originalScreen.active = true;
        }
        else
        {
            btn_originalScreen.active = false;
        }
        if (salvagedScreen == true)
        {
            btn_salvagedScreen.active = true;
        }
        else
        {
            btn_salvagedScreen.active = false;
        }
        if (yourCard == true)
        {
            btn_yourCard.active = true;
        }
        else
        {
            btn_yourCard.active = false;
        }
        if (USB == true)
        {
            btn_USB.active = true;
        }
        else
        {
            btn_USB.active = false;
        }
    }
}
