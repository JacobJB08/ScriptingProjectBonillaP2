using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass4<int> myClass = new GenericClass4<int>();

        myClass.UpdateItem(5);
    }
}
