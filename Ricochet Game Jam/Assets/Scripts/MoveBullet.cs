using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

    //Variables
    private float speed;
    private Vector2 trajectory;
    private Vector2 velocity;

    //Properties
    public float Speed
    {
        get
        {
            return speed;
        }
    }

    //Default Methods
	void Start () {
		
	}
	
	void Update () {

        velocity.x = trajectory.x * speed;
        velocity.y = trajectory.y * speed;


        transform.position = new Vector3(velocity.x + transform.position.x, transform.position.y, velocity.y + transform.position.z);
    }

    //Special Methods
    public void NewMove(float speed, Vector2 trajectory)
    {
        this.speed = speed;
        this.trajectory = trajectory.normalized;
    }
}
