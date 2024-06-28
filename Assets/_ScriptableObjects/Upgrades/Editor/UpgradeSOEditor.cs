using UnityEditor;
using UnityEngine;
using BreakInfinity;

[CustomEditor(typeof(UpgradeSO))]
public class UpgradeSOEditor : Editor{

    public override void OnInspectorGUI(){
        UpgradeSO upgradeSO = (UpgradeSO)target;
    
        upgradeSO.icon = (Sprite)EditorGUILayout.ObjectField("Icon", upgradeSO.icon, typeof(Sprite), false);
        upgradeSO.titleText = EditorGUILayout.TextField("Title text", upgradeSO.titleText);
        upgradeSO.descriptionText = EditorGUILayout.TextField("Description", upgradeSO.descriptionText);

        string unlockPriceString = upgradeSO.unlockPrice.ToString();
        string priceString = upgradeSO.price.ToString();
        unlockPriceString = EditorGUILayout.TextField("Unlock Price", unlockPriceString);
        priceString = EditorGUILayout.TextField("Price", priceString);
        
        BigDouble bigDoubleValue;
        if(TryParseBigDouble(priceString, out bigDoubleValue)){
            upgradeSO.price = bigDoubleValue;
        }
        

        if(TryParseBigDouble(unlockPriceString, out bigDoubleValue)){
            upgradeSO.unlockPrice = bigDoubleValue;
        }

        else{
            EditorGUILayout.HelpBox("Invalid BigDouble format", MessageType.Error);
        }

        upgradeSO.upgradeType = (UpgradeType)EditorGUILayout.EnumPopup("Upgrade type", upgradeSO.upgradeType);
        switch(upgradeSO.upgradeType){
            case UpgradeType.clickPower:
                upgradeSO.coinsPerClickMultiplier = EditorGUILayout.DoubleField("Click Multiplier", upgradeSO.coinsPerClickMultiplier);
            break;

            default:
                upgradeSO.resourceGeneratorSO = (ResourceGeneratorSO)EditorGUILayout.ObjectField(
                    "Resource Generator", upgradeSO.resourceGeneratorSO, typeof(ResourceGeneratorSO), true
                    );
            break;
        }

        if(GUI.changed){
            EditorUtility.SetDirty(upgradeSO);
            Debug.Log("Passou aqui");
        }
    }

    private bool TryParseBigDouble(string input, out BigDouble result){
        try{
            result = BigDouble.Parse(input);
            return true;
        }

        catch{
            result = BigDouble.Zero;
            return false;
        }
    }
}
/*[Header("Variables")]
    public ResourceGeneratorSO resourceGeneratorSO;

    public double coinsPerClickMultiplier;
    public UpgradeType upgradeType;
*/