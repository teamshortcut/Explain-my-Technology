using UnityEngine;
using System.Collections;

public class InterfaceControls : MonoBehaviour {
	public int turnSpeed = 1;
	public float rotationX;
	public float rotationY;
	public float rotationZ;
	private Vector3 temp;
	private Vector3 rotationEuler;
	// Use this for initialization
	void Start () {
		temp = new Vector3(rotationX, rotationY, rotationZ);
		rotationEuler = temp;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
			transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
			print ("Turn Up");
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			print("Turn Left");
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
			print ("Turn Right");
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
			transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
			print ("Turn Down");
		}
		if(Input.GetKey(KeyCode.Space)){
			this.gameObject.transform.eulerAngles = temp;
		}
	}
	
}
