using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    // rotation Z
    public float Min_Z = -55f, Max_Z = 55f;
    public float Rotate_Speed = 5f;
    public float Move_Speed = 3f;
    public float Min_Y = -2.5f;

    private float Rotate_Angle;
    private bool Rotate_Right;
    private bool canRotate;
    private float initial_Move_Speed;
    private float initial_Y;
    private bool moveDown;


    // FOR LINE RENDER
    //private RopeRenderer ropeRenderer;

    // Start is called before the first frame update
    void Start()
    {
        initial_Y = transform.position.y;
        initial_Move_Speed = Move_Speed;

        canRotate = true;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        
    }

    private void Rotate()
    {
        if (!canRotate)
            return;

        if (Rotate_Right) Rotate_Angle += Rotate_Speed * Time.deltaTime;
        else Rotate_Angle -= Rotate_Speed * Time.deltaTime;

        transform.rotation = Quaternion.AngleAxis(Rotate_Angle, Vector3.forward);


        if (Rotate_Angle >= Max_Z) Rotate_Right = false;
        else if (Rotate_Angle <= Min_Z) Rotate_Right = true;
    }
}
