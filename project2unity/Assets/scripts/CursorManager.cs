// using UnityEngine;

// public class CursorManager : MonoBehaviour
// {
//     public CharacterController characterController;

//     void Start()
//     {
//         // Disable character controller on start
//         if (characterController != null)
//             characterController.enabled = false;

//         // Enable mouse cursor
//         Cursor.lockState = CursorLockMode.None;
//         Cursor.visible = true;
//     }

//     public void DisableCharacterController()
//     {
//         if (characterController != null)
//             characterController.enabled = false;
//     }

//     public void EnableMouseCursor()
//     {
//         // Enable mouse cursor
//         Cursor.lockState = CursorLockMode.None;
//         Cursor.visible = true;
//     }

//     public void EnableCharacterController()
//     {
//         // if (characterController != null)
//         //     characterController.enabled = true;

//         // Lock mouse cursor
//         Cursor.lockState = CursorLockMode.Locked;
//         Cursor.visible = false;
//     }

// }


















// using UnityEngine;

// public class CursorManager : MonoBehaviour
// {
//     public CharacterController characterController;

//     void Start()
//     {
//         // Disable character controller and show mouse cursor on start
//         DisableCharacterController();
//         EnableMouseCursor();
//     }

//     public void DisableCharacterController()
//     {
//         if (characterController != null)
//             characterController.enabled = false;
//     }

//     public void EnableMouseCursor()
//     {
//         // Show mouse cursor
//         Cursor.lockState = CursorLockMode.None;
//         Cursor.visible = true;
//     }

//     public void EnableCharacterController()
//     {
//         if (characterController != null)
//             characterController.enabled = true;

//         // Hide mouse cursor
//         Cursor.lockState = CursorLockMode.Locked;
//         Cursor.visible = false;
//     }
// }




using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public bool shouldEnableCursor = false;

    void Start()
    {
        if(shouldEnableCursor) {
            EnableMouseCursor();
        } else {
            DisableMouseCursor();
        }
    }

    public void EnableMouseCursor()
    {
        // Show mouse cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DisableMouseCursor()
    {
        // Hide mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
