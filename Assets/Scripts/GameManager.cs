using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public enum State { ROTATING, PUSH_UP, PULL_BACK };
    public State state;
    private void Awake()
    {
        Instance = this;
        state = State.ROTATING;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SetPushUp();
        }
    }

    public void SetRotating()
    {
        state = State.ROTATING;
    }
    public void SetPushUp()
    {
        state = State.PUSH_UP;
    }
    public void SetPullBack()
    {
        state = State.PULL_BACK;
    }

    public bool ROTATING()
    {
        return state == State.ROTATING ? true : false;
    }
    public bool PUSH_UP()
    {
        return state == State.PUSH_UP ? true : false;
    }
    public bool PULL_BACK()
    {
        return state == State.PULL_BACK ? true : false;
    }

}
