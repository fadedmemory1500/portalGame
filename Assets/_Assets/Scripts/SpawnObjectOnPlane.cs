using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class SpawnObjectOnPlane : MonoBehaviour
{

    private ARRaycastManager raycastManager;
    private GameObject spawnedObject;

    [SerializeField]
    private GameObject PlaceablePrefab;

    static List<ARRaycastHit> s_Hits = new list,ARRaycastHit>();


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        = new List<ARRaycastHit>();
    }




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
