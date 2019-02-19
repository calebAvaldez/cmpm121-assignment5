using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSway : MonoBehaviour
{
    public Transform light1;
    public Transform light2;

    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private float maxRotation = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light1.rotation = Quaternion.Euler((-maxRotation * Mathf.Sin(Time.time * speed)) + 90, 90f, 0f);
        light2.rotation = Quaternion.Euler((maxRotation * Mathf.Sin(Time.time * speed)) + 90, 90f, 0f);
    }
}
