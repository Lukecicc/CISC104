using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GenCodeTest
{
    // Test that default constructor 
    [Test]
    public void GenCodeConstructorTest()
    {
        GenCode testGenCode = new GenCode();

        // Assert
        Assert.AreEqual(0, testGenCode.number);
        Assert.AreEqual(0, testGenCode.clicks);


    }

    [Test]
    public void OneClickTest()
    {
    //Setup 
    GenCode testGenCode = new GenCode();

        //Act
        testGenCode.Clicked();

        //Assert
        Assert.AreEqual(1, testGenCode.clicks);

    }
    
    [Test]
    public void ResetTest()
    {
        //Setup
        GenCode testGenCode = new GenCode();

        //Act
        testGenCode.clicks = 23;
        testGenCode.number = 46;
        testGenCode.Reset();

        //Assert
        Assert.AreEqual(0, testGenCode.number);
        Assert.AreEqual(0, testGenCode.clicks);

    }
}
