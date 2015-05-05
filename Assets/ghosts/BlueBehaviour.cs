using UnityEngine;
using System.Collections;

public class BlueBehaviour : MonoBehaviour {

	public Transform blinky;

	private Transform player;
	private NavMeshAgent agent;

	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player").transform;
		agent = GetComponent<NavMeshAgent> ();	
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerpos = player.position;
		Vector3 blinkypos = blinky.position;
		//go to the other side of the player:
		agent.SetDestination ((playerpos - blinkypos) + playerpos);
	}
}
