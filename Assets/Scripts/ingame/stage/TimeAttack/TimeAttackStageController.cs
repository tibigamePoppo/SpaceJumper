using Ingame.Player;
using System.Collections.Generic;
using UnityEngine;


namespace Ingame.Stage.TimeAttack
{
    public class TimeAttackStageController : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> Stages;
        private Vector3 StartPosition;
        private Rigidbody2D rigidbody2d;
        private MeatDirection meatDirection;
        private GameObject Player;
        TimeAttackManager manager;
        int CurrentStageNum = 0;
        void Awake()
        {
            manager = GetComponent<TimeAttackManager>();
            Player = GameObject.FindWithTag("Player");
            StartPosition = Player.transform.position;
            rigidbody2d = Player.GetComponent<Rigidbody2D>();
            meatDirection = FindObjectOfType<MeatDirection>();
            StageActive();
        }

        public void NextStage()
        {
            StageActive();
        }

        private void StageActive()
        {
            if (CurrentStageNum >= Stages.Count)
            {
                manager.Finish();
                CurrentStageNum = Stages.Count;
            }
            else
            {
                foreach (var item in Stages)
                {
                    item.SetActive(false);
                }
                Stages[CurrentStageNum].SetActive(true);
                CurrentStageNum++;
                PlayerSet();
            }
        }

        private void PlayerSet()
        {
            Player.transform.position = StartPosition;
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            rigidbody2d.velocity = Vector2.zero;
            rigidbody2d.angularVelocity = 0;
            meatDirection.SetMeatPosition();
        }
    }
}