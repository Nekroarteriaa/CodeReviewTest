using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// allows user input to set position for the player and checks for Game Over through collision with an enemy
/// </summary>
public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("YOU ARE DEAD!");
        Time.timeScale = 0;
    }

    public void SetPlayerPosition(Vector3 pos)
    {
        GetComponent<NavMeshAgent>().SetDestination(pos);
    }
}
