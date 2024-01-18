using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    /*
     * Notes can be very useful
     * just use a / and * to start
     * and a * plus / to end
     */
    void Start()
    {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("Look at me roll");
        }
    }

    
    void Update()
    {
        
    }
}
