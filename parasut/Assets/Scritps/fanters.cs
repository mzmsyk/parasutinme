using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanters : MonoBehaviour
{
    public float bulutYakinGucu;
    public float bulutuzakGucu;
    public GameObject parasut;
    public Rigidbody2D fizik;
    bool kontrol1 = false;
    bool kontrol2 = false;
    GameObject Parasut;
    void Start()
    {
        //fizik = GetComponent<Rigidbody2D>();
        Parasut = GameObject.FindGameObjectWithTag("parasut");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mesafe = new Vector3(Vector2.Distance(transform.position, parasut.transform.position), parasut.transform.position.y, parasut.transform.position.z);
        if (mesafe.x >= 0f && mesafe.x < 1f && transform.position.y >= parasut.transform.position.y)
        {
            fizik.velocity = Vector2.zero;
            parasut.GetComponent<parasuthareket>().sag1 = false;
            parasut.GetComponent<parasuthareket>().sol1 = false;
            fizik.velocity = Vector2.zero;
            kontrol2 = false;
            //guc1();
            fizik.AddForce(Vector2.left * bulutYakinGucu, ForceMode2D.Force);
            
            Invoke("Kontrol", 1f);
            
        }
        if (mesafe.x >= 1f && mesafe.x <= 2f && transform.position.y >= parasut.transform.position.y)
        {
            fizik.velocity = Vector2.zero;
            parasut.GetComponent<parasuthareket>().sag1 = false;
            parasut.GetComponent<parasuthareket>().sol1 = false;
            fizik.velocity = Vector2.zero;
            kontrol1 = false;
            //guc2();
            fizik.AddForce(Vector2.left * bulutuzakGucu, ForceMode2D.Force);
            
            Invoke("Kontrol", 1f);
            
        }
        if (transform.position.y >= parasut.transform.position.y)
        {
            Invoke("Kontrol2", 0.5f);
        }
    }
    void Kontrol()
    {
        kontrol1 = false;
        kontrol2 = false;
        parasut.GetComponent<parasuthareket>().sag1 = true;
        parasut.GetComponent<parasuthareket>().sol1 = true;
       
        fizik.velocity = Vector2.zero;
        
    }
    void guc1()
    {
        kontrol1 = true;
        //fizik.AddForce(Vector2.right * bulutYakinGucu, ForceMode2D.Force);
    }
    void guc2()
    {
        kontrol2 = true;
        //fizik.AddForce(Vector2.right * bulutuzakGucu, ForceMode2D.Force);
    }
    void Kontrol2()
    {
        //gameObject.GetComponent<fanters>().enabled = false;
    }
}
