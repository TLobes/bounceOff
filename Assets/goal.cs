using UnityEngine;
using System.Collections;

public class goal : MonoBehaviour {
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		score++;
		Debug.Log ("Trigger entered. Score is: " + score);
	}
}
