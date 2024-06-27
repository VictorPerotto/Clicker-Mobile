using System.Collections;
using BreakInfinity;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeUI : HideableInterface
{
    [SerializeField] private UpgradeListSO upgradeListSO;
    [SerializeField] private List<UpgradeSingleUI> UpgradeSingleUIList;
    [SerializeField] private GameObject upgradeSingleUIPrefab;
    [SerializeField] private GameObject content;
    [SerializeField] private float timerMax;
    private float timer;
    
    void Start(){
        PopulateUpgrades();
    }

    void Update(){
    if(timer <= 0){
            timer = timerMax;
            BigDouble currentCoins = CoinsManager.Instance.GetCurrentCoins();
            if(UpgradeSingleUIList.Count > 0){
                for(int i =0; i < UpgradeSingleUIList.Count; i ++){
                    if(currentCoins < UpgradeSingleUIList[i].GetUpgradeSO().unlockPrice){
                        UpgradeSingleUIList[i].gameObject.SetActive(false);
                    }
                    else{
                        UpgradeSingleUIList[i].gameObject.SetActive(true);
                        UpgradeSingleUIList.Remove(UpgradeSingleUIList[i]);
                    }
                }        
            }
        }

        timer -= Time.deltaTime;
    }

    private void PopulateUpgrades(){
        foreach(var upgradeSO in upgradeListSO.list){
            var newUpgrade = Instantiate(upgradeSingleUIPrefab, content.transform).GetComponent<UpgradeSingleUI>();
            newUpgrade.SetUpgradeSO(upgradeSO);
            UpgradeSingleUIList.Add(newUpgrade);
        }
    }
}
