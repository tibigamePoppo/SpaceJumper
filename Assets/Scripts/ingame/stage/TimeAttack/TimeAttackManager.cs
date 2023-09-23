using UnityEngine;
namespace Ingame.Stage.TimeAttack
{
    public class TimeAttackManager : MonoBehaviour
    {
        Timer timer;
        GameStateManager Manager;
        void Start()
        {
            timer = FindObjectOfType<Timer>();
            Manager = FindObjectOfType<GameStateManager>();
        }

        public void Finish()
        {
            if (Manager.currentState == GameStateManager.gameState.ingame)
            {
                Manager.ChangeState(GameStateManager.gameState.result);
                timer.StopTimer();
                PlayerPrefs.SetInt("TimeAttackScore", timer.time);
                var time = timer.time;
                var timeScore = new System.TimeSpan(0, 0, 0, time);
                naichilab.RankingLoader.Instance.SendScoreAndShowRanking(timeScore);
            }
        }
    }
}