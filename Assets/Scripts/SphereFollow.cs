using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFollow : MonoBehaviour {
    [SerializeField]private GameObject cube;

    private Transform cubeTransform;

    private void Start() {
        cubeTransform = cube.transform;
    }

    void Update() {
        Vector3 position = cubeTransform.position;
        position.y = transform.position.y;
        transform.position = position;
    }
}
