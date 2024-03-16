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
