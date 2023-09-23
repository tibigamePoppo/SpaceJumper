using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Ingame.Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField]
        private Image PlayerVisualImage;
        [SerializeField]
        private List<Sprite> PlayerSprite;
        private PlayerMove playerMove;
        void Start()
        {
            playerMove = GetComponent<PlayerMove>();
        }

        void FixedUpdate()
        {
            if(playerMove.useJetPack)
            {
                PlayerVisualImage.sprite = PlayerSprite[1];
            }
            else
            {
                PlayerVisualImage.sprite = PlayerSprite[0];
            }
        }
    }
}