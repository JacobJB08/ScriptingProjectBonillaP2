using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass4 : MonoBehaviour
{
    void Start()
    {
        SomeClass4 myClass = new SomeClass4();

        myClass.GenericMethod<int>(5);
    }
}
