using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public RaycastClick _raycastclick;
    public Animator batteryAnim;
    public Inventory _inventory;

    bool batteryOpen = false;


    public GameObject newBatOne;
    public GameObject newBatTwo;

    // Start is called before the first frame update
    void Start()
    {
        batteryAnim = this.GetComponent<Animator>();
        _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();

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

            }
            else if (_raycastclick.ItemHit == this.gameObject.name && batteryOpen == true)
            {
                Debug.Log("Battery state is " + batteryOpen);
                Debug.Log("CLICK2");
                batteryAnim.SetInteger("State", 2);
                batteryOpen = false;

            }
        
    }


    public void addNewBatteries()
    {
        if (this.gameObject.name == "BackPanelTeal" && batteryOpen == true)
        {
            newBatOne.SetActive(true);
            newBatTwo.SetActive(true);
            _inventory.batteryOne = false;
            _inventory.batteryTwo = false;
        }
    }


}
