using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasirgahareket : MonoBehaviour
{
    //float randomX;
    //float randomY;
    //public GameObject parasut;
    //Vector3 vec;
    //bool kontrol = false;
    public float hiz;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * hiz * Time.deltaTime);
        //randomX = Random.Range(-1.78f, 1.78f);
        //if (kontrol==true)
        //{
        //    vec = new Vector3(randomX, parasut.transform.position.y, parasut.transform.position.z);
        //    Vector3.Lerp(parasut.transform.position, parasut.transform.position+new Vector3(5,0,0), Time.deltaTime);
        //}
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag == "parasut")
        //{
        //    kontrol = true;
        //    Invoke("Kontrol", 0.5f);
        //}
    }
    void Kontrol()
    {
        //kontrol = false;
    }
}
