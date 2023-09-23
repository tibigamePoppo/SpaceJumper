using System;
using System.Collections.Generic;
using UnityEngine;
using Ingame.Stage.TimeAttack;
using System.Collections;

namespace Ingame
{
    public class GameStateManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject PlayerArrow;
        [SerializeField]
        private GameObject TimeAttackText;
        public gameState currentState { private set; get; }
        public enum gameState
        {
            ingame,
            result,
        }

        public Action GetMeat;

        public void ChangeState(gameState state)
        {
            currentState = state;
            switch (state)
            {
                case gameState.ingame:
                    PlayerArrow.SetActive(true);
                    break;
                case gameState.result:
                    PlayerArrow.SetActive(false);
                    break;
                default:
                    break;
            }
        }
        void Awake()
        {
            ChangeState(gameState.ingame);
            GetMeat = CompleteStage;
            if (Configs.StageNum == 4) TimeAttackText.SetActive(true);
        }

        private void CompleteStage()
        {
            Debug.Log("CompleteStage");
            switch (Configs.StageNum)
            {
                case 0:
                    PlayerPrefs.SetInt("Stage1Clear", 1);
                    ChangeState(gameState.result);
                    break;
                case 1:
                    PlayerPrefs.SetInt("Stage2Clear", 1);
                    ChangeState(gameState.result);
                    break;
                case 2:
                    PlayerPrefs.SetInt("Stage3Clear", 1);
                    ChangeState(gameState.result);
                    break;
                case 3:
                    PlayerPrefs.SetInt("Stage4Clear", 1);
                    ChangeState(gameState.result);
                    break;
                case 4:
                    FindObjectOfType<TimeAttackStageController>().NextStage();
                    break;
                default:
                    break;
            }
        }

        public void reStartStage()
        {
            ChangeState(gameState.ingame);
        }

        IEnumerator BackScene()
        {
            yield return new WaitForSeconds(2f);

        }
    }

}