using UnityEngine;
using System.Collections;

public class Arrival : MonoBehaviour {

	public float maxSpeed = 500.0f;
	
	public float rotSpeed = 2.0f;

	public float arrivalRadius = 50.0f;

	public float k = 1.0f;

	public Transform target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float d = Vector3.Distance (target.position, transform.position);
		float speed;
		if (d < arrivalRadius) 
		{
			speed = 0.0f;
			return;
		}
		speed = Mathf.Min (maxSpeed, k*d);
		//Rotate to the target point
		Quaternion targetRotation = Quaternion.LookRotation( target.position - transform.position);		
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed); 
		
		//Go Forward
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
