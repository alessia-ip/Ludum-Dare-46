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


    public GameObject OBJBatOne;
    public GameObject OBJBatTwo;
    public GameObject crackedScreen;
    public GameObject goodScreen;

    // Start is called before the first frame update
    void Start()
    {
        btn_batteryOne.SetActive(false);
        btn_batteryTwo.SetActive(false);
        btn_extraWires.SetActive(false);
        btn_originalScreen.SetActive(false);
        btn_salvagedScreen.SetActive(false);
        btn_yourCard.SetActive(false);
        btn_USB.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryTwo == true && batteryOne == true)
        {
            btn_batteryTwo.SetActive(true);
            OBJBatOne.SetActive(true);
            OBJBatTwo.SetActive(true);
        }
        else
        {
            btn_batteryTwo.SetActive(false);
            if (batteryOne == false && batteryTwo == false)
            {
                OBJBatOne.SetActive(false);
                OBJBatTwo.SetActive(false);
            }
        }
        if (batteryOne == true && batteryTwo == false|| batteryTwo == true && batteryOne == false)
        { 
            btn_batteryOne.SetActive(true);
            OBJBatOne.SetActive(true);
        } else
        {
            btn_batteryOne.SetActive(false);
      
        }
        if (extraWires == true)
        {
            btn_extraWires.SetActive(true);
        }
        else
        {
            btn_extraWires.SetActive(false);
        }


        if (salvagedScreen == true)
        {
            btn_salvagedScreen.SetActive(true);
            goodScreen.SetActive(true);
        }
        else
        {
            btn_salvagedScreen.SetActive(false);
            goodScreen.SetActive(false);
        }


        if (originalScreen == true)
        {
            btn_originalScreen.SetActive(true);
            crackedScreen.SetActive(true);
        }
        else
        {
            btn_originalScreen.SetActive(false);
        }



        if (yourCard == true)
        {
            btn_yourCard.SetActive(true);
        }
        else
        {
            btn_yourCard.SetActive(false);
            }
        if (USB == true)
        {
            btn_USB.SetActive(true);
        }
        else
        {
            btn_USB.SetActive(false);
        }




        /////////
        ///


    }
}
