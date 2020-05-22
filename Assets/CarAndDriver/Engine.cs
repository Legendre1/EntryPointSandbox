using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : CarParts
{
    private object[] radiator;
    private object[] OilPan;
    private object[] SerpentinteeBelt;
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
