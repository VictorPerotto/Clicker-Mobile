using System;
using BreakInfinity;
using TMPro;
using UnityEngine;

public class UpperUI : MonoBehaviour{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Start(){
    }

    private void Update(){
        SetCoinsText(CoinsManager.Instance.GetCurrentCoins());
    }

    private void SetCoinsText(BigDouble amount){
        string amountText = Methods.Notate(amount);
        
        coinsText.SetText(amountText);
    }
}
