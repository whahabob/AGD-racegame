using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}

    // The Update function is called once every frame
    void Update()
    {
        // Apply motion along the z axis of the car
        transform.Translate(0, 0, Input.GetAxis
        ("Vertical") * speed);
        // Apply motion along the y axis of the object
        transform.Rotate(0, Input.GetAxis
        ("Horizontal"), 0);
    }
}
