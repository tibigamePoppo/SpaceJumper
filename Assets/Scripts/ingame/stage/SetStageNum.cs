using System;
using UnityEngine;
namespace Ingame.Stage
{
    public class SetStageNum : MonoBehaviour
    {
        public void OnClick(int StageNum)
        {
            Configs.StageNum = StageNum;
        }
    }
}