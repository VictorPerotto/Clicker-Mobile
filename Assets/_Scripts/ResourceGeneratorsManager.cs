using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneratorsManager : MonoBehaviour{
    
    public static ResourceGeneratorsManager Instance;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
