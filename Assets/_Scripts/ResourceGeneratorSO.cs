using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ResourceGeneratorSO")]
public class ResourceGeneratorSO : ScriptableObject{
    
    public string generatorName;
    public float generationTime; //how much time to generate
    public int generatorCount; //how much generators player have
    public int generationAmount; //how much resources this generate
    public int price;
    public Sprite sprite;
    public bool isActive;
}
