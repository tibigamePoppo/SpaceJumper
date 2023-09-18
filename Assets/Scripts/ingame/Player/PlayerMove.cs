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
        void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(Input.GetKey(KeyCode.Space))
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