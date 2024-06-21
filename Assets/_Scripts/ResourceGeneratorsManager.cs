using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneratorsManager : MonoBehaviour{
    
    public static ResourceGeneratorsManager Instance;

    [SerializeField] private float timerMax;
    [SerializeField] private float timer;

    public ResourceGeneratorListSO resourceGeneratorListSO;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void BuyResourceGenerator(ResourceGeneratorSO resourceGenerator){
        double totalCoins = CoinsManager.Instance.GetCurrentCoins();

        if(totalCoins >= resourceGenerator.price){
            resourceGenerator.generatorCount += 1;
            CoinsManager.Instance.SubtractCoins(resourceGenerator.price);
            resourceGenerator.isActive = true;
        }
    }

    void Start(){
        
    }

    void Update(){
        /*if(timer <= 0){
            timer = timerMax;

            foreach(var resourceGenerator in resourceGeneratorListSO.list){
                if(!resourceGenerator.isUnlockable){
                    if(CoinsManager.Instance.GetCurrentCoins() >= resourceGenerator.unlockPrice) resourceGenerator.isUnlockable = true;
                }
            }
        }

        timer -= Time.deltaTime;*/
    }
}
