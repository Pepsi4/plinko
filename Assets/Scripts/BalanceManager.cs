using System;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    public Action OnBalanceDepleted;
    private float balance;

    public float Balance => balance;

    public void ChangeBalance(float coefficient)
    {
        balance *= coefficient;
    }
}
