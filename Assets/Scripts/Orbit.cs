using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public GameObject planet;
	public float speed;

	// Update is called once per frame
	void Update () {
		transform.RotateAround(planet.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
