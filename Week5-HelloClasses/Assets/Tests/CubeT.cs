using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeT
{
    // This test is for contruction for default cube
    [Test]
    public void CubeConstructorTest()
    {
        //Setup/Act
        Cube defaultCube = new Cube();

        //Assert
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetVolume());
        Assert.AreEqual(0, defaultCube.GetSideLength());
    }
    //Tests for the SetLength function
    [Test]
    public void CubeSetLengthTest()
    {
        //Setup
        Cube newCube = new Cube(6, 4, 1);

        //Act
        newCube.SetLength(5);

        //Assert
        Assert.AreEqual(5, newCube.GetLength());
        Assert.AreEqual(6, newCube.GetHeight());
        Assert.AreEqual(120, newCube.GetVolume());

    }
    //Tests for the SetWidth function
    [Test]
    public void CubeSetWidthTest()
    {
        // Setup
        Cube newCube = new Cube(6, 4, 1);

        //Act
        newCube.SetWidth(5);

        //Assert
        Assert.AreEqual(5, newCube.GetWidth());
        Assert.AreEqual(6, newCube.GetHeight());
        Assert.AreEqual(30, newCube.GetVolume());

    }
}
