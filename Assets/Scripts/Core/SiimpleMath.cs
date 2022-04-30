using UnityEngine;

public static class SimpleMath
{
    public const float TAU = 6.28f;

    public static Vector3 ClampVectorX(Vector3 vector3)
    {
        //TODO: Implement
        return Vector3.zero;
    }

    public static Vector3 ClampVectorY(Vector3 vector3)
    {
        //TODO: Implement
        return Vector3.zero;
    }

    public static Vector3 ClampVectorZ(Vector3 vector3)
    {
        //TODO: Implement
        return Vector3.zero;
    }

    public static float Lerp(float a, float b, float t)
    {
        return (1.0f - t) * a + b * t;
    }

    public static float InvLerp(float a, float b, float v)
    {
        return (v - a) / (b - a);
    }

    public static float Remap(float iMin, float iMax, float oMin, float oMax, float v)
    {
        float t = InvLerp(iMin, iMax, v);
        return Lerp(oMin, oMax, t);
    }
}