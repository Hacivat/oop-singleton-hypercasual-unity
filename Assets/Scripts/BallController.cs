using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : MonoBehaviour
{
    public void MoveForward(float ballSpeed)
    {
        transform.position += transform.forward * ballSpeed;
    }

    public void MoveBackward(float ballSpeed)
    {
        transform.position += transform.forward * -ballSpeed;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.GetType().IsSubclassOf(typeof(Collectable)))
        {
            Collectable collectable = collider.GetComponent<Collectable>();
            collectable.Collect();
            GameManager.Instance.SetPullBack();
        }

        if (collider.transform.CompareTag("stick"))
        {
            GameManager.Instance.SetRotating();
        }
    }
}
