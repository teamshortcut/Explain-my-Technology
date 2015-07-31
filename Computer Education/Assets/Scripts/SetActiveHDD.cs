using UnityEngine;
using System.Collections;

public class SetActiveHDD : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {
		SetActiveFull.HDDMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.HDDActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.HDDActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
