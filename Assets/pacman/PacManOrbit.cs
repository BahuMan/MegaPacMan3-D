using UnityEngine;
using System.Collections;

/**
 * Based on MouseOrbit.js from the standard scripts package.
 */
public class PacManOrbit : MonoBehaviour {

	public Transform target;
	public float distance;

	public float xSpeed, ySpeed;
	public float yMinLimit, yMaxLimit;
	public float flySpeed;

	private float x,y;

	// Use this for initialization
	void Start () {
		Vector3 angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (target != null) {
			
			//Line added by Bart to increase/decrease distance to target on the fly
			distance = distance + Input.GetAxis("Mouse ScrollWheel") * flySpeed;// * Time.deltaTime;
			
			x += Input.GetAxis("Horizontal") * xSpeed * -0.02f;
			y -= Input.GetAxis("Vertical") * ySpeed * -0.02f;
			
			y = ClampAngle(y, yMinLimit, yMaxLimit);
			
			Quaternion rotation = Quaternion.Euler(y, x, 0);
			Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position + new Vector3(0.0f, 1.0f, 0.0f);
			
			transform.rotation = rotation;
			transform.position = position;
			
		}
	}

	private static float ClampAngle (float angle, float min, float max) {
		if (angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		return Mathf.Clamp (angle, min, max);
	}
}
