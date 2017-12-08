using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerastable : MonoBehaviour {

	// Update is called once per frame
	public GameObject Thecar;
	public float carx;
	public float cary;
	public float carz;

	void Update () {
		carx = Thecar.transform.eulerAngles.x;
		cary = Thecar.transform.eulerAngles.y;
		carz = Thecar.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3 (carx - carx, cary, carz - carz);

	}
}
