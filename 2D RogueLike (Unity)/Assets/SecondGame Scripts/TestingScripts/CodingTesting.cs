using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class CodingTesting : MonoBehaviour
    {
         public GameObject[] targets;
        Transform _transform;
        LineRenderer lineRenderer;

        public Ray2D ray;
        public RaycastHit2D raycast;
        public float lineWidth;
        public float x_magnitude;
        public float y_magnitude;
        public Vector2 magnitude;
        Vector2 defaultMagnitude;
        Vector3 rayCastOrigin, rayCastEnd, rayCastEnd_x, rayCastEnd_y;

        void Awake(){
            _transform = this.GetComponent<Transform>();
            lineRenderer = this.GetComponent<LineRenderer>();

        }

        void Start(){
            //This keeps the raycast Centered on the GameObject on the X Axis no matter where it is placed
           magnitude.x = magnitude.x + _transform.position.x;
           magnitude.y = magnitude.y + _transform.position.y;
            rayCastEnd_x = _transform.right * magnitude.x;
            rayCastEnd_y = _transform.up * magnitude.y;
            defaultMagnitude = magnitude;
        }
        void Update()
        {
            rayCastOrigin.x = _transform.position.x;
            rayCastOrigin.y = _transform.position.y;
            rayCastOrigin.z = -0.1f;

            rayCastEnd.x = _transform.right.x * magnitude.x;
            rayCastEnd.y = _transform.up.y * magnitude.y;
            rayCastEnd.z = -0.1f;


            //For Loops Update Continuiously inside of the Update function
        /*  for(int i = 0; i < targets.Length; i++){
                Debug.Log("Updated Target" + i);
            }   */
        //ray = new Ray2D(_transform.position, _transform.right);
        //raycast = Physics2D.Raycast(_transform.position, _transform.right);
        raycast = Physics2D.Raycast(rayCastOrigin, rayCastEnd);
        lineRenderer.startColor = Color.cyan;
        lineRenderer.endColor = Color.cyan;
        lineRenderer.SetPosition(0, rayCastOrigin);
        lineRenderer.SetPosition(1, rayCastEnd);
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;   

        }
    }
}
