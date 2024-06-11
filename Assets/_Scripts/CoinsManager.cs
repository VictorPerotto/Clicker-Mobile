using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{   
    public static CoinsManager Instance;
    public event EventHandler<OnCurrentCoinsChangedArgs> OnCurrentCoinsChanged;

    public class OnCurrentCoinsChangedArgs : EventArgs{
        public int currentCoins;
    }

    [SerializeField] private int currentCoins;
    
    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public void AddCoins(int amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins += amount;
    }

    public void SubtractCoins(int amount){
        OnCurrentCoinsChanged?.Invoke(this, new OnCurrentCoinsChangedArgs{currentCoins = currentCoins});
        currentCoins -= amount;
    }

    public int GetCurrentCoins(){
        return currentCoins;
    }
}
