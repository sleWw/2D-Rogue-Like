using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Neutral : MonoBehaviour, IInteract
    {
        SpriteRenderer spriteRenderer;

        void Awake(){
            spriteRenderer = this.GetComponent<SpriteRenderer>();
        }
        
        public void shot() => spriteRenderer.color = Random.ColorHSV(0f, 1f, 1f ,1f ,0.5f, 1f);

        public void Interact(){
            print("I ARE NEUTRAL DONT FUK WITH ME!!!");

        }
    }
}
