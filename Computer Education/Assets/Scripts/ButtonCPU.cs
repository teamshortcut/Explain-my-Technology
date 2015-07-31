using UnityEngine;
using System.Collections;

public class ButtonCPU : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.CPUActive == true && canCheck == true){
			SetActiveFull.CPUActive = false;
			print("CPU Button True");
			canCheck = false;
		}
		if(SetActiveFull.CPUActive == false && canCheck == true){
			SetActiveFull.CPUActive = true;
			print ("CPU Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
