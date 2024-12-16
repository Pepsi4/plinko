using UnityEngine;

[CreateAssetMenu(fileName = "ZoneConfig", menuName = "Configs/Zone Config", order = 0)]
public class ZoneConfig : ScriptableObject
{
    public string zoneName;
    public int balanceChange;
}
