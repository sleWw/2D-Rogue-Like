using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Enemy : MonoBehaviour, IInteract
    {
        SpriteRenderer spriteRenderer;


        void Awake(){
            spriteRenderer = this.GetComponent<SpriteRenderer>();
        }

        void Threaten()
        {
            print("I WILL GUT YOU LIKE A PIG!");
        }
        public void shot(){
            spriteRenderer.color = Random.ColorHSV(0f, 1f, 1f ,1f ,0.5f, 1f);
        }
        
        public void Interact()
        {
            Threaten();
        }
    }
}
