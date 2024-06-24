using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResourceGeneratorSingleUI : MonoBehaviour{
    
    [Header("Components")]
    [SerializeField] private ResourceGeneratorBar resourceGeneratorBar;
    [SerializeField] private TextMeshProUGUI generatorCountText;
    [SerializeField] private ResourceGeneratorLockedUI lockedUI;
    [SerializeField] private TextMeshProUGUI buyText;
    [SerializeField] private Image iconSprite;
    [SerializeField] private Button button;

    [Header("DebugOnly")]
    [SerializeField] ResourceGeneratorSO resourceGeneratorSO;
    [SerializeField] ResourceGenerator resourceGenerator;

    private void Start(){
        UpdateGeneratorUI();
        button.onClick.AddListener(OnBuyButtonClicked);
        lockedUI.SetResourceGeneratorSO(resourceGeneratorSO);
        resourceGeneratorBar.SetBarResourceGenerator(resourceGenerator);
    }

    private void UpdateGeneratorUI(){
        iconSprite.sprite = resourceGeneratorSO.sprite;
        generatorCountText.SetText(resourceGeneratorSO.generatorCount.ToString());
        buyText.SetText(resourceGeneratorSO.price.ToString() + " <sprite index=0>");        
    }

    private void OnBuyButtonClicked(){
        ResourceGeneratorsManager.Instance.BuyResourceGenerator(resourceGeneratorSO);
        UpdateGeneratorUI();
    }

    public void SetResourceGeneratorSO(ResourceGeneratorSO resourceGeneratorSO){
        this.resourceGeneratorSO = resourceGeneratorSO;
    }

    public ResourceGeneratorSO GetResourceGeneratorSO(){
        return resourceGeneratorSO;
    }

    public ResourceGenerator GetResourceGenerator(){
        return resourceGenerator;
    }
}
