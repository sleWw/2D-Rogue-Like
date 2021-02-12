using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class PlayerAction : MonoBehaviour
    {
        //public ParticleSystem particleSystem;
        public Rigidbody2D rb;
        public float rayDistance;
        public float pierceDistance;
        GameObject _thisGameObject;
        public Camera mainCam;
        GameObject triggeredObject;
        Vector2 mousePosition;
        public Vector2 direction;

        //Change Color When Targeted Variables
        Color defaultColor;
        Color newColor = Color.red;

        Vector2 move;
        bool onTrigger = false;

        void OnTriggerEnter2D(Collider2D collider)
        {
            triggeredObject = collider.gameObject;
            onTrigger = true;
            
        }
        void OnTriggerExit2D()
        {
            onTrigger = false;
        }

        void Awake()
        {
            _thisGameObject = this.gameObject;

        }
        void Update()
        {
            mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
            direction = mousePosition - rb.position;
            //float angle = Mathf.Atan2(direction.y, direction.x);
            if(onTrigger && Input.GetButtonDown("Fire1")){
            InteractCheck();
            }
            if(Input.GetButtonDown("Fire2")){
                RaycastShoot();
            }

            
        
        }
        void InteractCheck(){
          if(onTrigger && Input.GetButtonDown("Fire1"))
            {
                var interactable = triggeredObject.GetComponent<IInteract>();
                if(interactable == null) return;
                interactable.Interact();
            }  
        }
        void RaycastShoot(){
                RaycastHit2D hit = Physics2D.Raycast(rb.position, direction, rayDistance);
                if(hit)
                {
                    var shot = hit.collider.GetComponent<IInteract>();
                    //if(shot == null) return;
                    if(shot == null) return;
                    shot.shot();                    
                    
                    Rigidbody2D hitRB = hit.rigidbody;
                    RaycastHit2D pierce = Physics2D.Raycast(hitRB.position, direction, pierceDistance);
                    if(pierce){
                        var pierceShot = pierce.transform.GetComponent<IInteract>();
                        if(pierceShot == null) return;
                        pierceShot.shot();
                    }
                    
                } 
        }
    }
}
