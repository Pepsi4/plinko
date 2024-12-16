using UnityEngine;
using Zenject;

[RequireComponent(typeof(Collider2D))]
public class Zone : MonoBehaviour
{
    [SerializeField] private ZoneConfig zoneConfig;

    private BalanceManager balanceManager;

    [Inject]
    private void Construct(BalanceManager balanceManager)
    {
        this.balanceManager = balanceManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) // Перевіряємо, що об'єкт - це м'ячик
        {
            Debug.Log($"Ball entered zone: {zoneConfig.zoneName}");
            balanceManager.ChangeBalance(zoneConfig.balanceChange);
        }
    }
}
