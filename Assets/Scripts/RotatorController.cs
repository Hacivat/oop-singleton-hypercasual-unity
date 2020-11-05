using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using UnityEditorInternal;
using UnityEngine;

public class RotatorController : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float ballSpeed;
    [SerializeField] private BallController ball;

    private void Update()
    {
        if (GameManager.Instance.ROTATING())
            RotateAround();

        if (GameManager.Instance.PUSH_UP())
            ball.MoveForward(ballSpeed);
                    
        if (GameManager.Instance.PULL_BACK())
            ball.MoveBackward(ballSpeed);
    }

    private void RotateAround()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
    }
}
