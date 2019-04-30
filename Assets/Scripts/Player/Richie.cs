using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Richie : MonoBehaviour
{
    Animator m_Animator;

    bool gameEnded = false;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
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

        m_Animator.SetTrigger("Game Over");
       
    }
}
