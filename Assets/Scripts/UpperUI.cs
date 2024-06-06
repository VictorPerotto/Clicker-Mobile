using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpperUI : MonoBehaviour{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Start(){
        CoinsManager.Instance.OnCurrentCoinsChanged += CoinsManager_OnCurrentCoinsChanged;
    }

    private void CoinsManager_OnCurrentCoinsChanged(object sender, CoinsManager.OnCurrentCoinsChangedArgs e){
        SetCoinsText(e.currentCoins);
    }

    private void SetCoinsText(int amount){
        string amountText = amount.ToString();

        coinsText.SetText(amountText);
    }
}
