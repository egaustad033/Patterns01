using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public SphereMovement forwardMove = new ForwardSphereMovement();
	public SphereMovement jitterMove = new JitterMovement();
	public SphereMovement eulerMove = new EulerMovement();
	private int i;

	void Start ()
	{
		i = Random.Range (0, 3);
	}

	void FixedUpdate()
	{
		switch (i) 
		{
		case 0:
			forwardMove.move(transform);
			break;
		case 1:
			jitterMove.move(transform);
			break;
		case 2:
			eulerMove.move(transform);
			break;

		}
	}
}





