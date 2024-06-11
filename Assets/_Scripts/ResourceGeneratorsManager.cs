using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneratorsManager : MonoBehaviour{
    
    public static ResourceGeneratorsManager Instance;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void BuyResourceGenerator(ResourceGeneratorSO resourceGenerator){
        int totalCoins = CoinsManager.Instance.GetCurrentCoins();

        if(totalCoins >= resourceGenerator.price){
            resourceGenerator.generatorCount += 1;
            CoinsManager.Instance.SubtractCoins(resourceGenerator.price);
            resourceGenerator.isActive = true;
        }
    }

    void Start(){
        
    }

    void Update(){
        
    }
}
