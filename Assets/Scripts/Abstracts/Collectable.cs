using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Collectable : MonoBehaviour, IVisible, ICollect
{
    [SerializeField] private float rotationSpeed;
    private void Update()
    {
        RotateAroundItselfRandomly();
    }
    public void Collect()
    {
        ScoreController.Instance.SetScore(1);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show(Vector3 position)
    {
        transform.position = position;
        gameObject.SetActive(false);
    }

    public void RotateAroundItselfRandomly()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
    }
}
