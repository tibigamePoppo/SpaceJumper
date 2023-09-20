using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
using System.Collections;

namespace System
{
    public class ChangeScene : MonoBehaviour
    {
        [SerializeField,Tooltip("ˆÚ“®æ‚ÌƒV[ƒ“‚ğİ’è")]
        private SceneObject targetScene;

        public void OnChange()
        {
            SceneManager.LoadScene(targetScene);
        }
    }
}