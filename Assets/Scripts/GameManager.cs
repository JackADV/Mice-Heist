using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public GameObject completeLevelUI;

	void Update ()
    {
        if (gameEnded)
            return;

		if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        gameEnded = true;
    }

    public void WinLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
