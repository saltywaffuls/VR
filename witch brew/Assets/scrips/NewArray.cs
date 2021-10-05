using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArray : MonoBehaviour
{
    /* 
     code ref link 
     https://sharpcoderblog.com/blog/unity-3d-inventory-and-item-crafting-system 
    */

    [SerializeField] Items[] items;
    //[SerializeField] GameObject Prefabs;

    [System.Serializable]
    public class SlotContainer
    {
        public GameObject Prefabs;
    }

    [System.Serializable]
    public class Items
    {
        public GameObject Prefabs;
        public string craftRecipe;
    }

    //Find Item from the items list using sprite as reference
    public Items FindItems(GameObject prefabs)
    {
        if (!prefabs)
            return null;

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].Prefabs == prefabs)
            {
                return items[i];
            }
        }
        return null;
    }

    //Find Item from the items list using recipe as reference
    public Items FindItems(string recipe)
    {
        if (recipe == "")
            return null;

        for(int i = 0; i < items.Length; i++)
        {
            if(items[i].craftRecipe == recipe)
            {
                return items[i];
            }
        }
        return null;
    }

    public void PreformCrafting()
    {
        //Prefa

       // item craftedItem = FindItems(Prefabs);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
