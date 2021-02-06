using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Dash : MonoBehaviour
    {
        Camera _cam;
        Rigidbody2D _rb;
        Vector2 mousePosition;
        Vector2 direction;
        public float _maxDistanceDelta;

        public float _dashLengthInSeconds;
        float dashLengthInSeconds;
        
        playerState currentPlayerState = playerState.notDashing;

        enum playerState{
            Dashing,
            notDashing,
        }

        void Awake(){
            _cam = Camera.main;
            _rb = this.gameObject.GetComponent<Rigidbody2D>();
            dashLengthInSeconds = _dashLengthInSeconds;
        }

        void Update(){
            mousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);
            direction = _rb.position - mousePosition;

            if(Input.GetKeyDown(KeyCode.Space)){
                currentPlayerState = playerState.Dashing;
            }
            if(currentPlayerState == playerState.Dashing && dashLengthInSeconds > 0){
                dash();
            }

            if(currentPlayerState == playerState.Dashing && dashLengthInSeconds > 0){
                dashLengthInSeconds -= Time.deltaTime;
            }
            if(dashLengthInSeconds <= 0){
                currentPlayerState = playerState.notDashing;
                dashLengthInSeconds = _dashLengthInSeconds;
            }

        
        }
        void dash(){
            _rb.position = Vector2.MoveTowards(_rb.position, mousePosition, _maxDistanceDelta * Time.deltaTime);
        }
    }
}
