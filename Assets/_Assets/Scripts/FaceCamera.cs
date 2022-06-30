using UnityEngine;

[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{

    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    void Start()
    {
        cam = Camera.main.transform;
    }

    private void Update()
    {
        //look at the camera
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.x = 0;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }
}
