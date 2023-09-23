using System;
using UnityEngine;
using UnityEngine.UI;

namespace Title
{
    public class ClearMeatCheck : MonoBehaviour
    {
        [SerializeField]
        private int StageNum;
        [SerializeField]
        private Sprite ClearMeat;
        void Start()
        {
            Image MeatImage = GetComponent<Image>();
            switch (StageNum)
            {
                case 1:
                    if (Configs.Stage1Clear) MeatImage.sprite = ClearMeat;
                    break;
                case 2:
                    if (Configs.Stage2Clear) MeatImage.sprite = ClearMeat;
                    break;
                case 3:
                    if (Configs.Stage3Clear) MeatImage.sprite = ClearMeat;
                    break;
                case 4:
                    if (Configs.Stage4Clear) MeatImage.sprite = ClearMeat;
                    break;
                default:
                    break;
            }
        }
    }
}