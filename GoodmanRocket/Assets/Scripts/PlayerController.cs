using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string message;
    public Rigidbody myRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        print(message);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //print("You Pressed the Space Key");   
            myRB.AddRelativeForce(Vector3.up * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("You Pressed the 'D' Key");
            transform.Rotate(Vector3.back * 0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("You Pressed the 'A' Key");
            transform.Rotate(Vector3.forward * 0.1f);
        }     

    }
}
