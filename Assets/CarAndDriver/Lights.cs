using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : CarParts
{
    public void FlipLights()
    {
        Debug.Log(car.GetHeadLightCount() + " Lights on for safety Michael");
    }
}
