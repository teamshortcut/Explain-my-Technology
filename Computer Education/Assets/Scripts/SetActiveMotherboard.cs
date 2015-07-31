using UnityEngine;
using System.Collections;

public class SetActiveMotherboard : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {
		SetActiveFull.MotherboardMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.MotherboardActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.MotherboardActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
