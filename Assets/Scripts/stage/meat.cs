using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class meat : MonoBehaviour
{

    void Start()
    {
        transform.DOMoveY(0.2f,1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine).SetRelative();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"Enter{col}");
        if(col.CompareTag("Player"))
        {
            Debug.Log("イノシシ肉をゲット");
        }
    }
}
