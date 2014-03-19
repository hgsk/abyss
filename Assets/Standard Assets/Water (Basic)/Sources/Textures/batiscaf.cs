using UnityEngine;
using System.Collections;

public class batiscaf : MonoBehaviour {

	public float speed = 5;
	public float rotateSpeed = 5;
	//barast range: +-600
	public float barast = -100;
	public float coefficient = 100;
	//barast tank spec 1~2
	public float tankspec = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed);
		rigidbody.AddTorque(Vector3.up * Input.GetAxisRaw("Horizontal") * rotateSpeed);
		barast += tankspec * Input.GetAxis("Flow");
		Physics.gravity = new Vector3(0, barast/coefficient, 0);
	}
}
