using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : CarParts
{
    public void FlipLights()
    {
        Debug.Log(Car.GetHeadLightCount() + " Lights on for safety Michael");
    }
}
