using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    public GameObject cursorChildObject;
    public GameObject objectToPlace;

    //rayCastManager=detects planes we touch
    public ARRaycastManager raycastManager;

    //toggles cursor visibility
    public bool useCursor;

    void Start()
    {
        cursorChildObject.SetActive(useCursor); 
    }

    // Update is called once per frame
    void Update()
    {
        if (useCursor)
        {
            UpdateCursor();
        }

        //check if that's the beginning of a touch not user holding down a touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //check if it's using a cursor
            if (useCursor)
            {
                //if cursor is use=true, just instantiate at cursor position
                GameObject.Instantiate(objectToPlace, transform.position, transform.rotation);
            }
            else
            {
                //if cursor is not use, do another raycast at the touch position
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
                
                //if hit count greater than 0, instantiate at the hit postition and rotation
                if (hits.Count > 0)
                {
                    GameObject.Instantiate(objectToPlace, hits[0].pose.position, hits[0].pose.rotation);
                }
            }
        }
    }

    void UpdateCursor()
    {
        //mid of 1 location
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
