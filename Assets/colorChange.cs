using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {

	public bool inputColors = false;

	private float r,g,b,a = 1.0F;

	// Use this for initialization
	void Start () {
		Debug.Log ("rgba: " + r + "," + g + "," + b + "," + a);
	}
	
	// Update is called once per frame
	void Update () {
		
		//Debug.Log ("Velocity of " + name + " is: " + gameObject.GetComponent<Rigidbody> ().velocity);


		if (inputColors) {
			if (Input.GetKeyDown (KeyCode.R)) {
				//gameObject.renderer.material.color = Color.red;
				gameObject.GetComponent<Renderer> ().material.color = Color.red;
			}
			if (Input.GetKeyDown (KeyCode.G)) {
				gameObject.GetComponent<Renderer> ().material.color = Color.green;
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			}
		} else {
			if (gameObject.GetComponent<Renderer>())
				gameObject.GetComponent<Renderer> ().material.color = new Color (r, g, b, a);

			//if (gameObject.GetComponent<Rigidbody> ())
				//
		}
	}

}
