using UnityEngine;
using System.Collections;

public class ButtonGPU : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.GPUActive == true && canCheck == true){
			SetActiveFull.GPUActive = false;
			print ("GPU Button True");
			canCheck = false;
		}
		if(SetActiveFull.GPUActive == false && canCheck == true){
			SetActiveFull.GPUActive = true;
			print("GPU Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
