using System;
using UnityEngine;

public class Movement : MonoBehaviour {
	private Transform transform;
	[SerializeField] private float moveSpeed = 1f;
	
	private void Start() {
		transform = GetComponent<Transform>();
	}

	private void Update() {
		if (Input.GetKey(KeyCode.W))
			transform.Translate(Time.deltaTime * moveSpeed * Vector3.forward);
		if (Input.GetKey(KeyCode.S))
			transform.Translate(Time.deltaTime * moveSpeed * -Vector3.forward);
		if (Input.GetKey(KeyCode.A))
			transform.Translate(Time.deltaTime * moveSpeed * -Vector3.right);
		if (Input.GetKey(KeyCode.D))
			transform.Translate(Time.deltaTime * moveSpeed * Vector3.right);
	}
}
