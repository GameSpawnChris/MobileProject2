﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitySpawner : MonoBehaviour
{
    public GameObject CityBlockPrefab1;
    public GameObject CityBlockPrefab2;
    public GameObject CityBlockPrefab3;
    public bool CarScene;
    public int startPointY;
    public float blockDelay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCityBlock()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCityBlock()
    {
        int cityBlockType;

        while (CarScene == true)
        {
            while (true)
            {
                cityBlockType = Random.Range(1, 4);
                Debug.Log(cityBlockType);

                if (cityBlockType == 1)
                {
                    Vector3 spawnPos = new Vector3(-30, 0f, startPointY);
                    Instantiate(CityBlockPrefab1, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
                if (cityBlockType == 2)
                {
                    Vector3 spawnPos = new Vector3(-30, 0f, startPointY);
                    Instantiate(CityBlockPrefab2, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
                if (cityBlockType == 3)
                {
                    Vector3 spawnPos = new Vector3(-30, 0f, startPointY);
                    Instantiate(CityBlockPrefab3, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
            }
        }
    }
}
