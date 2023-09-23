using UnityEngine;
using TMPro;

namespace Title
{
    public class TimeAttackPresenter : MonoBehaviour
    {
        TextMeshProUGUI highScoreText;
        void Start()
        {
            highScoreText = GetComponent<TextMeshProUGUI>();
            highScoreText.text = "0:0";
        }

        public void setScore(int scoreTime)
        {
            highScoreText.text = $"{scoreTime / 60}:{scoreTime % 60}";
        }
    }
}