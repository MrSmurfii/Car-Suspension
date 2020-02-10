using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField]private Vector3 offset;
    [SerializeField] private GameObject follow;

    private Transform transform;
    private void Start() {
		transform = GetComponent<Transform>();
	}

    private void Update() {
        transform.position = (follow.transform.position + offset);
    }
}
