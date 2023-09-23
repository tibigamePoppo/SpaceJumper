using System.Collections;
using TMPro;
using UnityEngine;

namespace Ingame.Stage.TimeAttack
{
    public class Timer : MonoBehaviour
    {
        TextMeshProUGUI textMeshPro;
        public int time { private set; get; }
        private bool isCount = true;
        void Start()
        {
            time = 0;
            textMeshPro = GetComponent<TextMeshProUGUI>();
            StartCoroutine(TimeCountUp());
        }

        public void StopTimer()
        {
            isCount = false;
        }

        IEnumerator TimeCountUp()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                if (!isCount) break;
                time++;
                ViewText();
            }
        }

        private void ViewText()
        {
            System.TimeSpan timeSpan = new System.TimeSpan(0, 0, time);
            textMeshPro.text = $"{ timeSpan.Minutes}:{ timeSpan.Seconds}";
        }
    }
}