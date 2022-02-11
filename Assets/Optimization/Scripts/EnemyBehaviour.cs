using System.Collections;    
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// initializes the enemy with a random lifetime and has the behaviour for the enemy to move towards the player 
/// </summary>
public class EnemyBehaviour : MonoBehaviour
{
    public float enemySpeed = 5f;

    public float lifeTimeMin = 2f;
    public float lifeTimeMax = 20f;

    float timer;
    float randomLifetime;

    // Start is called before the first frame update
    void Start()
    {
        randomLifetime = Random.Range(lifeTimeMin, lifeTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPositon = Vector3.Lerp(transform.position, FindObjectOfType<PlayerController>().transform.position, Time.deltaTime * enemySpeed);

        GetComponent<NavMeshAgent>().SetDestination(newPositon);

        timer += Time.deltaTime;

        if (timer > randomLifetime)
        {
            Debug.Log(gameObject.name + "'s lifetime expired, destroying.");
            Destroy(gameObject);
        }
        
    }
}
