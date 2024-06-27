using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/UpgradeSO")]
public class UpgradeSO : ScriptableObject{
    [Header("Variables")]
    public UpgradeType upgradeType;
    public BigDouble price;

    [Header("Visuals")]
    public Sprite icon;
    public string descriptionText;
    public string titleText;
}

public enum UpgradeType{
    clickPower,
    generatorPower,
    generatorTimer
}