using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mousePressDownPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    private void OnMouseUp()
    {
        mouseReleasePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Shoot(mouseReleasePos - mousePressDownPos);
    }

    private float forceMultiplier = 1;
    void Shoot(Vector3 Force)
    {
        if (isShoot)
            return;

        rb.AddForce(new Vector3(Force.x, Force.y, Force.y) * forceMultiplier);
        isShoot = true;
    }

}