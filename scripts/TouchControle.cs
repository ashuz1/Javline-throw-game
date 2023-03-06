using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControle : MonoBehaviour
{
    [SerializeField]
    public GameObject javline; 
    public GameObject projectile; 
    public GameObject yellow; 
    public Transform barrelEnd;
    private int counta=0;

   void Update()
    {
        swipe();
    }
    public void swipe()
    {
        if(PlayerPrefs.GetInt("flor")==1 || PlayerPrefs.GetInt("flor") == 2)
        {
            if(Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Ended )
            {
                javline.SetActive(false);
                counta=counta+1;
            // instansiate the projectile
            if(PlayerPrefs.GetInt("flor")==1 && counta ==1)
            {
                Rigidbody rb = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation).GetComponent<Rigidbody>();
                rb.AddForce(barrelEnd.forward * 30f, ForceMode.Impulse);
               
            }
            if(PlayerPrefs.GetInt("flor") == 2 && counta ==1)
            {
                Rigidbody rb = Instantiate(yellow, barrelEnd.position, barrelEnd.rotation).GetComponent<Rigidbody>();
                rb.AddForce(barrelEnd.forward * 30f, ForceMode.Impulse);
            

            }
            
           
        }
        
    }
    }
}
