using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSingleUI : MonoBehaviour{
    
    [SerializeField] UpgradeSO upgradeSO;
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI descriptionText;
    [SerializeField] TextMeshProUGUI buyText;
    [SerializeField] Image iconSprite;
    [SerializeField] Button buyButton;

    private void Start(){
        UpdateUpgradeUI();
        buyButton.onClick.AddListener(OnBuyButtonClicked);
    }

    private void OnBuyButtonClicked(){
        switch(upgradeSO.upgradeType){
            case UpgradeType.clickPower:
                throw new NotImplementedException();
            break;

            case UpgradeType.generatorPower:
                throw new NotImplementedException();
            break;

            case UpgradeType.generatorTimer:
                throw new NotImplementedException();
            break;
        }
    }

    private void UpdateUpgradeUI(){
        descriptionText.SetText(upgradeSO.descriptionText) ;
        buyText.SetText(upgradeSO.price.ToString());
        titleText.SetText(upgradeSO.titleText) ;      
        iconSprite.sprite = upgradeSO.icon;
    }

    public void SetUpgradeSO(UpgradeSO upgradeSO){
        this.upgradeSO = upgradeSO;
    }

    public UpgradeSO GetUpgradeSO(){
        return upgradeSO;
    }
}
