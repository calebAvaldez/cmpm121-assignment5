using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3CamController : MonoBehaviour
{
    public Transform target;

    [SerializeField]
    private float beginningX;
    [SerializeField]
    private float endX;
    [SerializeField]
    private float camY;
    [SerializeField]
    private float camZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Debug.Log("player is at: (" + target.position.x + ", " + target.position.y + ", " + target.position.z);
        if (this.enabled == true)
        {
            if (target.position.x < beginningX && target.position.x > endX)
            {
                transform.position = new Vector3(target.position.x, camY, camZ);
            }
        }

    }
}
