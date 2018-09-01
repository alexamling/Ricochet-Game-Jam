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
    private Vector2 velocity;
    private float currentSpeed;
    private Vector3 newPosition;
    
    //Default Methods
	void Start () {
		
	}
	
	void Update () {
        currentSpeed = walkSpeed;

        if (Input.GetAxisRaw("Fire3") > 0)
        {
            currentSpeed = runSpeed;
        }

        velocity.x = Input.GetAxisRaw("Horizontal") * currentSpeed;
        velocity.y = Input.GetAxisRaw("Vertical") * currentSpeed;


        transform.position = new Vector3 (velocity.x + transform.position.x, transform.position.y, velocity.y + transform.position.z);
    }
}
