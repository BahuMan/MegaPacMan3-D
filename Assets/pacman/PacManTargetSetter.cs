using UnityEngine;
using System.Collections;

public class PacManTargetSetter : MonoBehaviour {
	
	private NavMeshAgent pacManNavigator;
	private Camera mainCamera;


	// Use this for initialization
	void Start () {
		//this code might break when we're using multiple cameras
		//we need the camera to determine the new target when a mousebutton is clicked
		mainCamera = Camera.main;

		pacManNavigator = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log ("setting new destination");
			setNewTarget ();
		}
	}

	private void setNewTarget() {
		RaycastHit hit;
		//where is the camera looking?
		Ray pointAt = mainCamera.ScreenPointToRay(Input.mousePosition); //new Ray (mainCamera.transform.position, mainCamera.transform.forward);
		//what are we looking at?
		if (Physics.Raycast (pointAt, out hit)) {
			//now move backwards a little bit, because we don't want to move into the wall
			Vector3 newTarget = hit.point;// - mainCamera.transform.forward;

			pacManNavigator.SetDestination(newTarget);
		}
	}

	public Vector3 getTarget() {
		return pacManNavigator.destination;
	}

}
