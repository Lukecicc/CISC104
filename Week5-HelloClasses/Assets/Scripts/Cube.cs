using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube 
{
    private float height;
    private float width;
    private float length;

    public Cube()
    {
        height = 0f;
        width = 0f;
        length = 0f;
    }
    public Cube (float newHeight, float newWidth, float newLength)
    {
        height = newHeight;
        width = newWidth;
        length = newLength;
    }

    public float GetSideLength()
    {
        return (4 * height) + (4 * width) + (4 * length);
    }

    public float GetVolume()
    {
        return height * width * length;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }

    public float GetLength()
    {
        return length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;
    }
}
