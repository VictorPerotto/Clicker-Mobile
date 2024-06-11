using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceGeneratorSingleUI : MonoBehaviour{
    
    [Header("Components")]
    [SerializeField] private Image sprite;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private ResourceGenerator resourceGenerator;

    private ResourceGeneratorSO resourceGeneratorSO;

    private void Start(){
        button.onClick.AddListener(OnBuyButtonClicked);
        SetResourceGeneratorSettings();
    }

    private void SetResourceGeneratorSettings(){
        sprite.sprite = resourceGeneratorSO.sprite;
        resourceGenerator.SetGenerator(resourceGeneratorSO);
        text.SetText("Buy X " + resourceGeneratorSO.name);
    }

    private void OnBuyButtonClicked(){
        
    }

    public void SetResourceGeneratorSO(ResourceGeneratorSO resourceGenerator){
        resourceGeneratorSO = resourceGenerator;
    }
}
