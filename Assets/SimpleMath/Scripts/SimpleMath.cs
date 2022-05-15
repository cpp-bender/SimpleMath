using System.Collections.Generic;
using UnityEngine;

public static class SimpleMath
{
    /// <summary>
    /// The representation of one-turn in radians (Read-Only).
    /// </summary>
    public const float TAU = 2 * Mathf.PI;

    /// <summary>
    /// Clamps one of the components of the given vector.
    /// </summary>
    /// <param name="vector3">Vector3 to clamp</param>
    /// <param name="vectorComponent">The Vector component to clamp</param>
    /// <param name="value">New value</param>
    /// <returns></returns>
    public static Vector3 ClampVector(Vector3 vector3, VectorComponent vectorComponent, float value)
    {
        var dict = new Dictionary<VectorComponent, float>
        {
            {VectorComponent.X, vector3.x },
            {VectorComponent.Y, vector3.y },
            {VectorComponent.Z, vector3.z},
        };

        dict[vectorComponent] = value;

        return new Vector3(dict[VectorComponent.X], dict[VectorComponent.Y], dict[VectorComponent.Z]);
    }

    /// <summary>
    /// Clamps multiple components of the given vector.
    /// </summary>
    /// <param name="vector3">Vector3 to clamp</param>
    /// <param name="components">The Vector components to clamp</param>
    /// <param name="values">New values</param>
    /// <returns></returns>
    public static Vector3 ClampVector(Vector3 vector3, VectorComponent[] components, float[] values)
    {
        var dict = new Dictionary<VectorComponent, float>
        {
            {VectorComponent.X, vector3.x },
            {VectorComponent.Y, vector3.y },
            {VectorComponent.Z, vector3.z},
        };

        for (int i = 0; i < dict.Count; i++)
        {
            dict[components[i]] = values[i];
        }

        return new Vector3(dict[VectorComponent.X], dict[VectorComponent.Y], dict[VectorComponent.Z]);
    }

    /// <summary>
    /// Converts any angle to direction.
    /// </summary>
    /// <param name="angle">The Angle to convert in radians</param>
    /// <returns></returns>
    public static Vector3 AngToDir(float angle)
    {
        float x = Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = Mathf.Sin(angle * Mathf.Deg2Rad);
        return new Vector3(x, y);
    }

    /// <summary>
    /// Converts any direction to angle.
    /// </summary>
    /// <param name="dir">The direction to convert</param>
    /// <returns></returns>
    public static float DirToAngle(Vector2 dir)
    {
        return Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }

    /// <summary>
    /// Will explain soon.
    /// </summary>
    /// <param name="iMin"></param>
    /// <param name="iMax"></param>
    /// <param name="oMin"></param>
    /// <param name="oMax"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static float Remap(float iMin, float iMax, float oMin, float oMax, float v)
    {
        float t = InvLerp(iMin, iMax, v);
        return Lerp(oMin, oMax, t);
    }

    /// <summary>
    /// Linearly interpolates between two values.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static float Lerp(float a, float b, float t)
    {
        return (1.0f - t) * a + b * t;
    }

    /// <summary>
    /// Determines where value is between a and b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static float InvLerp(float a, float b, float v)
    {
        return (v - a) / (b - a);
    }
}