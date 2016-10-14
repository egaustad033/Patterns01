using UnityEngine;
using System.Collections;

[System.Serializable]
public class EulerMovement : SphereMovement
{
	public override void move(Transform t)
	{
		t.position = t.position + t.right * -1f;
		Vector3 E = t.rotation.eulerAngles;
		E.z += UnityEngine.Random.Range (-3, 4);
		E.y += UnityEngine.Random.Range (-3, 4);
		E.x += UnityEngine.Random.Range (-3, 4);
		t.rotation = Quaternion.Euler (E);
	}
}

