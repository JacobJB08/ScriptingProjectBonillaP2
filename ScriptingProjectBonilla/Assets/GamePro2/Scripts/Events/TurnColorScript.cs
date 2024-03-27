using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }


    void TurnColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color col = new Color(Random.value, Random.value, Random.value);
        renderer.material.color = col;
    }
}
