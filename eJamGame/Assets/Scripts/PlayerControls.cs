using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControls : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public Text T;

    // Start is called before the first frame update
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        RaycastHit hit;
        if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hit,
                20f
            ))
        {
            if (hit.collider.tag == "Item")
            {
          
                T.text = hit.transform.gameObject.GetComponent<ItemClass>().name;
            }
            else
            {
                T.text = "";
            }


        }
        else
        {
            T.text = "";
        }



        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity + Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


        if (isGrounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit2;
                if (Physics.Raycast(
                        Camera.main.transform.position,
                        Camera.main.transform.forward,
                        out hit2,
                        20f
                    ))
                {
                    Debug.Log("HIT");

                    StartCoroutine(hit2.transform.gameObject.GetComponent<ItemClass>().Interact());
                   
                }
            }
        }
    }
}
