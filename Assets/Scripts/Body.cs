using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour {
    [SerializeField] private Transform backLeftSuspension, backRightSuspension, frontLeftSuspension, frontRightSuspension;

    private void Update() {
        Vector3 position = new Vector3();

        position = (backLeftSuspension.position + backRightSuspension.position + frontLeftSuspension.position + frontRightSuspension.position) / 4f;
        transform.position = position;
        transform.up = CalculateNormals();
    }

    Vector3 CalculateNormals() {
        Vector3 backLeftToBackRight = backLeftSuspension.position - backRightSuspension.position; 
        Vector3 frontRightToBackRight = frontRightSuspension.position - backRightSuspension.position;
        Vector3 frontRightToFrontLeft = frontRightSuspension.position - frontLeftSuspension.position;
        Vector3 backLeftToFrontLeft = backLeftSuspension.position - frontLeftSuspension.position;
        
        Vector3 cross = Vector3.Cross(backLeftToBackRight, frontRightToBackRight);
        Vector3 cross2 = Vector3.Cross(frontRightToFrontLeft, backLeftToFrontLeft);

        return ((cross + cross2)).normalized;
    }
}
