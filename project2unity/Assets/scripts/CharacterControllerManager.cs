using UnityEngine;

public class CharacterControllerManager : MonoBehaviour
{
    public CharacterController characterController;

    void Start()
    {
        // Disable character controller on start
        if (characterController != null)
            characterController.enabled = false;

        // Enable mouse cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DisableCharacterController()
    {
        if (characterController != null)
            characterController.enabled = false;
    }

    public void EnableMouseCursor()
    {
        // Enable mouse cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
