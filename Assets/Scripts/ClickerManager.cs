using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour{
    
    private Button clickButton;
    [SerializeField] private int coinsPerClick;

    private void Start(){
        clickButton = GetComponentInChildren<Button>();
        clickButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick(){
        CoinsManager.Instance.AddCoins(coinsPerClick);
    }
}
