using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float rotateSpeed;

    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;

    public AudioClip footsteps;
    AudioSource audioSource;

    public Animator anim;

    public GameObject playerModel;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0f;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {

        if (controller.isGrounded)
        {
            moveDirection.y = 0.0f;

            float yStore = moveDirection.y;
            moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
            moveDirection = moveDirection.normalized * moveSpeed;
            moveDirection.y = yStore;
            /*
            float horizontal = Input.GetAxis("Horizontal");
            playerModel.transform.Rotate(0f, horizontal * 90f, 0f);

            float vertical = Input.GetAxis("Vertical");
            playerModel.transform.Rotate(0f, vertical * 180f, 0f);
            */
        }


        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection * Time.deltaTime);

        //Move the player in different directions based on camera look direction
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") !=0)
        {
            //transform.rotation = Quaternion.Euler(0.0f, pivot.rotation.eulerAngles.y, 0.0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0.0f, moveDirection.z));
            playerModel.transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);

            audioSource.volume = 0.2f;
        } else
        {
            audioSource.volume = 0f;
        }

        anim.SetFloat("speed", (Mathf.Abs(Input.GetAxis("Vertical"))) + (Mathf.Abs(Input.GetAxis("Horizontal"))));

    }


    void OnTriggerEnter(Collider other)
    {
       /* if (other.gameObject.CompareTag("Collectable"))
        {

            other.gameObject.SetActive (false);
            count++;
            SetCountText();

            audioSource.PlayOneShot(pickup, 0.7f);

        }*/
    }

}
