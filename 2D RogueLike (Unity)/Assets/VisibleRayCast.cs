using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class VisibleRayCast : MonoBehaviour
    {
        PlayerAction playerAction;
        public int LengthOfLineRenderer = 20;
        LineRenderer lineRenderer;
        Vector2 selectedPos;

        void Awake(){
            lineRenderer = gameObject.GetComponent<LineRenderer>();
            playerAction = gameObject.GetComponent<PlayerAction>();

        }
        void Update(){
            //Get this bad boy working to hopefully display our raycast
            /*for(int i = 0; i < LengthOfLineRenderer; i++){
            lineRenderer.SetPosition(i, playerAction.direction);
            
            }*/
        
        }
    }
}
