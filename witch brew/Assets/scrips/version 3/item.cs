using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "new item")]
public class item : ScriptableObject
{
    [SerializeField] string itemName;
    [SerializeField] GameObject prefab;
}
