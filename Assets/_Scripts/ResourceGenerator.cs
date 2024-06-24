using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour{
    
    [SerializeField] private ResourceGeneratorSO resourceGeneratorSO;
    private float timer;

    private void Start(){
        resourceGeneratorSO = gameObject.GetComponent<ResourceGeneratorSingleUI>().GetResourceGeneratorSO();
    }

    private void Update(){
        if(resourceGeneratorSO.generatorCount > 0){
            if(timer <= 0){
                timer = resourceGeneratorSO.generationTime;
                AddCoinsGenerator();
            }
            timer -= Time.deltaTime;
        }
    }

    private void AddCoinsGenerator(){
        double coins = GetAmountGeneration();
        CoinsManager.Instance.AddCoins(coins);
    }

    public double GetAmountGeneration(){
        return resourceGeneratorSO.generationAmount * resourceGeneratorSO.generatorCount;
    }

    public float GetTimerNormalized(){
        return timer/resourceGeneratorSO.generationTime;
    }
}
