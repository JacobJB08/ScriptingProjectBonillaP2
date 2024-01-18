using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hpt.");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffe is too cold.");
        }
        else
        {
            print("Coffe is just right.");
        }
    }
}
