using UnityEngine;
namespace System
{
    public class ConfingReset : MonoBehaviour
    {
        [SerializeField]
        private bool Reset = false;
        static bool initial = true;
        void Awake()
        {
            if (initial && Reset)
            {
                initial = false;
                Configs.RestData();
            }
        }
    }
}