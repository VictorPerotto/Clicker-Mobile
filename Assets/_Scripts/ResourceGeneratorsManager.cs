using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine;

public class ResourceGeneratorsManager : MonoBehaviour{
    
    public static ResourceGeneratorsManager Instance;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void BuyResourceGenerator(ResourceGeneratorSO resourceGenerator){
        BigDouble totalCoins = CoinsManager.Instance.GetCurrentCoins();

        if(totalCoins >= resourceGenerator.price){
            resourceGenerator.generatorCount += 1;
            CoinsManager.Instance.SubtractCoins(resourceGenerator.price);
        }
    }
}
