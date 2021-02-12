using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Friendly : MonoBehaviour, IInteract ,iTargetable
    {

        SpriteRenderer spriteRenderer;

        Color newColor = Color.red;
        public Color defaultColor;

        void Awake(){
            spriteRenderer = this.GetComponent<SpriteRenderer>();
            defaultColor = spriteRenderer.color;
        }


        
        void Greet()
        {
            print("Hello Traveller");
        }
        public void ChangeColor(){
            spriteRenderer.color = newColor;          
        }
        public void DefaultColor(){
            spriteRenderer.color = defaultColor;
        }
        public void shot() => spriteRenderer.color = Random.ColorHSV(0f, 1f, 1f ,1f ,0.5f, 1f);

        public void Interact()
        {
            Greet();
        }

    }
}
