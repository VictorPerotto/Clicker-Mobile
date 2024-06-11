using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour{
    
    [SerializeField] private Button clickButton;
    [SerializeField] private int coinsPerClick;

    private void Start(){
        clickButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick(){
        CoinsManager.Instance.AddCoins(coinsPerClick);
    }
}
