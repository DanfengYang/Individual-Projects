using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTransform;
    //declear camera
    Transform cameraFocusTarget;
    public Vector3 targetPosition;
    bool didRun = false;
    //trigger did what it needs to do

    //private void OnTriggerEnter2D(Collider2D collision)
    private void OnTriggerEnter2D(Collider2D activator)
    {
        if (didRun == false)
        {
            didRun = true;
            Debug.Log(activator.name + "entered trigger", gameObject);
            //gameobject hightlights the object that printed the message
            cameraFocusTarget = activator.transform;
        }
        
    }

    private void OnTriggerExit2D(Collider2D activator)
    {
        if (cameraFocusTarget != null)
        {
            cameraFocusTarget = null;
            cameraTransform.position = targetPosition;
            //changes camera position to be the target position
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraFocusTarget != null)
        {
            cameraTransform.position = new Vector3(cameraFocusTarget.transform.position.x, cameraFocusTarget.transform.position.y, cameraTransform.position.z);

        }
    }
}
