using UnityEngine;
using System.Collections;

public class Wander : MonoBehaviour {
	public float speed = 100.0f;

	//public float rotSpeed = 2.0f;

	public float maxRotation = 15.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float dev = Random.value - Random.value;
		transform.Rotate (new Vector3 (0, 1, 0), dev * maxRotation);
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	
	}
}
