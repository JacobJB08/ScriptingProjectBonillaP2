using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass4<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
