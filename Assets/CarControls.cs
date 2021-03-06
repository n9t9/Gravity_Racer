using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : MonoBehaviour
{
    public Rigidbody2D frontTire;
    public Rigidbody2D backTire;
    public Rigidbody2D car;
    public float speed;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        car.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }

}
