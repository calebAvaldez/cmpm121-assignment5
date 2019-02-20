using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    public Camera camRoom1;
    public Camera camRoom2;
    public Camera camRoom3;
    public Camera camEnd;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject textEnd;

    private int count;
    private bool menuOpen;

    private void Start()
    {
        camRoom1.enabled = true;
        camRoom2.enabled = false;
        camRoom3.enabled = false;
        camEnd.enabled = false;

        text1.SetActive(true);
        text2.SetActive(false);
        text3.SetActive(false);
        textEnd.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("camSwitch1") && camRoom1.enabled == true)
        {
            camRoom1.enabled = false;
            camRoom2.enabled = true;
            camRoom3.enabled = false;
            camEnd.enabled = false;

            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            textEnd.SetActive(false);

        } else if (other.gameObject.CompareTag("camSwitch2") && camRoom2.enabled == true)
        {
            camRoom1.enabled = true;
            camRoom2.enabled = false;
            camRoom3.enabled = false;
            camEnd.enabled = false;

            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);
            textEnd.SetActive(false);

        } else if (other.gameObject.CompareTag("camSwitch3") && camRoom2.enabled == true)
        {
            camRoom1.enabled = false;
            camRoom2.enabled = false;
            camRoom3.enabled = true;
            camEnd.enabled = false;

            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
            textEnd.SetActive(false);

        } else if (other.gameObject.CompareTag("camSwitch4") && camRoom3.enabled == true)
        {
            camRoom1.enabled = false;
            camRoom2.enabled = true;
            camRoom3.enabled = false;
            camEnd.enabled = false;

            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            textEnd.SetActive(false);

        } else if (other.gameObject.CompareTag("endGame") && camRoom3.enabled == true)
        {
            camRoom1.enabled = false;
            camRoom2.enabled = false;
            camRoom3.enabled = false;
            camEnd.enabled = true;

            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            textEnd.SetActive(true);
        }
    }

}
