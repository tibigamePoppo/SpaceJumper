using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
using System.Collections;

namespace System
{
    public class ChangeScene : MonoBehaviour
    {
        [SerializeField,Tooltip("移動先のシーンを設定")]
        private SceneObject targetScene;

        public void OnChange()
        {
            SceneManager.LoadScene(targetScene);
        }
    }
}