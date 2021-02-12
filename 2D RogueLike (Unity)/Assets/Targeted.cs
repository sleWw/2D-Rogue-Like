using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    public class Targeted : MonoBehaviour
    {
        iTargetable target;
        GameObject thisGameObject;
        GameObject otherGameObject;

        void OnTriggerStay2D(Collider2D coll){
            otherGameObject = coll.gameObject;
            target = otherGameObject.GetComponent<iTargetable>();
            if(target == null) return;
            target.ChangeColor();
        }
        void OnTriggerExit2D(){
            target = otherGameObject.GetComponent<iTargetable>();
            if(target == null) return;
            target.DefaultColor();  
        }


        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
