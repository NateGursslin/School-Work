using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float rotationSpeed = 3;
    public float movementSpeed = 50;
    public Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(0, 0, movementSpeed);
        }

    }
}
