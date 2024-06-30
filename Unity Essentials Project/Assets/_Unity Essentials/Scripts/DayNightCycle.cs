using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLengthInSeconds = 60.0f; // Editable in the Inspector

    private float currentRotation = 0.0f; // Current rotation of the light

    void Update()
    {
        // Calculate the rotation amount per frame based on dayLengthInSeconds
        float rotationSpeed = 360.0f / dayLengthInSeconds * Time.deltaTime;

        // Rotate the directional light
        transform.Rotate(Vector3.right, rotationSpeed);

        // Keep track of the total rotation
        currentRotation += rotationSpeed;

        // If a full day rotation is completed, reset the rotation counter
        if (currentRotation >= 360.0f)
        {
            currentRotation -= 360.0f;
        }
    }
}