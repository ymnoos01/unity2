// using UnityEngine;

// public class SphereDisappearance : MonoBehaviour
// {
//     public GameObject sphere; // Reference to the sphere game object
//     public Light flashlight; // Reference to the flashlight light source

//     void Update()
//     {
//         if (IsSpotlightTouchingSphere())
//         {
//             sphere.SetActive(false); // Deactivate the sphere
//         }
//     }

//     bool IsSpotlightTouchingSphere()
//     {
//         RaycastHit hit;
//         Vector3 spotlightDirection = flashlight.transform.forward;

//         if (Physics.Raycast(flashlight.transform.position, spotlightDirection, out hit))
//         {
//             if (hit.collider.gameObject == sphere)
//             {
//                 Debug.Log("Spotlight is touching the sphere!"); // Debug log
//                 return true; // The spotlight is touching the sphere
//             }
//         }

//         return false; // The spotlight is not touching the sphere
//     }
// }





//22222222222222222222222222222222




// using UnityEngine;

// public class SphereDisappearance : MonoBehaviour
// {
//     private bool isSpotlightTouchingSphere = false;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
//         {
//             isSpotlightTouchingSphere = true;
//             Debug.Log("Spotlight has entered the sphere collider."); // Debug log
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

//     void Update()
//     {
//         if (isSpotlightTouchingSphere)
//         {
//             gameObject.SetActive(false); // Deactivate the sphere
//             Debug.Log("Sphere is being deactivated."); // Debug log
//         }
//     }
// }

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
            flashlightController.DeactivateSphere(); // Call the method to deactivate the sphere from FlashlightController
            Debug.Log("Spotlight has entered the sphere collider."); // Debug log
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere")) // Assuming the sphere has the tag "Sphere"
        {
            isSpotlightTouchingSphere = false;
            Debug.Log("Spotlight has exited the sphere collider."); // Debug log
        }
    }
}