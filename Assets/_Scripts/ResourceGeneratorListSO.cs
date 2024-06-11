using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ResourceGeneratorListSO")]
public class ResourceGeneratorListSO : ScriptableObject{
    public List<ResourceGeneratorSO> list;
}
