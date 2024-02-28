using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand6 : MonoBehaviour
{
    void Start()
    {
        Humanoid6 human = new Humanoid6();
        Humanoid6 enemy = new Enemy6();
        Humanoid6 orc = new Orc6();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
