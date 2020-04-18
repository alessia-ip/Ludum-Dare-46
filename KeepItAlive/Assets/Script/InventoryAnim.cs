using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryAnim : MonoBehaviour
{

    public Animator inventoryAnim;

    [SerializeField] bool inventoryOpen = false;


    public Sprite Closed;
    public Sprite Open;

    public Button pullTab;


    private void Start()
    {
        inventoryAnim = this.GetComponent<Animator>();
    }

    public void buttonClick()
    {
        Debug.Log("Click");

        if (inventoryOpen == false)
        {
            pullTab.image.sprite = Open;
            Debug.Log("To Open");
            inventoryAnim.SetInteger("State", 1);
            inventoryOpen = true;
            
        } else
        {
            pullTab.image.sprite = Closed;
            Debug.Log("To Close");
            inventoryAnim.SetInteger("State", 2);
            inventoryOpen = false;
            inventoryAnim.Play("InvetoryPanelClose");
            
        }
    }


}
