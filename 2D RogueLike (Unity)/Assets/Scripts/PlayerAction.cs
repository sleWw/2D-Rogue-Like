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

        //LineRenderer for Pierce
        LineRenderer lineRenderer;

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
            lineRenderer = this.gameObject.GetComponent<LineRenderer>();
            _thisGameObject = this.gameObject;

        }
        void Update()
        {
            mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
            direction = mousePosition - rb.position;
            if(onTrigger && Input.GetKey(KeyCode.E)){
            InteractCheck();
            }
            if(Input.GetButtonDown("Fire2")){
                RaycastShoot();
            }



        
        }
        void InteractCheck(){
            var interactable = triggeredObject.GetComponent<IInteract>();
            if(interactable == null) return;
            interactable.Interact();  
        }
        void RaycastShoot(){
                RaycastHit2D hit = Physics2D.Raycast(rb.position, direction, rayDistance);
                if(hit)
                {
                    //Checks to see if raycast hits first object
                    var shot = hit.collider.GetComponent<IInteract>();
                    if(shot == null) return;
                    shot.shot();

                    //Checks if an Object is behind the first hit object for a piercing effect
                    Rigidbody2D hitRB = hit.rigidbody;
                    RaycastHit2D pierce = Physics2D.Raycast(hitRB.position, direction, pierceDistance);
                    if(pierce){
                        var pierceShot = pierce.transform.GetComponent<IInteract>();
                        //transformPierce = pierce.transform;
                        if(pierceShot == null) return;
                        pierceShot.shot();
                    }
                    
                } 
        }
    }
}
