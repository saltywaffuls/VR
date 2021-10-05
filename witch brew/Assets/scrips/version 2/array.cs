using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    int cube = 1;
    int sphere = 2;
    int capsule = 3;

    private void OnTriggerEnter(Collider other)
    {
        if(prefabs[cube])
        {
            Instantiate(prefabs[cube], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (prefabs[sphere])
        {
            Instantiate(prefabs[sphere], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(prefabs[cube] || prefabs[cube])
        {
            Instantiate(prefabs[capsule], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
