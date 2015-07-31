using UnityEngine;
using System.Collections;

public class SetActivePower : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {
		SetActiveFull.PowerMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.PowerActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.PowerActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
