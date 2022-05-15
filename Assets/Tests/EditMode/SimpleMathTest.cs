using NUnit.Framework;
using UnityEngine;

public class SimpleMathTest
{
    [Test]
    public void Tau()
    {
        Assert.AreEqual(SimpleMath.TAU, 2 * Mathf.PI);
    }

    [Test]
    public void ClampVector3()
    {
        Assert.AreEqual(SimpleMath.ClampVector(Vector3.one, VectorComponent.X, 5f), new Vector3(5f, 1f, 1f));
    }

    [Test]
    public void Lerp()
    {
        Assert.AreEqual(SimpleMath.Lerp(0, 1, .5f), .1f);
    }

    [Test]
    public void InverseLerp()
    {
        Assert.AreEqual(SimpleMath.InvLerp(0, 1, 5), 3);
    }

    [Test]
    public void AngToDir()
    {
        Assert.AreEqual(SimpleMath.AngToDir(30), new Vector3(Mathf.Cos(30f * Mathf.Deg2Rad), Mathf.Sin(30f * Mathf.Deg2Rad), 0f));
    }

    [Test]
    public void DirToAngle()
    {
        Assert.AreEqual(SimpleMath.DirToAngle(Vector2.right), Mathf.Atan2(Vector2.right.y, Vector2.right.x) * Mathf.Rad2Deg);
    }
}
