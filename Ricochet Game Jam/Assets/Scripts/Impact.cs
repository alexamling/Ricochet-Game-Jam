using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {

    private MoveBullet ricochet;
    private bool ricocheted;

	//Default Methods
	void Start () {
        ricochet = GetComponent<MoveBullet>();
        ricocheted = false;
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Wall" || (collision.collider.tag == "Enemy" && !ricocheted))
        {
            ricochet.NewMove(ricochet.Speed, Vector3.Reflect(ricochet.Trajectory, new Vector2(collision.contacts[0].normal.x, collision.contacts[0].normal.z)));
            ricocheted = true;
        }
        else if(collision.collider.tag == "Enemy" && ricocheted)
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
}
