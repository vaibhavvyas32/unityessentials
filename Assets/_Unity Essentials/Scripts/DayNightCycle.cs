using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField] private float dayDurationInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed: 360 degrees per day duration
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light based on the speed
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
