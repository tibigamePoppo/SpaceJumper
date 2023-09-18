using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace System.Effect
{
    public class EffectManager : MonoBehaviour
    {
        public static EffectManager Instance { get; private set; }
        [SerializeField]
        private GameObject FadeIn;
        [SerializeField]
        private GameObject FadeOut;
        [SerializeField]
        private GameObject MeatGetEffect;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void InstanceEffect(EffectType type,Vector3 InstancePosition)
        {
            switch (type)
            {
                case EffectType.FadeIn:
                    Instantiate(FadeIn, transform);
                    break;
                case EffectType.FadeOut:
                    Instantiate(FadeOut, transform);
                    break;
                case EffectType.MeatGet:
                    var PieceSet = Instantiate(MeatGetEffect, InstancePosition,Quaternion.identity);
                    Destroy(PieceSet, 3f);
                    break;
                default:
                    break;
            }
        }
        //SeManager.Instance.ShotSe(SeType.MoveCard);Ç∆ì¸óÕÇ∑ÇÈÇ∆âπÇ™èoÇÈ?
    }
}
