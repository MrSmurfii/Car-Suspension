using UnityEngine;

public class Suspension : MonoBehaviour {
    [SerializeField]private float freeLength = 1.2f;

    [SerializeField] private Transform contactTransform = null;
    private Rigidbody rb;
  
    [SerializeField]private float proportional = 1f;
    [SerializeField]private float integral = 1f;
    [SerializeField]private float derivative = 1f;
    private PIDController pidController = null;
    
    void Start() {
        rb = GetComponent<Rigidbody>();
        pidController = new PIDController(proportional, integral, derivative);
    }

    private void FixedUpdate() {
        rb.AddForce(TotalForce(), ForceMode.Force);
    }

    float CalculateLength() {
        return transform.position.y - contactTransform.position.y;
    }

    float LengthError() {
        return CalculateLength() - freeLength;
    }

    Vector3 TotalForce() {
        return -pidController.OutputValue(LengthError()) * Vector3.up;
    }
}