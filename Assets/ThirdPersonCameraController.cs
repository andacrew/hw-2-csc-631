using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 1; 
    public Transform Target, Player; 
    float mouseX, mouseY;
    bool camToggle = false; 
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
    if(Input.GetKeyUp("e")) camToggle = !camToggle;
    Debug.Log(camToggle?"OverCam is toggled on":"OverCam is Toggled off");
    }
    void LateUpdate()
    {
    if(camToggle) OverheadCamControl();
    else ThirdPersonCamControl(); 
    }

   
    void ThirdPersonCamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0); 
    }

    void OverheadCamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;

        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(90, mouseX, 0); 
        Player.rotation = Quaternion.Euler(0, mouseX, 0); 

    }

    public float damage = 10f;
    public float range = 100f; 

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, range ))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
