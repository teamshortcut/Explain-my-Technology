using UnityEngine;
using System.Collections;

public class ButtonFull : MonoBehaviour {
	private bool canCheck = true;
	public void OnClick(){
		if (SetActiveFull.FullActive == true && canCheck == true){
			SetActiveFull.FullActive = false;
			print ("Full Button True");
			canCheck = false;
		}
		if(SetActiveFull.FullActive == false && canCheck == true){
			SetActiveFull.FullActive = true;
			print("Full Button False");
			canCheck = false;
		}
		canCheck = true;
	}
}
