using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour{
    
    [SerializeField] private ResourceGeneratorSO resourceGeneratorSO;
    [SerializeField] private ResourceGeneratorBar resourceGeneratorBar;
    private float timerMax;
    private float timer;

    private void Update(){
        if(resourceGeneratorSO.isActive){
            if(timer <= 0){
                timer = timerMax;
                AddCoinsGenerator();
            }
            timer -= Time.deltaTime;
        }
    }

    public void SetGenerator(ResourceGeneratorSO resourceGenerator){
        resourceGeneratorSO = resourceGenerator;
        resourceGeneratorSO.isActive = false;
        timerMax = resourceGeneratorSO.generationTime;
    }

    //calculate the amount of coins to add
    private void AddCoinsGenerator(){
        double coins = GetAmountGeneration();
        CoinsManager.Instance.AddCoins(coins);
    }

    public double GetAmountGeneration(){
        return resourceGeneratorSO.generationAmount * resourceGeneratorSO.generatorCount;
    }

    public float GetTimerNormalized(){
        return timer/timerMax;
    }
}
