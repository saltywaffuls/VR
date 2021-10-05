using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;
    

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("cube"))
        {
            Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);

        }
        else if(other.CompareTag("sphere"))
        {
            Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if(other.CompareTag("capsule"))
        {
            Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
