using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	public float scrollSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse ScrollWheel") > 0 && this.gameObject.transform.position.z <= -1){
			this.gameObject.transform.Translate(new Vector3(0, 0, scrollSpeed));
			print ("Zoom +");
		}
		if(Input.GetAxis("Mouse ScrollWheel") < 0 && this.gameObject.transform.position.z >= -10){
			this.gameObject.transform.Translate(new Vector3(0, 0, scrollSpeed * -1));
			print("Zoom -");
		}
	}
}
