using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour{

    public ResourceGeneratorListSO resourceGeneratorListSO;

    private void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            foreach(var resourceGenerator in resourceGeneratorListSO.list){
                resourceGenerator.generatorCount = 0;
            }
        }
    }
}
