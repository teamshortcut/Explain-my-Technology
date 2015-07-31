using UnityEngine;
using System.Collections;

public class ButtonHDD : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.HDDActive == true && canCheck == true){
			SetActiveFull.HDDActive = false;
			print ("HDD Button True");
			canCheck = false;
		}
		if(SetActiveFull.HDDActive == false && canCheck == true){
			SetActiveFull.HDDActive = true;
			print ("HDD Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
