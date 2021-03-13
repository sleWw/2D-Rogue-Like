using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class CircleRenderer : MonoBehaviour
    {
        Transform _transform;
        int numberOfVertices;
        public float magnitude;
        LineRenderer line;

        Vector3 lineOrigin, lineEnd;

        //Vector3[] positions;

        void Awake(){
            _transform = this.GetComponent<Transform>();
           line = this.GetComponent<LineRenderer>();
        }
        void Start()
        {

        }
        void Update()
        {
            lineOrigin.z = -0.1f;
            lineEnd.z = -0.1f;

            lineOrigin.y = _transform.position.y;
            lineOrigin.x = _transform.position.x;
            lineEnd.x = lineOrigin.x;
            lineEnd.y = _transform.up.y * magnitude;
            //lineEnd.x = lineOrigin.x;

          line.SetPosition(0, lineOrigin);
          line.SetPosition(1, lineEnd);  


        }

    }

}
