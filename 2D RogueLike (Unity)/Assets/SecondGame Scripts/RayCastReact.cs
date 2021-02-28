using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class RayCastReact : MonoBehaviour, iRaycastInteract
    {

        SpriteRenderer spriteRenderer;
        Color defaultColor;
        Color diffColor = Color.red;
        
        void Awake(){
            spriteRenderer = this.GetComponent<SpriteRenderer>();
        }
        void Start(){
            defaultColor = spriteRenderer.color;
        }
        void Update()
        {
        
        }

        public void RaycastTouch(){
            spriteRenderer.color = diffColor;
        }
        public void RaycastNotTouching(){
            spriteRenderer.color = defaultColor;
        }
    }
}
