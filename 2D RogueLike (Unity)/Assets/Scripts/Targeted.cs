using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Targeted : MonoBehaviour
    {
        iTargetable target;
        GameObject thisGameObject;
        public GameObject otherGameObject;
        public bool objectTargeted = false;

        void OnTriggerStay2D(Collider2D coll){
            otherGameObject = coll.gameObject;
            target = otherGameObject.GetComponent<iTargetable>();
            if(target == null) return;
            target.ChangeColor();
            objectTargeted = true;
        }
        void OnTriggerExit2D(){
            if(target == null) return;
            target.DefaultColor();  
            objectTargeted = false;
        }


        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
