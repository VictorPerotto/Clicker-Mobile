using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/UpgradeListSO")]
public class UpgradeListSO : ScriptableObject{
    public List<UpgradeSO> list;
}
