using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class LineRendererScript : MonoBehaviour
    {
        RaycastTesting raycastTesting;
        LineRenderer lineRenderer;

        void Awake(){
            lineRenderer = this.GetComponent<LineRenderer>();   
            raycastTesting = this.GetComponent<RaycastTesting>();         
        }
        // Update is called once per frame
        void Update()
        {
            lineRenderer.SetPosition(0, raycastTesting.rayCastOrigin);
            lineRenderer.SetPosition(1, raycastTesting.rayCastEnd);

            
        
        }
    }
}
