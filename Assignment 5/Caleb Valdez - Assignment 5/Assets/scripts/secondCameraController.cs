using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondCameraController : MonoBehaviour
{
    public Transform target;

    public Transform pivot;

    private bool menuOpen;

    [SerializeField]
    private float rotateSpeed = 2.0f, minViewAngle = -45.0f, maxViewAngle = 45.0f;

    private float pitch = 0.0f;

    private void Start()
    {
        menuOpen = false;
        Cursor.visible = false;
    }

    void LateUpdate()
    {
        //if pause menu is on the screen
        if (menuOpen == false)
        {
            //Get x position of mouse and rotate the player
            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
            target.Rotate(0, horizontal, 0);

            //Get y position of mouse and rotate the player
            float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;

            //Move the camera based on the current rotation of target and original offset
            float desiredYAngle = target.eulerAngles.y;
            float desiredXAngle = pivot.eulerAngles.x;
            Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
            transform.position = target.position;

            //yaw += rotateSpeed * Input.GetAxis("Mouse X");
            pitch -= rotateSpeed * Input.GetAxis("Mouse Y");

            transform.rotation = Quaternion.Euler(pitch, target.eulerAngles.y, 0.0f);

            //Limit the up/down camera rotation
            if (transform.rotation.eulerAngles.x > maxViewAngle && transform.rotation.eulerAngles.x < 180.0f)
            {
                transform.rotation = Quaternion.Euler(maxViewAngle, target.eulerAngles.y, 0);
            }

            if (transform.rotation.eulerAngles.x > 180.0f && transform.rotation.eulerAngles.x < minViewAngle)
            {
                transform.rotation = Quaternion.Euler(360.0f + minViewAngle, target.eulerAngles.y, 0);
            }
        }
    }

    private void Update()
    {
        if (menuOpen == false && Input.GetKeyDown(KeyCode.Escape))
        {
            OpenMenu();

        }
        else if (menuOpen == true && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenu();

        }
    }
    private void OpenMenu()
    {
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;

        menuOpen = true;

    }

    private void CloseMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = false;

        menuOpen = false;

    }

}
