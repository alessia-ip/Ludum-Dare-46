using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDGAME : MonoBehaviour
{

    public AudioSource cameraSource;

    public AudioClip finale;

    public RaycastClick _raycastclick;
    public Inventory _inventory;
    public Selected _selected;

    public GameObject newScreen;
    public GameObject newBattery;
    public GameObject newBattery2;
    public GameObject tealBatteryCover;

    public Animator USBending;


    public GameObject EndText;
    public GameObject THANKS;


    public GameObject robot;




    public void Start()
    {
        _raycastclick = GameObject.Find("GameManager").GetComponent<RaycastClick>();
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
        _selected = GameObject.Find("GameManager").GetComponent<Selected>();

        cameraSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        finale = Resources.Load("COMPLETE") as AudioClip;
    }

    public void ending()
    {
        if (_selected.selectObj.name == "Robot" && newScreen.activeInHierarchy == true && newBattery.activeInHierarchy == true && newBattery2.activeInHierarchy == true && tealBatteryCover.GetComponent<AnimationTrigger>().batteryOpenPublic == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;
            robot.GetComponent<Positioning>().moved = false;
            Debug.Log("success!");
            robot.transform.rotation = robot.GetComponent<Positioning>().StartRotation;
            USBending.SetBool("ENDING MET", true);
            StartCoroutine(Final());
        }

    }

    public IEnumerator Final()
    {
        yield return new WaitForSeconds(1);
        EndText.SetActive(true);
        yield return new WaitForSeconds(3);
        EndText.SetActive(false);
        cameraSource.PlayOneShot(finale);
        THANKS.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }


}
