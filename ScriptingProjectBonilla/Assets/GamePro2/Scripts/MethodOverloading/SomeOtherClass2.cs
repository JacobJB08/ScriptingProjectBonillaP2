using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass2 : MonoBehaviour
{
    void Start()
    {
        SomeClass2 myClass = new SomeClass2();

        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}
