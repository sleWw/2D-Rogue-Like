using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class MouseScript : MonoBehaviour
    {
        public Camera mainCam;
        Transform _transform;
        Vector2 mousePosition;

        void Awake(){
            _transform = this.GetComponent<Transform>();
        }

        void Update(){
            mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);

        }

        void FixedUpdate(){
            _transform.position = mousePosition;
        }
    }
}
