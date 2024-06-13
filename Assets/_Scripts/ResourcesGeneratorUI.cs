using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesGeneratorUI : HideableInterface
{
    [SerializeField] private ResourceGeneratorListSO resourceGeneratorListSO;
    [SerializeField] private GameObject generatorSingleUIPrefab;
    [SerializeField] private GameObject content;
    
    void Start(){
        PopulateGenerators();
    }

    void Update(){
        
    }

    private void PopulateGenerators(){
        foreach(var resourceGenerator in resourceGeneratorListSO.list){
            var newResourceGenerator = Instantiate(generatorSingleUIPrefab, content.transform).GetComponent<ResourceGeneratorSingleUI>();
            newResourceGenerator.SetResourceGeneratorSO(resourceGenerator);
        }
    }
}