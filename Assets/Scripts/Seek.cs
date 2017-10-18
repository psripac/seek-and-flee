﻿using UnityEngine;
using System.Collections;

public class Seek : MonoBehaviour {

	public float speed = 100.0f;

	public float rotSpeed = 2.0f;

	public Transform target;

	private float min_dis = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (target.position);
		if (Vector3.Distance (transform.position, target.position) > min_dis) 
		{
			//Rotate to the target point
			Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);		
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed); 

			//Go Forward
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		
	}
}
