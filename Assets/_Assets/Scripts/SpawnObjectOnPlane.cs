using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class SpawnObjectOnPlane : MonoBehaviour
{
    //store reference to raycast manager
    private ARRaycastManager raycastManager;

    //keep track of spwaned object reference
    private GameObject spawnedObject;

    [SerializeField]
    private GameObject PlaceablePrefab;

    //store list of raycast hits
    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();


    private void Awake()
    {
        //fill the reference to the raycast manager
        raycastManager = GetComponent<ARRaycastManager>();
    }

    //recording whether the user is touch the screen, what to do if it's a valid touch
    bool TryGetTouchPostion(out Vector2 touchPosition)
    {
        //check the touch is more than 0 (touch is valid)
        if(Input.touchCount > 0)
        {
            //if it is a valid touch, store the postion into input.gettouch.position
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        //if now the valid touch, it will set the position to default and return
        touchPosition = default;
        return false;
    }

    // Update is called once per frame
    private void Update()
    {
        //check if we have valid TryGetTouchPostion
        //if not touch, return
        if(!TryGetTouchPostion(out Vector2 touchPosition))
        {
            return;
        }
        
        if(raycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
        {
            //store a variable called hitPos; first of the list
            var hitPose = s_Hits[0].pose;

            //check if we have spawn any ojbect yet
            if(spawnedObject == null)
            {
                spawnedObject = Instantiate(PlaceablePrefab, hitPose.position, hitPose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitPose.position;
                spawnedObject.transform.rotation = hitPose.rotation;
            }

        }
    }
}
