using UnityEngine;
using TMPro;
using Zenject;

public class BalanceUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI balanceText;
    [Inject] private BalanceManager balanceManager;

    private void Start()
    {
        balanceManager.OnBalanceDepleted += ShowLowBalanceMessage;
        UpdateBalanceUI();
    }

    private void UpdateBalanceUI()
    {
        balanceText.text = $"Balance: {balanceManager.Balance}";
    }

    private void ShowLowBalanceMessage()
    {
        Debug.Log("Balance is depleted! Please refill.");
    }
}
