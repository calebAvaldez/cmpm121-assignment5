using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectRotate : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 0;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * rotateSpeed);
    }
}
