using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceGeneratorSingleUI : MonoBehaviour{
    
    [Header("Components")]
    [SerializeField] private Image iconSprite;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI buyText;
    [SerializeField] private TextMeshProUGUI generatorCountText;
    [SerializeField] private ResourceGenerator resourceGenerator;

    private ResourceGeneratorSO resourceGeneratorSO;

    private void Start(){
        button.onClick.AddListener(OnBuyButtonClicked);
        SetResourceGeneratorSettings();
    }

    private void SetResourceGeneratorSettings(){
        iconSprite.sprite = resourceGeneratorSO.sprite;
        resourceGenerator.SetGenerator(resourceGeneratorSO);
        generatorCountText.SetText(resourceGeneratorSO.generatorCount.ToString());
        buyText.SetText("Buy 1 " + resourceGeneratorSO.name);
    }

    private void OnBuyButtonClicked(){
        ResourceGeneratorsManager.Instance.BuyResourceGenerator(resourceGeneratorSO);
        generatorCountText.SetText(resourceGeneratorSO.generatorCount.ToString());
    }

    public void SetResourceGeneratorSO(ResourceGeneratorSO resourceGenerator){
        resourceGeneratorSO = resourceGenerator;
    }
}
