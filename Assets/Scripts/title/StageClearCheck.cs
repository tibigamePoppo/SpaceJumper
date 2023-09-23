using System;
using UnityEngine;
namespace Title
{
    public class StageClearCheck : MonoBehaviour
    {
        void Awake()
        {
            Configs.Stage1Clear = PlayerPrefs.GetInt("Stage1Clear", 0) == 1;
            Configs.Stage2Clear = PlayerPrefs.GetInt("Stage2Clear", 0) == 1;
            Configs.Stage3Clear = PlayerPrefs.GetInt("Stage3Clear", 0) == 1;
            Configs.Stage4Clear = PlayerPrefs.GetInt("Stage4Clear", 0) == 1;
        }
    }
}
