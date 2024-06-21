using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{   
    public static CoinsManager Instance;
    public event EventHandler<OnCurrentCoinsChangedArgs> OnCurrentCoinsChanged;

    public class OnCurrentCoinsChangedArgs : EventArgs{
        public double currentCoins;
    }

    [SerializeField] private double currentCoins;
    
    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void AddCoins(double amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins += amount;
    }

    public void SubtractCoins(double amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins -= amount;
    }

    public double GetCurrentCoins(){
        return currentCoins;
    }
}
