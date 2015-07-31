using UnityEngine;
using System.Collections;

public class ButtonRAM : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.RAMActive == true && canCheck == true){
			SetActiveFull.RAMActive = false;
			print ("RAM Button True");
			canCheck = false;
		}
		if(SetActiveFull.RAMActive == false && canCheck == true){
			SetActiveFull.RAMActive = true;
			print ("RAM Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}