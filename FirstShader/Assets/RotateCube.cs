using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, rotationAmount);
    }
}
