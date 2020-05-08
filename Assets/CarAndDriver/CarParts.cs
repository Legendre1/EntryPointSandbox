using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarParts 
{
    private static int numberOfWheels = 4;
    private static int numberOfHeadLights = 2;

   
    public static int GetWheelCount()
    {
        return numberOfWheels;
    }
    public static int GetHeadLightCount()
    {
        return numberOfHeadLights;
    }
}
