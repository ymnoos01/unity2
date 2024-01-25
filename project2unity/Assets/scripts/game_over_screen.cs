using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over_screen : MonoBehaviour
{
   public GameObject gameOverUI;  

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}
