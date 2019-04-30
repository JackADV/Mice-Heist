using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int StartMoney = 30;

    public static int Lives;
    public int startLives = 10;

    private void Start()
    {
        Money = StartMoney;
        Lives = startLives;
    }

}
