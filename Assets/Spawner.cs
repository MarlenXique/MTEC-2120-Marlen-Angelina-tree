using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject wizard;

    void Start()
    {
        for (int i = 15; i < 10; i++)
        {

            Instantiate(wizard, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);

        }
    }


}


