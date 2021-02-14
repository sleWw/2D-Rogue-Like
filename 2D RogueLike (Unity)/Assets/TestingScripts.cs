using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class TestingScripts : MonoBehaviour
    {
        Transform _transform;
        LineRenderer lineRenderer;
        [SerializeField] float mathTest;
        void Awake(){
            _transform = this.gameObject.GetComponent<Transform>();
            lineRenderer = this.gameObject.GetComponent<LineRenderer>();
        }
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

            
        mathTest = Mathf.PingPong(Time.time, 5f);

            
        
        }
    }
}
