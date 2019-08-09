﻿using UnityEngine;

public class CameraController : MonoBehaviour
{

	private bool doMovement = true;
	public float panSpeed = 30f;
	public float panBorderThickness = 10f;
	public float scrollSpeed = 5f;
	public float minY = 30f;
	public float maxY = 80f;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			doMovement = !doMovement;
		}
		if (!doMovement) 
		{
			return;
		}

		if (Input.GetKey (KeyCode.W) || Input.mousePosition.y >= Screen.height - panBorderThickness && transform.position.z < -30f) 
		{
			transform.Translate (Vector3.forward * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.S) || Input.mousePosition.y <= panBorderThickness && transform.position.z > -90f) 
		{
			transform.Translate (Vector3.back * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.D) || Input.mousePosition.x >= Screen.width - panBorderThickness && transform.position.x < 75f) 
		{
			transform.Translate (Vector3.right * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.A) || Input.mousePosition.x <= panBorderThickness && transform.position.x > 3) 
		{
			transform.Translate (Vector3.left * panSpeed * Time.deltaTime, Space.World);
		}

		float scroll = Input.GetAxis ("Mouse ScrollWheel");
		Vector3 pos = transform.position;
		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp (pos.y, minY, maxY);

		transform.position = pos;
	}
}
