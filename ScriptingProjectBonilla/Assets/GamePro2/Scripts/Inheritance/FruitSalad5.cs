using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad5 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit5 myFruit = new Fruit5();
        Debug.Log("Creating the apple");
        Apple5 myApple = new Apple5();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new Fruit5("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple5("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }
}
