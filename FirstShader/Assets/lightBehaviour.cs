using System.Collections;
using UnityEngine;

public class lightBehaviour : MonoBehaviour
{
    public Light pointLight;
    public float minRange = 0f;
    public float maxRange = 10f;
    public float fluctuationSpeed = 1f;

    private float elapsedTime = 0f;

    private void Start() {
        // Start the coroutine to fluctuate the light range
        StartCoroutine(FluctuateLightRange());
    }

    private IEnumerator FluctuateLightRange() {
        while (true) // This will keep the fluctuation running indefinitely
        {
            // Calculate a new range based on a sine wave
            float newRange = Mathf.Lerp(minRange, maxRange, Mathf.Sin(elapsedTime));

            // Update the light's range
            pointLight.range = newRange;

            // Increment the time based on fluctuation speed
            elapsedTime += Time.deltaTime * fluctuationSpeed;

            // Wait for the next frame
            yield return null;
        }
    }   
}
