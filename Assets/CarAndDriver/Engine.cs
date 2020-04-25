using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine 
{
    private object[] radiator;
    private object[] OilPan;
    private object[] SerpentineBelt;
    private object[] DriveTrain;

    public void Ignition()
    {
        Debug.Log("Engine Engaged");
    }
    public void RevUp()
    {
        Debug.Log("Vrooom!");
    }
}
