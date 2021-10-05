using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lestTryThisAgain : MonoBehaviour
{
    [SerializeField] item[] items;
    int Cube = 1;
    int Sphere = 2;
    int Capsule = 3;

    void GetCube(item cube)
    {
        cube = items[Cube];

        Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void GetSphere(item sphere)
    {
        sphere = items[Sphere];

        Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void GetCapsule(item capsule)
    {
        capsule = items[Capsule];

        Instantiate(capsule, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (items[Cube])
        {
            GetCube(items[Cube]);
        }
        else if (items[Sphere])
        {
            GetSphere(items[Sphere]);
        }
        else if (items[Capsule])
        {
            GetCapsule(items[Sphere]);
        }
    }
}
