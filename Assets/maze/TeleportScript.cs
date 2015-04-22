using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	public Transform transportTarget;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other) {
		other.transform.position = transportTarget.position;
	}
}
