using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketlibulut : MonoBehaviour
{
    public float hiz;
    public GameObject sag;
    public GameObject sol;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.right*hiz * Time.deltaTime);
        

    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sag")
        {
            hiz *= -1;
            
        }
        if (col.gameObject.tag == "sol")
        {
            hiz *= -1;
            
        }
    }
}
