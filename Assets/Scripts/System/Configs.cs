using UnityEngine;

namespace System
{
    public class Configs : MonoBehaviour
    {
        public static int StageNum = 0;
        public static int timeAttackTime = 0;
        public static bool Stage1Clear = false;
        public static bool Stage2Clear = false;
        public static bool Stage3Clear = false;
        public static bool Stage4Clear = false;

        public static void RestData()
        {
            Stage1Clear = false;
            Stage2Clear = false;
            Stage3Clear = false;
            Stage4Clear = false;
            PlayerPrefs.SetInt("TimeAttackScore", 0);
            PlayerPrefs.SetInt("Stage1Clear", 0);
            PlayerPrefs.SetInt("Stage2Clear", 0);
            PlayerPrefs.SetInt("Stage3Clear", 0);
            PlayerPrefs.SetInt("Stage4Clear", 0);
        }
    }
}