using UnityEngine;
using System.Collections;

public class PinkBehaviour : MonoBehaviour {

	private Transform player;
	private NavMeshAgent agent;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player").transform;
		agent = GetComponent<NavMeshAgent> ();	
	}
	
	// Update is called once per frame
	void Update () {
		Ray looking = new Ray (player.position, player.forward);
		RaycastHit lookat;
		if (Physics.Raycast (looking, out lookat)) {
			agent.SetDestination(lookat.point);

			//Transform pinkTarget = new Transform(lookat.point);

		} else {
			//this can happen when pacman is walking into the teleport. At that time, he's looking at a hole in the wall
			//Debug.LogError("player is not looking at a wall?!");
		}
	}
}
