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


			//Transform pinkTarget = new Transform(lookat.point);

		} else {
			Debug.LogError("player is not looking at a wall?!");
		}
	}
}
