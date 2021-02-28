using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class RaycastTesting : MonoBehaviour
    {
        Transform _transform;
        public Vector3 rayCastEnd, rayCastOrigin;
        public Vector3 rayCastEndPoint;
        Vector3 defaultrayCastEnd;
        public float magnitude;
        float defaultMagnitude;
        CircleCollider2D circleColl;
        RaycastHit2D[] raycastArray = new RaycastHit2D[5];
        RaycastHit2D cachedRaycast;
        RaycastHit2D emptyRaycast;

        void OnCollisionEnter2D(){
            print("print");
        }

        void Awake(){
            _transform = this.transform;
            circleColl = this.GetComponent<CircleCollider2D>();
        }

        void Start(){
            rayCastOrigin = _transform.position;
            rayCastEnd = _transform.up * magnitude;
            defaultrayCastEnd = rayCastEnd;    
        }
 
        void Update()
        {
            //This keeps the LineRenderer infront of all objects
            rayCastEnd.z = -0.1f;
            rayCastOrigin.z = -0.1f;

            rayCastOrigin.y = _transform.position.y;
            rayCastOrigin.x = _transform.position.x;
            rayCastEnd.y = _transform.up.y * magnitude;
            rayCastEnd.x = _transform.up.x * magnitude;

            RaycastHit2D raycast = Physics2D.Raycast(rayCastOrigin, rayCastEnd);

            if(cachedRaycast == false){
                cachedRaycast = raycast;
                if(cachedRaycast == false) return;
                var raycastInteract = cachedRaycast.transform.GetComponent<iRaycastInteract>();
                raycastInteract.RaycastTouch();
            }

            if(cachedRaycast == true && raycast == false){
                var raycastInteract = cachedRaycast.transform.GetComponent<iRaycastInteract>();
                raycastInteract.RaycastNotTouching();
                cachedRaycast = emptyRaycast;
            }
        }
    }
}
