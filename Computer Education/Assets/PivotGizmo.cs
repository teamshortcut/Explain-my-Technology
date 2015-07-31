using UnityEngine;
using System.Collections;

public class PivotGizmo : MonoBehaviour {
	public float gizmoSize = .75f;
	public Color gizmoColour = Color.yellow;

	void OnDrawGizmos()
	{
		Gizmos.color = gizmoColour;
		Gizmos.DrawWireSphere(transform.position, gizmoSize);
		                                                  
	}
}	