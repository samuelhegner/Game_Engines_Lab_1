using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        timer = 0;
	}

    float timer;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if(timer>=5){
            Destroy(gameObject);
        }
	}
}
