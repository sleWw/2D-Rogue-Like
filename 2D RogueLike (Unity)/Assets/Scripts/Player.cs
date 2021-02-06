using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Player : MonoBehaviour
    {
        public Rigidbody2D rb;
        public float moveSpeed;
        GameObject _thisGameObject;
        Vector2 move;
        
        Dash dash;
        


        void Awake()
        {
            dash = this.GetComponent<Dash>();
            _thisGameObject = this.gameObject;

        }

        // Update is called once per frame
        void Update()
        {
            move.y = Input.GetAxisRaw("Vertical");
            move.x = Input.GetAxisRaw("Horizontal");
        }

        void FixedUpdate()
        {
            if(dash.currentPlayerState == Dash.PlayerState.notDashing){
                PlayerMove();
            }

        }
        void PlayerMove(){
            rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
