using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ResourceGeneratorSO")]
public class ResourceGeneratorSO : ScriptableObject{
    
    public string generatorName;
    public float generationTime; //how much time to generate
    public double generationAmount; //how much resources this generate
    public int generatorCount; //how much generators player have
    public double showPrice; //how much money players need to this appears on UI
    public double unlockPrice;
    public double price;
    public Sprite sprite;
}
