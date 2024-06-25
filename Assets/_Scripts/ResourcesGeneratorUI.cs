using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesGeneratorUI : HideableInterface
{
    [SerializeField] private ResourceGeneratorListSO resourceGeneratorListSO;
    [SerializeField] private List<ResourceGeneratorSingleUI> resourceGeneratorSingleUIList;
    [SerializeField] private GameObject generatorSingleUIPrefab;
    [SerializeField] private GameObject content;
    [SerializeField] private float timerMax;
    private float timer;
    
    void Start(){
        PopulateGenerators();
    }

    void Update(){
    if(timer <= 0){
            timer = timerMax;
            BigDouble currentCoins = CoinsManager.Instance.GetCurrentCoins();
            if(resourceGeneratorSingleUIList.Count > 0){
                for(int i =0; i < resourceGeneratorSingleUIList.Count; i ++){
                    if(currentCoins < resourceGeneratorSingleUIList[i].GetResourceGeneratorSO().unlockPrice){
                        resourceGeneratorSingleUIList[i].gameObject.SetActive(false);
                    }
                    else{
                        resourceGeneratorSingleUIList[i].gameObject.SetActive(true);
                        resourceGeneratorSingleUIList.Remove(resourceGeneratorSingleUIList[i]);
                    }
                }        
            }
        }

        timer -= Time.deltaTime;
    }

    private void PopulateGenerators(){
        foreach(var resourceGenerator in resourceGeneratorListSO.list){
            var newResourceGenerator = Instantiate(generatorSingleUIPrefab, content.transform).GetComponent<ResourceGeneratorSingleUI>();
            newResourceGenerator.SetResourceGeneratorSO(resourceGenerator);
            resourceGeneratorSingleUIList.Add(newResourceGenerator);
        }
    }
}
