using UnityEngine;
namespace Title
{
    public class TimeAttackScore : MonoBehaviour
    {
        [SerializeField]
        private TimeAttackPresenter presenter;
        private int Time;
        void Start()
        {
            getTimeScore();
        }

        private void getTimeScore()
        {
            Time = PlayerPrefs.GetInt("TimeAttackScore", 0);
            presenter.setScore(Time);
        }
    }
}