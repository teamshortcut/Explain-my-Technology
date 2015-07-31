using UnityEngine;
using System.Collections;

public class ButtonPower : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.PowerActive == true && canCheck == true){
			SetActiveFull.PowerActive = false;
			print ("Power Button True");
			canCheck = false;
		}
		if(SetActiveFull.PowerActive == false && canCheck == true){
			SetActiveFull.PowerActive = true;
			print ("Power Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
