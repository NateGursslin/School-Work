using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 4;
    private Vector3 moveDirection = new Vector3(0, 0, 0);
    


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        moveDirection.x = Random.Range(0, 360);
        moveDirection.z = Random.Range(0, 360);
        transform.eulerAngles = moveDirection;

    }
	
	// Update is called once per frame
	void Update () {

        rb.AddRelativeForce(transform.forward * speed);
	}
}
