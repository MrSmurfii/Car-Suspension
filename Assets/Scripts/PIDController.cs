using UnityEngine;

public class PIDController {
    private float proportional = 1f;
    private float integral = 1f;
    private float derative = 1f;

    private float sumOfPastErrors = 0f;
    private float oldError = 0f;
    
    
    public PIDController(float p, float i, float d) {
        proportional = p;
        integral = i;
        derative = d;

        sumOfPastErrors = 0f;
    }

    public float OutputValue(float error) {
        float toReturn = 0f;

        toReturn += proportional * error;

        sumOfPastErrors += error * Time.fixedDeltaTime;
        toReturn += integral * sumOfPastErrors;

        float derativeError = (error - oldError) / Time.fixedDeltaTime;

        toReturn += derative * derativeError;
        oldError = error;
        
        return toReturn;
    }
}
