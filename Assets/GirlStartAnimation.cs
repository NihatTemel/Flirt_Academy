using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GirlStartAnimation : MonoBehaviour
{
    [SerializeField] float duration=1;
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 0), duration);
        transform.DOMove(new Vector3(0, 0, 0), duration);

    }


}
