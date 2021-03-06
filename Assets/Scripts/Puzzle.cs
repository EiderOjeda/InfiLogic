﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour

{
    [HideInInspector]
    public bool Clicked = false;

    [HideInInspector]
    public bool go_left;
    [HideInInspector]
    public bool go_right;
    [HideInInspector]
    public bool go_up;
    [HideInInspector]
    public bool go_down;
    [HideInInspector]
    public Vector2 move_amount; //cuanto se mueve
    [HideInInspector]
    public bool moved = false;

    [HideInInspector]
    public Vector3 winPosition;

    // Start is called before the first frame update
    void Start()
    {
        winPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovePuzzle();
    }

    private void OnMouseDown()
    {
        Clicked = true;
    }
    private void OnMouseUp()
    {
        Clicked = false;
        moved = false;
    }

    void MovePuzzle()
    {
        if (go_left)
        {
            transform.position = new Vector3(transform.position.x - move_amount.x, transform.position.y, transform.position.z);
            go_left = false;
            moved = true;
        }
        if (go_right)
        {
            transform.position = new Vector3(transform.position.x + move_amount.x, transform.position.y, transform.position.z);
            go_right = false;
            moved = true;
        }
        if (go_up)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + move_amount.y, transform.position.z);
            go_up = false;
            moved = true;
        }
        if (go_down)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - move_amount.y, transform.position.z);
            go_down = false;
            moved = true;
        }

    }
}
