using UnityEngine;

public class SphereController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Spotlight")) // Assuming the spotlight has a tag "Spotlight"
        {
            Destroy(gameObject); // This destroys the sphere object
        }
    }
}

// using UnityEngine;

// public class SphereController : MonoBehaviour
// {
//     public GameObject spotlight; // Reference to the spotlight object

//     private void Start()
//     {
//         spotlight = GameObject.FindGameObjectWithTag("Spotlight"); // Find the spotlight object by tag
//         if (spotlight == null)
//         {
//             Debug.LogError("Spotlight not found! Make sure the spotlight has the 'Spotlight' tag assigned.");
//         }
//     }

//     private void Update()
//     {
//         if (IsTouchingSpotlight())
//         {
//             Debug.Log("Sphere touched by spotlight!"); // Log a message when the sphere is touched by the spotlight
//             Destroy(gameObject); // This destroys the sphere object
//         }
//     }

//     private bool IsTouchingSpotlight()
//     {
//                 if (spotlight != null)
//         {
//             Vector3 direction = spotlight.transform.position - transform.position;
//             float angle = Vector3.Angle(direction, transform.forward);

//             if (angle < spotlight.GetComponent<Light>().spotAngle / 2)
//             {
//                 RaycastHit hit;
//                 if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
//                 {
//                     if (hit.collider.CompareTag("Spotlight"))
//                     {
//                         return true;
//                     }
//                 }
//             }
//         }
//         return false;
//     }
// }