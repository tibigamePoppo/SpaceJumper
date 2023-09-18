using System.Collections;
using UnityEngine;
using Audio;

namespace ingame
{
    public class PlayerSe : MonoBehaviour
    {
        [SerializeField]
        private float soundInterval = 1f;
        PlayerMove playerMove;
        void Start()
        {
            playerMove = GetComponent<PlayerMove>();
            StartCoroutine(jetPackSound());
        }

        IEnumerator jetPackSound()
        {
            while (true)
            {
                if (playerMove.useJetPack) SeManager.Instance.ShotSe(SeType.jetPackFire);
                yield return new WaitForSeconds(soundInterval);
            }
        }
    }
}
