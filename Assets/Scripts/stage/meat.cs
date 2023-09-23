using DG.Tweening;
using UnityEngine;
using Audio;
using System.Effect;

public class meat : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveY(0.2f,1).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutSine).SetRelative();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"Enter{col}");
        if(col.CompareTag("Player"))
        {
            Debug.Log("�C�m�V�V�����Q�b�g");
            EffectManager.Instance.InstanceEffect(EffectType.MeatGet,transform.position);
            SeManager.Instance.ShotSe(SeType.FakeMeatGet);

            FindObjectOfType<GameStateManager>().GetMeat.Invoke();
        }
    }
}
