using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {

	public GameObject obj;
	public float intensity = 1;

	private Vector3 colPos;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		//willBounce = false;
		Debug.Log (name + " is alive! during " + Time.fixedTime + " at " + transform.position);
	}

	// Update is called once per frame
	void Update () {
		/*
		currPos = obj.getComponent<Rigidbody>().transform.position;
		if (lastPos != currPos) {
			Debug.Log("Bouncing at " + currPos);
			lastPos = currPos;
			//Vector3 velocity = gameObject.velocity;
			//gameObject.velocity = new Vector3 (velocity.x, 0, velocity.z);
			//willBounce = false;
		}
		*/
	}

	void OnCollisionEnter (Collision col) {
		Debug.LogFormat ("<size=23><color=red><b>༼ つ ◕_◕ ༽つ</b></color></size> Collision");
		//obj = col.getComponent<GameObject>().gameObject;
		colPos = col.gameObject.transform.position;
		rb = col.gameObject.GetComponent<Rigidbody> ();

		Vector3 movement = new Vector3 (0.0f, 1.0f, 0.0f);

		//Vector3 movement = new Vector3 (0.0f, 0.5f, 0.0f,);

		//transform.position = colPos;
		rb.AddForce (movement * intensity);
	}	

}
