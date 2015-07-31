using UnityEngine;
using System.Collections;

public class SetActiveCPU : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.CPUActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.CPUActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
