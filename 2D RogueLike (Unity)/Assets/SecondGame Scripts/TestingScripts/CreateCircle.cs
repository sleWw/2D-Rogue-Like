using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class CreateCircle : MonoBehaviour
    {
        Transform _transform;
        public RaycastHit2D circleCast;
        public float circleRadius;
        public float thickness;
        


        // Update is called once per frame
        void Start()
        {
            _transform = this.GetComponent<Transform>();
        }
        void Update()
        {
            circleCast = Physics2D.CircleCast(_transform.position, circleRadius, _transform.right);
            if(circleCast == true){
                print(circleCast.transform.name);
            }
            

        
        }
    }
}
