# Simple Math - [IN DEVELOPMENT] 

## Table Of Contents 
 
<details>
<summary>Details</summary>

  - [Introduction](#introduction)
  - [Functions](#functions)
  - [Constants](#constants)
    
</details>

## Introduction

It includes a bunch of extra Math functions for Unity.

## Functions
 - [Clamp Vector](#clamp-vector)

## Clamp Vector
  - Sometimes, it might be frustrating to clamp vectors in Unity. The way SimpleMath clamping is both easier and readable. 

```csharp 
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        //Old way of clamping vectors
        transform.position = new Vector3(transform.position.x, 10f, transform.position.z);

        //The way of SimpleMath clamping vectors
        transform.position = SimpleMath.ClampVector(transform.position, VectorComponent.Y, 10f);
        
        //Note that, "VectorComponent" is an enum
    }
}
```

## Constants
 - [TAU](#tau)

## TAU
 - When it comes to deal with angular measurements, like radians, cos, sine functions, it is usefull to have access to TAU representing as a complete "one-turn".
 - Unfortunately, Unity does not include TAU in its Math library, But SimpleMath does

```csharp 
using UnityEngine;

public class TAUExample : MonoBehaviour
{
    public int dotCount = 0;

    private void OnDrawGizmos()
    {
        for (int i = 0; i < dotCount; i++)
        {
            // Get a portion of a full turn based on i value
            float t = i / (float)dotCount;
            
            //Measure the angle in radian using TAU
            float angRad = t * SimpleMath.TAU;
            
            // Get x coordinate based on angle in radian
            float x = Mathf.Cos(angRad);
            
            // Get y coordinate based on angle in radian
            float y = Mathf.Sin(angRad);
            
            // Set (x, y) coordinates 
            Vector2 coord = transform.TransformPoint(new Vector2(x, y));
            
            // Draw sphere based on coordinate specified above
            Gizmos.DrawSphere(coord, .1f);
            
            //Note that, "SimpleMath.TAU" is exactly (2 * Mathf.PI)
        }
    }
}
```

