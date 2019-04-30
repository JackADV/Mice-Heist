using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text livesText;
    public GameObject heart;
    public GameObject impacteffect;

    bool gameEnded = false;

    #region
    bool lostOne = false;
    bool lostTwo = false;
    bool lostThree = false;
    bool lostFour = false;
    bool lostFive = false;
    bool lostSix = false;
    bool lostSeven = false;
    bool lostEight = false;
    bool lostNine = false;
#endregion

    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString();

        

        #region
        if (PlayerStats.Lives == 9)
        {
            if (lostOne)
                return;
            NineLives();
        }

        if (PlayerStats.Lives == 8)
        {
            if (lostTwo)
                return;
            EightLives();
        }

        if (PlayerStats.Lives == 7)
        {
            if (lostThree)
                return;
            SevenLives();
        }

        if (PlayerStats.Lives == 6)
        {
            if (lostFour)
                return;
            SixLives();
        }

        if (PlayerStats.Lives == 5)
        {
            if (lostFive)
                return;
            FiveLives();
        }

        if (PlayerStats.Lives == 4)
        {
            if (lostSix)
                return;
            FourLives();
        }

        if (PlayerStats.Lives == 3)
        {
            if (lostSeven)
                return;
            ThreeLives();
        }

        if (PlayerStats.Lives == 2)
        {
            if (lostEight)
                return;
            TwoLives();
        }

        if (PlayerStats.Lives == 1)
        {
            if (lostNine)
                return;
            OneLife();
        }

        if (PlayerStats.Lives <= 0)
        {
            if (gameEnded)
                return;
            EndGame();
        }

        #endregion
    }

    void EndGame()
    {
        gameEnded = true;
        Destroy(heart);
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
    }


    #region
    void NineLives()
    {
        lostOne = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }

    void EightLives()
    {
        lostTwo = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void SevenLives()
    {
        lostThree = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void SixLives()
    {
        lostFour = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void FiveLives()
    {
        lostFive = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void FourLives()
    {
        lostSix = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void ThreeLives()
    {
        lostSeven = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void TwoLives()
    {
        lostEight = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }


    void OneLife()
    {
        lostNine = true;
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);
        m_Animator.SetTrigger("Shake");
    }
    #endregion
}
