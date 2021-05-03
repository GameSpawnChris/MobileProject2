using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideSpawner : MonoBehaviour
{
    public GameObject CityBlockPrefab1;
    public GameObject CityBlockPrefab2;
    public GameObject CityBlockPrefab3;
    public bool CarScene;
    public int startPointX;
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
        int cityBlockType2;

        while (CarScene == true)
        {
            while (true)
            {
                cityBlockType2 = Random.Range(1, 4);
                Debug.Log(cityBlockType2);

                if (cityBlockType2 == 1)
                {
                    Vector3 spawnPos = new Vector3(startPointX, 0f, 15f);
                    Instantiate(CityBlockPrefab1, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
                if (cityBlockType2 == 2)
                {
                    Vector3 spawnPos = new Vector3(startPointX, 0f, 15f);
                    Instantiate(CityBlockPrefab2, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
                if (cityBlockType2 == 3)
                {
                    Vector3 spawnPos = new Vector3(startPointX, 0f, 15f);
                    Instantiate(CityBlockPrefab3, spawnPos, Quaternion.identity);
                    yield return new WaitForSeconds(blockDelay);
                }
            }
        }
    }
}
