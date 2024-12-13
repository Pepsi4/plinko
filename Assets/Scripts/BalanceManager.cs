using UnityEngine;
using System;

public class BalanceManager : MonoBehaviour
{
    public event Action OnBalanceDepleted;

    public int Balance { get; private set; }

    public void AddBalance(int amount)
    {
        Balance += amount;
    }

    public void DeductBalance(int amount)
    {
        Balance -= amount;
        if (Balance <= 0)
        {
            OnBalanceDepleted?.Invoke();
        }
    }
}
