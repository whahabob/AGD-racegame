using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float movementSpeed;
	// Use this for initialization
	void Start ()
    {
        movementSpeed = 15;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += movementSpeed;
            this.transform.position = position;
        }

    }
}
