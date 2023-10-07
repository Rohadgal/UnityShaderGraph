using UnityEngine;

public class brokenLight : MonoBehaviour
{
    public Light targetLight;
    public float minTimeOn = 0.1f; // Minimum time the light stays on
    public float maxTimeOn = 1.0f; // Maximum time the light stays on
    public float minTimeOff = 0.1f; // Minimum time the light stays off
    public float maxTimeOff = 1.0f; // Maximum time the light stays off

    private bool isLightOn = false;
    private float nextToggleTime;

    private void Start() {
        // Initialize the next toggle time
        nextToggleTime = Random.Range(minTimeOff, maxTimeOff);
    }

    private void Update() {
        // Check if it's time to toggle the light
        if (Time.time >= nextToggleTime) {
            ToggleLight();
        }
    }

    private void ToggleLight() {
        // Toggle the light on or off
        isLightOn = !isLightOn;
        targetLight.enabled = isLightOn;

        // Set the next toggle time based on whether the light is currently on or off
        if (isLightOn) {
            nextToggleTime = Time.time + Random.Range(minTimeOn, maxTimeOn);
        } else {
            nextToggleTime = Time.time + Random.Range(minTimeOff, maxTimeOff);
        }
    }
}
