﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


public int RandomNumber;
public string Rarelity;
public bool Flag;

private void Onvalidate()
{
    var random = new System.Random();
    RandomNumber = random.Next(0, 100);

    if (RandomNumber <= 3)
        Rarelity = "SSR!!!";
    else
        if (RandomNumber <= 10)
        Rarelity = "SR!!";
    else
            if (RandomNumber <= 40)
        Rarelity = "Rare!";
    else
        Rarelity = "Normal";
}
}