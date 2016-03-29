using UnityEngine;
using System.Collections;

public class Home1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton("Jump")) {
			Application.LoadLevel("scene2");
		}
	}
	// 接触したら Second Scene へ
	//private void OnCollisionEnter(Collision collision) {
	//	Application.LoadLevel("scene2");
	//}
}