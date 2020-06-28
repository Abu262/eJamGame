using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControls : MonoBehaviour
{
    public CharacterController controller;
    public bool busy = false;

    //movement variables
    public float speed = 12f;
    public float gravity = 0f;


    //falling and jumping, might not need this
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;


    //text object
    public Text T;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //checks when we hit the ground if for whatever reason we are in the air
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        //continuously shoots a raycast

        if (!busy)
        {
            RaycastHit hit;
            if (Physics.Raycast(
                    Camera.main.transform.position,
                    Camera.main.transform.forward,
                    out hit,
                    20f
                ))
            {
                //if we hit an item display the item
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


            //movement controls
            if (isGrounded && velocity.y < 0)
            {
                //velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);
            //velocity.y += gravity + Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);

            if (isGrounded)
            {
                //if we are on the ground then you can click on object to interact with them
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
                        if (hit2.collider.tag == "Item")
                        {
                            Debug.Log("HIT");

                            StartCoroutine(click(hit2.transform.gameObject.GetComponent<ItemClass>()));
                        }


                    }
                }
            }
        }
    }


    //once you click on an object, you cant move or anything until its done
    IEnumerator click(ItemClass IC)
    {
        busy = true;
        yield return StartCoroutine(IC.Interact());
        busy = false;
        yield return null;
    }
}
