using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public AudioSource GigaChadAudio;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // When Red Ball collides with any other ball and audio named "GigaChad" plays which is popular on soical media like tiktok
        GigaChadAudio.Play();
    }
}

