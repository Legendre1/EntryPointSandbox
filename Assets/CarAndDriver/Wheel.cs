using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : CarParts
{
    private object[] rims;

    private object[] tread;
    
    public void Move()
    {
        Debug.Log(car.GetWheelCount() + " Wheels Activated");
        
    }
    public void WheelRotationRight(int Tire)
    {
       
        if(Tire == 0)
        {
            Debug.Log("Front Driver Tire Rotation -35 Degrees");
        }
        else if(Tire == 1)
        {
            Debug.Log("Front Passenger Tire Rotation -35 Degrees");
        }
        else if(Tire == 2)
        {
            Debug.Log("Rear Driver Tire Rotation 0 Degrees");
        }
        else if(Tire == 3)
        {
            Debug.Log("Rear Passenger Tire Rotation 0 Degrees");
        }
    }
    public void WheelRotationLeft(int Tire)
    {
        
        if(Tire == 0)
        {
            Debug.Log("Front Driver Tire Rotation 35 Degrees");
        }
        else if(Tire == 1)
        {
            Debug.Log("Front Passenger Tire Rotation 35 Degrees");
        }
        else if(Tire == 2)
        {
            Debug.Log("Rear Driver Tire Rotation 0 Degrees");
        }
        else if(Tire == 3)
        {
            Debug.Log("Rear Passenger Tire Rotation 0 Degrees");
        }
        
    }
} 
        
    

