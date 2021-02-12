using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Enemy : MonoBehaviour, IInteract, iTargetable
    {
        SpriteRenderer spriteRenderer;
        Color newColor = Color.black;
        public Color defaultColor;


        void Awake(){
            spriteRenderer = this.GetComponent<SpriteRenderer>();
            defaultColor = spriteRenderer.color;
        }

        void Threaten()
        {
            print("I WILL GUT YOU LIKE A PIG!");
        }
        public void shot() => spriteRenderer.color = Random.ColorHSV(0f, 1f, 1f ,1f ,0.5f, 1f);
        public void ChangeColor(){
            spriteRenderer.color = newColor;         
        }
        public void DefaultColor(){
            spriteRenderer.color = defaultColor;
        }

            
        
        public void Interact()
        {
            Threaten();
        }
    }
}
