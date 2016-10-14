using UnityEngine;
using System.Collections;

[System.Serializable]
public class ForwardSphereMovement : SphereMovement
{
	public override void move(Transform t)
	{
		t.position = t.position + t.right * -1.5f;
	}
}
