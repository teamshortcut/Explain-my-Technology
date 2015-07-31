using UnityEngine;
using System.Collections;

public class SetActiveRAM : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {
		SetActiveFull.RAMMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.RAMActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.RAMActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
