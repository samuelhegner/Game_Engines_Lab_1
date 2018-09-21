using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWallScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 6; i ++){
            for (int j = 1; j < 7; j++){
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(i, j, 0);
                cube.AddComponent<Rigidbody>();

                cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1f, 1f, 1f, 1f, 1f); ;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
