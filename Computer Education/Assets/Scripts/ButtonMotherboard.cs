using UnityEngine;
using System.Collections;

public class ButtonMotherboard : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.MotherboardActive == true && canCheck == true){
			SetActiveFull.MotherboardActive = false;
			print ("Motherboard Button True");
			canCheck = false;
		}
		if(SetActiveFull.MotherboardActive == false && canCheck == true){
			SetActiveFull.MotherboardActive = true;
			print ("Motherboard Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
