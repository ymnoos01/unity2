using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Transform characterTransform; // Reference to the character's transform
    private Light spotlight; // Reference to the Spotlight component

    void Start()
    {
        // Get the Spotlight component attached to the same GameObject as this script
        spotlight = GetComponent<Light>();
        // Ensure the spotlight is initially turned off
        spotlight.enabled = false;
    }

    void Update()
    {
        // Toggle the spotlight on/off when the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            spotlight.enabled = !spotlight.enabled;
        }

        // Make the spotlight follow the character's position
        if (characterTransform != null)
        {
            transform.position = characterTransform.position;
            // Optionally, you can adjust the height or distance of the spotlight above the character
            // For example, you can use transform.localPosition.y to adjust the height
            // transform.position = characterTransform.position + Vector3.up * desiredHeight;
        }
    }
}
