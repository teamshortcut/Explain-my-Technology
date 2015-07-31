using UnityEngine;
using System.Collections;

public class SetActiveFull : MonoBehaviour {
	public static bool FullActive = true;
	public static MeshRenderer FullMesh;
	public static bool CPUActive = false;
	public static MeshRenderer CPUMesh;
	public static bool GPUActive = false;
	public static MeshRenderer GPUMesh;
	public static bool MotherboardActive = false;
	public static MeshRenderer MotherboardMesh;
	public static bool PowerActive = false;
	public static MeshRenderer PowerMesh;
	public static bool HDDActive = false;
	public static MeshRenderer HDDMesh;
	public static bool RAMActive = false;
	public static MeshRenderer RAMMesh;

	private bool canCheck = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (FullActive == true){
			this.gameObject.SetActive(true);
		}
		if (FullActive == false){
			this.gameObject.SetActive(false);
		}
	}

	public void FullSetFalse(){
		FullActive = false;
	}
	public void CPUSetFalse(){
		CPUActive = false;
	}
	public void GPUSetFalse(){
		GPUActive = false;
	}
	public void MotherboardSetFalse(){
		MotherboardActive = false;
	}
	public void PowerSetFalse(){
		PowerActive = false;
	}
	public void HDDSetFalse(){
		HDDActive = false;
	}
	public void RAMSetFalse(){
		RAMActive = false;
	}

	public void FullSetTrue(){
		FullActive = true;
	}
	public void CPUSetTrue(){
		CPUActive = true;
	}
	public void GPUSetTrue(){
		GPUActive = true;
	}
	public void MotherboardSetTrue(){
		MotherboardActive = true;
	}
	public void PowerSetTrue(){
		PowerActive = true;
	}
	public void HDDSetTrue(){
		HDDActive = true;
	}
	public void RAMSetTrue(){
		RAMActive = true;
	}

}
