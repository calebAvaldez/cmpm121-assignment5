using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    public Transform door1;
    public Transform door2;
    public Transform door3;

    [SerializeField]
    private int speed;

    private int count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(door1.position.x);
        //Debug.Log(door2.position.y);
        //Debug.Log(door3.position.y);
        if (count == 1 && door1.position.x < 92f)
        {
            door1.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        } else if (count == 3 && door2.position.y > -12f)
        {
            door2.Translate(new Vector3(0, -speed * Time.deltaTime, 0));

        } else if (count == 10 && door3.position.y > -12f)
        {
            door3.Translate(new Vector3(0, -speed * Time.deltaTime, 0));

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            count++;
            if (count == 1)
            {


            } else if (count == 3)
            {


            } else if (count == 10)
            {


            }


        }
    }
}
