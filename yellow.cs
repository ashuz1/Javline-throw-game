using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
   public int count =0;
   void Start()
   {
    Debug.Log(" all destroy");
   }
   
    void OnCollisionEnter(Collision collisi)
    {
        
        

        if(collisi.gameObject.tag == "wall")
        {
          
            Destroy(collisi.gameObject);

          
        }
    
    }
}

