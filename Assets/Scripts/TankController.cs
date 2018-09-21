using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    public float speed = 2;
    public float rotationSpeed = 10;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletForce = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * (Time.deltaTime * speed));
        }

        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0, -Time.deltaTime * rotationSpeed, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bullet =Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletForce);
        }



    }
}
