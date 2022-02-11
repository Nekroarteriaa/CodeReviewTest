using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// spawns enemy prefabs at random intervals, and at random positions on the floor
/// </summary>
public class EnemySpawner : MonoBehaviour
{
    public float minSpawnTime = 0.2f;
    public float maxSpawnTime = 5f;
    public Transform floor;
    public GameObject prefab, prefab2;
    
    float t;

    float randomTime;

    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (t < randomTime){
            t += Time.deltaTime;
        }
        else
        {
            bool spawnPrefab2 = Random.value > 0.5f;
            GameObject enemy = null;
            
            if (spawnPrefab2)
            {
                 enemy = Instantiate(prefab, 
                    new Vector3(Random.Range(-floor.localScale.x * 5, floor.localScale.x * 5), 0.5f, Random.Range(-floor.localScale.z * 5, floor.localScale.z * 5)),
                    Quaternion.identity);
                 
                 
                 enemy.GetComponent<MeshRenderer>().material = new Material(Shader.Find("Standard"));
                 enemy.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0);
                 
                 
            }
            else
            {
                 enemy = Instantiate(prefab2, 
                    new Vector3(Random.Range(-floor.localScale.x * 5, floor.localScale.x * 5), 0.5f, Random.Range(-floor.localScale.z * 5, floor.localScale.z * 5)),
                    Quaternion.identity); 
                 enemy.GetComponent<MeshRenderer>().material = new Material(Shader.Find("Standard"));
                 enemy.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1, 0);
            }
            
            
            if (enemy != null)
            {
        
            }


            randomTime = Random.Range(minSpawnTime, maxSpawnTime);
            t = 0;
        }


    }
}
