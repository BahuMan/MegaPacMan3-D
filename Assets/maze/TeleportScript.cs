using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	public Transform transportTarget;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("Transporting " + other.gameObject.name);
		NavMeshAgent agent = other.GetComponent<NavMeshAgent> ();
		if (agent != null) {
			agent.enabled = false;
		}
		other.transform.position = transportTarget.position;
		if (agent != null) {
			agent.enabled = true;
		}
	}
}
