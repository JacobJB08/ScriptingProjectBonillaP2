using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple5 : Fruit5
{
    public Apple5()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public Apple5(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
