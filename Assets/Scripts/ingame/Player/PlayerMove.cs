using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ingame
{
    public class PlayerMove : MonoBehaviour
    {
        Rigidbody2D rb2D;
        public bool useJetPack { private set; get; } = false;
        [SerializeField]
        private float jetPackPower;
        [SerializeField]
        private Transform jetPackFirePosition;
        GameStateManager manager;
        void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
            manager = FindObjectOfType<GameStateManager>();
        }

        void FixedUpdate()
        {
            if(Input.GetKey(KeyCode.Space) && manager.currentState == GameStateManager.gameState.ingame)
            {
                useJetPack = true;
                rb2D.AddForceAtPosition(transform.up * jetPackPower * Time.deltaTime, jetPackFirePosition.position);
            }
            else
            {
                useJetPack = false;
            }
        }
    }
}