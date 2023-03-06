using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        PlayerPrefs.SetInt("flor",0);

    }
  

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0,0,speed);
    }

    void OnTriggerEnter(Collider collisi)
    {
        
        if(collisi.tag == "blue")
        {
          
            PlayerPrefs.SetInt("flor",1);
            
        }
        if(collisi.tag == "yellow")
        {
            
            PlayerPrefs.SetInt("flor",2);
         
        }
    
    }
}
