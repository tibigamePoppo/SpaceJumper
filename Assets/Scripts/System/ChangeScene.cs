using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
using System.Collections;

namespace System
{
    public class ChangeScene : MonoBehaviour
    {
        [SerializeField,Tooltip("�ړ���̃V�[����ݒ�")]
        private SceneObject targetScene;

        public void OnChange()
        {
            SceneManager.LoadScene(targetScene);
        }
    }
}