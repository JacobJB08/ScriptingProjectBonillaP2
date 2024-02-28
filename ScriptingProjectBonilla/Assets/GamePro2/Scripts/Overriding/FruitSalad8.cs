using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple8 myApple = new Apple8();

        myApple.SayHello();
        myApple.Chop();

        Fruit8 myFruit = new Apple8();
        myFruit.SayHello();
        myFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
