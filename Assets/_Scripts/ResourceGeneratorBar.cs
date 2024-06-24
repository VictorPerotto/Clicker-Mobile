using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceGeneratorBar : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private TextMeshProUGUI generationAmountText;
    [SerializeField] private Image fillSprite;

    [Header("InspectorOnly")]
    [SerializeField]private ResourceGenerator resourceGenerator;

    private void Update(){
        fillSprite.fillAmount = 1 - resourceGenerator.GetTimerNormalized();
        generationAmountText.SetText(resourceGenerator.GetAmountGeneration().ToString() + "/S");
    }

    public void SetBarResourceGenerator(ResourceGenerator resourceGenerator){
        this.resourceGenerator = resourceGenerator;
    }
}
