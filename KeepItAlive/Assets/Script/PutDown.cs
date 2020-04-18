using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDown : MonoBehaviour
{

    public RaycastClick _raycastclick;
    public Selected _selected;
    public Positioning _positioning;
    public GameObject toBeReset;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
