using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // When the green ball collides with another ball, the size of the green ball changes
        transform.localScale += new Vector3(3, 3, 3);    }
}