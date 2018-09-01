using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    //Inspector Variables
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float gunTimer;
    [SerializeField]
    private float bulletSpeed;

    //Other Variables
    private float lastShot;
    private GameObject bullet;
    private MoveBullet shot;


	//Default Methods
	void Start () {
        lastShot = gunTimer * -1;
	}

    void Update()
    {
        if (Input.GetAxisRaw("Fire1") > 0 && Time.fixedTime > lastShot + gunTimer)
        {

            Vector2 mousePos = Input.mousePosition;
            mousePos.x -= Screen.width / 2;
            mousePos.y -= Screen.height / 2;

            Vector3 position = new Vector3(transform.position.x + mousePos.normalized.x, transform.position.y, transform.position.z + mousePos.normalized.y);
            bullet = Instantiate(bulletPrefab, position, Quaternion.identity);
            shot = bullet.GetComponent<MoveBullet>();

            lastShot = Time.time;
            shot.NewMove(bulletSpeed, mousePos);
        }
    }
}
