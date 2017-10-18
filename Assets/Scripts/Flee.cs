using UnityEngine;
using System.Collections;

public class Flee : MonoBehaviour {

	public float speed = 100.0f;
	
	public float rotSpeed = 2.0f;
	
	public Transform target;
	
	private float max_dis = 1000.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance (transform.position, target.position) < max_dis ) {
			//Rotate to the target point
			Quaternion targetRotation = Quaternion.LookRotation( transform.position - target.position);		
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed); 
			
			//Go Forward
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
	}
}
