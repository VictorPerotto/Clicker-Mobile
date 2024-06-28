using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;

    [SerializeField] private ClickerManager clickerManager;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }
    
    public void OnBuyButtonClicked(UpgradeSO upgradeSO, UpgradeSingleUI upgradeSingleUI){
        if(CoinsManager.Instance.GetCurrentCoins() > upgradeSO.price){
            switch(upgradeSO.upgradeType){
                case UpgradeType.clickPower:
                    CoinsManager.Instance.SubtractCoins(upgradeSO.price);
                    BuyClickerUpgrade(upgradeSO);
                    Destroy(upgradeSingleUI.gameObject);
                break;

                case UpgradeType.generatorPower:
                    CoinsManager.Instance.SubtractCoins(upgradeSO.price);
                    BuyGeneratorPowerUpgrade(upgradeSO);
                    Destroy(upgradeSingleUI.gameObject);
                break;

                case UpgradeType.generatorTimer:
                    CoinsManager.Instance.SubtractCoins(upgradeSO.price);
                    BuyGeneratorTimerUpgrade(upgradeSO);
                    Destroy(upgradeSingleUI.gameObject);
                break;
            }
        }
    }

    public void BuyClickerUpgrade(UpgradeSO upgradeSO){
        clickerManager.AddCoinsPerClick(upgradeSO.coinsPerClickMultiplier);
    }

    public void BuyGeneratorPowerUpgrade(UpgradeSO upgradeSO){
        upgradeSO.resourceGeneratorSO.generationAmount *= 2;
    }

    public void BuyGeneratorTimerUpgrade(UpgradeSO upgradeSO){
        upgradeSO.resourceGeneratorSO.generationTime /= 2;
    }
}
