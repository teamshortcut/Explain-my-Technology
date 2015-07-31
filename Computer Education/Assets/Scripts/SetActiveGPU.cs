using UnityEngine;
using System.Collections;

public class SetActiveGPU : MonoBehaviour {
	private bool canCheck = true;
	// Use this for initialization
	void Start () {
		SetActiveFull.GPUMesh = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (SetActiveFull.GPUActive == true){
			this.gameObject.SetActive(true);
		}
		if (SetActiveFull.GPUActive == false){
			this.gameObject.SetActive(false);
		}
	}
}
