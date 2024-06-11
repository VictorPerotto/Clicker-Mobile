using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour{
    
    [SerializeField] private ResourceGeneratorSO resourceGeneratorSO;
    [SerializeField] private bool isActive;
    private float timerMax;
    private float timer;

    private void Start(){
        isActive = false;
    }

    private void Update(){
        if(isActive){
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
    }
}
