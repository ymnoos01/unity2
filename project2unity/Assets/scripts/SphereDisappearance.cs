using UnityEngine;

public class SphereDisappearance : MonoBehaviour
{
    private FlashlightController flashlightController; // Reference to the FlashlightController script
    private bool isSpotlightTouchingSphere = false;

    private void Start()
    {
        flashlightController = FindObjectOfType<FlashlightController>(); // Find the FlashlightController in the scene
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
        {
            isSpotlightTouchingSphere = true;
            flashlightController.DeactivateSphere(other.gameObject); // Call the method to deactivate the sphere from FlashlightController
            Debug.Log("Spotlight has entered the sphere collider."); // Debug log
        }
    }

    // private void OnTriggerEnter(Collider other)
    //  {
    //      if (other.gameObject.CompareTag("Sphere")) 
    //      {
    //          isSpotlightTouchingSphere = true;

    //          if (flashlightController.isFlashlightOn())
    //          {
    //              flashlightController.DeactivateSphere(other.gameObject); 
    //              Debug.Log("Spotlight has entered the sphere collider. Sphere deactivated."); 
    //          }
    //          else
    //          {
    //              Debug.Log("Spotlight has entered the sphere collider, but the flashlight is off. Sphere not deactivated."); 
    //          }
    //      }
    //  }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
        {
            isSpotlightTouchingSphere = false;
            Debug.Log("Spotlight has exited the sphere collider."); // Debug log
        }
    }
}

//222222222

// using UnityEngine;

// public class SphereDisappearance : MonoBehaviour
// {
//     private FlashlightController flashlightController; // Reference to the FlashlightController script
//     private bool isSpotlightTouchingSphere = false;

//     private void Start()
//     {
//         flashlightController = FindObjectOfType<FlashlightController>(); // Find the FlashlightController in the scene
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             if (flashlightController != null && flashlightController.enabled) // Check if the flashlight is enabled
//             {
//                 isSpotlightTouchingSphere = true;
//                 flashlightController.DeactivateSphere(other.gameObject); // Call the method to deactivate the sphere from FlashlightController
//                 Debug.Log("Spotlight has entered the sphere collider."); // Debug log
//             }
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             isSpotlightTouchingSphere = false;
//             Debug.Log("Spotlight has exited the sphere collider."); // Debug log
//         }
//     }
// }


//333333333333333333333



// using UnityEngine;

// public class SphereDisappearance : MonoBehaviour
// {
//     private FlashlightController flashlightController; // Reference to the FlashlightController script
//     private bool isSpotlightTouchingSphere = false;

//     private void Start()
//     {
//         flashlightController = FindObjectOfType<FlashlightController>(); // Find the FlashlightController in the scene
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             if (flashlightController != null && flashlightController.IsFlashlightOn()) // Check if the flashlight is on
//             {
//                 isSpotlightTouchingSphere = true;
//                 flashlightController.DeactivateSphere(other.gameObject); // Call the method to deactivate the sphere from FlashlightController
//                 Debug.Log("Spotlight has entered the sphere collider."); // Debug log
//             }
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             isSpotlightTouchingSphere = false;
//             Debug.Log("Spotlight has exited the sphere collider."); // Debug log
//         }
//     }
// }

// using UnityEngine;

// public class SphereDisappearance : MonoBehaviour
// {
//     private FlashlightController flashlightController; // Reference to the FlashlightController script
//     private bool isSpotlightTouchingSphere = false;

//     private void Start()
//     {
//         flashlightController = FindObjectOfType<FlashlightController>(); // Find the FlashlightController in the scene
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             if (flashlightController != null && flashlightController.IsFlashlightOn()) // Check if the flashlight is on
//             {
//                 isSpotlightTouchingSphere = true;
//                 flashlightController.DeactivateSphere(other.gameObject); // Call the method to deactivate the sphere from FlashlightController
//                 Debug.Log("Sphere is being deactivated."); // Debug log
//             }
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             isSpotlightTouchingSphere = false;
//         }
//     }
// }

