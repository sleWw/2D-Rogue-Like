using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class VisibleRayCast : MonoBehaviour
    {
        Targeted targetedScript;
        Rigidbody2D rb;
        PlayerAction playerAction;
        LineRenderer lineRenderer;
        Vector2 targetPosition;
        
        void Awake(){
            targetedScript = this.gameObject.GetComponent<Targeted>();
            rb = this.gameObject.GetComponent<Rigidbody2D>();
            lineRenderer = gameObject.GetComponent<LineRenderer>();
            playerAction = gameObject.GetComponent<PlayerAction>();

        }

        void Update(){
            lineRenderer.SetPosition(0, rb.position);
            if(targetedScript.objectTargeted == true){
            targetPosition = targetedScript.otherGameObject.transform.position;
            lineRenderer.SetPosition(1,targetPosition); 
            } else lineRenderer.SetPosition(1, rb.position); 
        }

    }
}
