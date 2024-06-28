using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour{
    

    [SerializeField] private Button clickButton;
    [SerializeField] private BigDouble coinsPerClick;

    private void Start(){
        clickButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick(){
        CoinsManager.Instance.AddCoins(coinsPerClick);
    }

    public BigDouble GetCoinsPerClick(){
        return coinsPerClick;
    }

    public void AddCoinsPerClick(double amount){
        coinsPerClick *= amount;
    }
}
