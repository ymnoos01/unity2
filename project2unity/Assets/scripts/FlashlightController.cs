using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight; // Reference to the flashlight light source
    private bool isFlashlightOn = false;

    void Start()
    {
        flashlight.enabled = false; // Ensure flashlight is initially off
    }

    void Update()
    {
        // Check for input to toggle flashlight
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        isFlashlightOn = !isFlashlightOn; // Toggle flashlight state

        // Enable/disable flashlight accordingly
        flashlight.enabled = isFlashlightOn;
    }
}