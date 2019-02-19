using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2CamController : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.LookAt(target);
    }

}
