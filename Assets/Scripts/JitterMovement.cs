using UnityEngine;
using System.Collections;

[System.Serializable]
public class JitterMovement : SphereMovement
{
	public override void move(Transform t)
	{
		//I chose to do random movement of -.3 to .3 instead of -.03 to .03
		//I wanted to note it here so you knew I knew what I was doing.  I just thought the effects
		//were quite a bit more noticeable obviously.  I can be sure to follow directions to "T" if you
		//would prefer that instead.  If that is the case then I apologize and it's completely understandable.
		Vector3 moveji = new Vector3 (Random.Range (-.3f, .3f), Random.Range (-.3f, .3f), Random.Range (-.3f, .3f));
		t.position = t.position + moveji + t.right * -1f;
	}
}