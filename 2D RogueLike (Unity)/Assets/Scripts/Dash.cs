using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Dash : MonoBehaviour
    {
        public float _maxDistanceDelta;
        public float _dashLengthInSeconds;
        public float overShootDistance;
        float dashLengthInSeconds;
        Camera _cam;
        Rigidbody2D _rb;
        [SerializeField]Vector2 mousePosition;
        Vector2 direction;
        Vector2 dashTarget;
        
        public PlayerState currentPlayerState = PlayerState.notDashing;
        public CoolDown coolDown = CoolDown.offCooldown;
        public enum CoolDown{
            onCooldown,
            offCooldown,
        }
        public enum PlayerState{
            Dashing,
            notDashing,
        }

        void Awake(){
            _cam = Camera.main;
            _rb = this.gameObject.GetComponent<Rigidbody2D>();
            //Setting dashLengthInSeconds to the Set Length in the inspector
            dashLengthInSeconds = _dashLengthInSeconds;
        }

        void Update(){
            mousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);
            direction = _rb.position - mousePosition;

            if(Input.GetButtonDown("Fire1") && currentPlayerState == PlayerState.notDashing && coolDown == CoolDown.offCooldown){
                TargetPosition();
                currentPlayerState = PlayerState.Dashing;
                coolDown = CoolDown.onCooldown;
            }
            if(currentPlayerState == PlayerState.Dashing){
                PlayerDash();
            }
            IsCoolDown();

        
        }

        void TargetPosition(){
            dashTarget.x = mousePosition.x;
            dashTarget.y = mousePosition.y;
        }
        void PlayerDash(){
            _rb.position = Vector2.MoveTowards(_rb.position, dashTarget, _maxDistanceDelta * Time.deltaTime);
        }
        void IsCoolDown(){
            if(currentPlayerState == PlayerState.Dashing && coolDown == CoolDown.onCooldown){
                //How long the dash lasts
                dashLengthInSeconds -= Time.deltaTime;

                if(dashLengthInSeconds <= 0){
                currentPlayerState = PlayerState.notDashing;
                coolDown = CoolDown.offCooldown;
                dashLengthInSeconds = _dashLengthInSeconds;
                }
            }
            
        }




    }
}
