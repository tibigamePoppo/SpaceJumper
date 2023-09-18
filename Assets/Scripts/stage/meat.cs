using DG.Tweening;
using UnityEngine;
using Audio;
using System.Effect;

public class meat : MonoBehaviour
{
    [SerializeField]
    private bool meatFake = true;
    void Start()
    {
        transform.DOMoveY(0.2f,1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine).SetRelative();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"Enter{col}");
        if(col.CompareTag("Player"))
        {
            Debug.Log("イノシシ肉をゲット");
            EffectManager.Instance.InstanceEffect(EffectType.MeatGet,transform.position);
            if (meatFake) SeManager.Instance.ShotSe(SeType.FakeMeatGet);
            else SeManager.Instance.ShotSe(SeType.GenuineMeatGet);
        }
    }
}
