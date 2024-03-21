using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private Light flashlight; // Reference to the flashlight light source
    private bool isFlashlightOn = false;
    private Collider myCollider; 

    void Start()
    {
        flashlight = GetComponent < Light > ();
        myCollider = GetComponent < Collider > ();
        flashlight.enabled = false;
        myCollider.enabled = false;
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
        myCollider.enabled = isFlashlightOn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
        {
            DeactivateSphere(other.gameObject); // Call the method to deactivate the sphere from FlashlightController
            Debug.Log("Spotlight has entered the sphere collider."); // Debug log
        }
    }

    public void DeactivateSphere(GameObject sphere)
    {
        // Deactivate the sphere
        Destroy(sphere);
        Debug.Log("Sphere is being deactivated."); // Debug log  
    }
}



// using UnityEngine;

// public class FlashlightController : MonoBehaviour
// {
//     public Light flashlight; // Reference to the flashlight light source
//     private bool isFlashlightOn = false;

//     void Start()
//     {
//         flashlight.enabled = false; // Ensure flashlight is initially off
//     }

//     void Update()
//     {
//         // Check for input to toggle flashlight
//         if (Input.GetKeyDown(KeyCode.E))
//         {
//             ToggleFlashlight();
//         }
//     }

//     void ToggleFlashlight()
//     {
//         isFlashlightOn = !isFlashlightOn; // Toggle flashlight state

//         // Enable/disable flashlight accordingly
//         flashlight.enabled = isFlashlightOn;
//     }

//     public bool IsFlashlightOn()
//     {
//         return isFlashlightOn;
//     }

//     public void DeactivateSphere(GameObject sphere)
//     {
//         // Deactivate the sphere
//         Destroy(sphere);
//         Debug.Log("Sphere is being deactivated."); // Debug log  
//     }
// }

// using UnityEngine;

// public class FlashlightController : MonoBehaviour
// {
//     public Light flashlight; // Reference to the flashlight light source
//     private bool isFlashlightOn = false;

//     void Start()
//     {
//         flashlight.enabled = false; // Ensure flashlight is initially off
//     }

//     void Update()
//     {
//         // Check for input to toggle flashlight
//         if (Input.GetKeyDown(KeyCode.E))
//         {
//             ToggleFlashlight();
//         }
//     }

//     void ToggleFlashlight()
//     {
//         isFlashlightOn = !isFlashlightOn; // Toggle flashlight state

//         // Enable/disable flashlight accordingly
//         flashlight.enabled = isFlashlightOn;
//     }

//     public bool IsFlashlightOn()
//     {
//         return isFlashlightOn;
//     }

//     public void DeactivateSphere(GameObject sphere)
//     {
//         // Deactivate the sphere
//         Destroy(sphere);
//     }
// }

