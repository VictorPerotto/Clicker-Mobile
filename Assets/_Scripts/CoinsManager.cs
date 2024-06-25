using System;
using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{   
    public static CoinsManager Instance;
    public event EventHandler<OnCurrentCoinsChangedArgs> OnCurrentCoinsChanged;

    public class OnCurrentCoinsChangedArgs : EventArgs{
        public BigDouble currentCoins;
    }

    [SerializeField] private BigDouble currentCoins;
    
    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void AddCoins(BigDouble amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins += amount;
    }

    public void SubtractCoins(BigDouble amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins -= amount;
    }

    public BigDouble GetCurrentCoins(){
        return currentCoins;
    }
}
