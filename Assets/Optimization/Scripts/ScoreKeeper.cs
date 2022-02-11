using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///  checks how long the player has stayed alive and displays the score via UI Text
/// </summary>
public class ScoreKeeper : MonoBehaviour
{
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        GetComponent<Text>().text = "Score: " + Mathf.RoundToInt(timer);
    }
}
