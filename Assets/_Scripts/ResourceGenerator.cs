using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour{
    
    [SerializeField] private ResourceGeneratorSO resourceGeneratorSO;
    private float timerMax;
    private float timer;

    private void Start(){
    }

    private void Update(){
        if(resourceGeneratorSO.isActive){
            if(timer <= 0){
                timer = timerMax;
                CalculateCoins();
            }
            timer -= Time.deltaTime;
        }
    }

    //calculate the amount of coins to add
    private void CalculateCoins(){
        int coins = resourceGeneratorSO.generationAmount * resourceGeneratorSO.generatorCount;
        CoinsManager.Instance.AddCoins(coins);
    }

    public void SetGenerator(ResourceGeneratorSO resourceGenerator){
        resourceGeneratorSO = resourceGenerator;
        resourceGeneratorSO.isActive = false;
        timerMax = resourceGeneratorSO.generationTime;
    }
}
