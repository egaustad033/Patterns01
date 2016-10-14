using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	ArrayList FieldObjects = new ArrayList();

	public GameObject o;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Sphere")
		{
			FieldObjects.Add(other.gameObject);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Sphere") 
		{
			FieldObjects.Remove (other.gameObject);
		}
	}

	// Update is called once per frame
	void FixedUpdate () 
	{

		for (int i = 0; i < FieldObjects.Count; i++) 
		{
			if (FieldObjects[i].Equals(null)) {
				FieldObjects.Remove (FieldObjects [i]);
				return;
			}
				
			o = (GameObject) FieldObjects [i];

			Vector3 diff = o.transform.position - transform.position;

			diff.Normalize ();

			o.transform.position -= diff * .2f;
			
			
		}

	}
}
