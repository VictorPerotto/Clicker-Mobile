using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpperUI : MonoBehaviour{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Start(){

    }

    private void Update(){
        SetCoinsText(CoinsManager.Instance.GetCurrentCoins());
    }

    private void SetCoinsText(int amount){
        string amountText = amount.ToString();

        coinsText.SetText(amountText);
    }
}
