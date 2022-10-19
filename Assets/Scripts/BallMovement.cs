using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D Puck;
    public float PushForce;
    public float X;
    public float Y;
    public Vector2 PushVector;

    void Start()
        {
            X = -6f;
            Y = Random.Range(-6f, 6f);
            PushVector = new Vector2(X, Y);
            Puck.AddForce(PushVector * PushForce);


        //
        }
    }
