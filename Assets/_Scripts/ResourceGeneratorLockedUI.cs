using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceGeneratorLockedUI : MonoBehaviour{

    [Header("Components")]
    [SerializeField] private TextMeshProUGUI text;

    [Header("DebugOnly")]
    [SerializeField] private ResourceGeneratorSO resourceGeneratorSO;
    

    public void SetResourceGeneratorSO(ResourceGeneratorSO resourceGeneratorSO){
        this.resourceGeneratorSO = resourceGeneratorSO;
    }

    void Start(){
        CoinsManager.Instance.OnCurrentCoinsChanged += CoinsManager_OnCurrentCoinsChanged;
        text.SetText("Unlock at " + resourceGeneratorSO.price.ToString() + " <sprite index=0>");
    }

    private void CoinsManager_OnCurrentCoinsChanged(object sender, CoinsManager.OnCurrentCoinsChangedArgs e){
        if(CoinsManager.Instance.GetCurrentCoins() < resourceGeneratorSO.price && resourceGeneratorSO.generatorCount == 0){
            gameObject.SetActive(true);
        }
        else{
            gameObject.SetActive(false);
            CoinsManager.Instance.OnCurrentCoinsChanged -= CoinsManager_OnCurrentCoinsChanged;
        }
    }
}
