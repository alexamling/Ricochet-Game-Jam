using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyManager : MonoBehaviour {

    public GameObject[] spawnPoints;
    public GameObject Enemy;
    public float Delay = 5;

    private float timeTilSpawn;
    private Random rng;

	// Use this for initialization
	void Start () {
        timeTilSpawn = Delay;
        rng = new Random();
	}
	
	// Update is called once per frame
	void Update () {
        timeTilSpawn -= Time.deltaTime;
        if (timeTilSpawn <= 0)
        {
            timeTilSpawn += Delay;
            Instantiate(Enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
        }
	}
}
