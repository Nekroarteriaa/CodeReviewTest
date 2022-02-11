using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// casts a Physics Raycast from the users mouse input to check if it hits the floor
/// </summary>
public class Raycaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)){
            
                if (hit.transform.gameObject.name.Contains("Floor"))
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        FindObjectOfType<PlayerController>().SetPlayerPosition(hit.point);
                    
                    }


            }

            }
    }
}
