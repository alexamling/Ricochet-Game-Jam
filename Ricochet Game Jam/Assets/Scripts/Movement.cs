using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    //Inspector variables
    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;

    //Other variables
    private Vector3 velocity;
    private float currentSpeed;
    private Rigidbody rb;
    
    //Default Methods
	void Start () {
        rb = this.GetComponent<Rigidbody>();
    }
	
	void Update () {
        currentSpeed = walkSpeed;

        if (Input.GetAxisRaw("Fire3") > 0)
        {
            currentSpeed = runSpeed;
        }

        velocity.x = Input.GetAxisRaw("Horizontal"); ;
        velocity.z = Input.GetAxisRaw("Vertical");

        velocity.Normalize();
        velocity *= currentSpeed;
        rb.velocity = velocity;
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.collider.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
