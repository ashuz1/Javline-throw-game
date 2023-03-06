using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private int count =0;
    void Start()
    {
        Debug.Log("3 destroy");
    }
    void OnCollisionEnter(Collision collisi)
    {
        
       

        if(collisi.gameObject.tag == "wall")
        {
            count = count+1;
            // print(count);
           if(count < 5)
           {
           
            Destroy(collisi.gameObject);
           

           }
           if(count == 4)
           {
            Debug.Log(" all destroy");
            Destroy(collisi.gameObject);
            Destroy(collisi.gameObject);
            

           }
        }
    
    }
}
