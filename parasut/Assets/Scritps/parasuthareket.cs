using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class parasuthareket : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool sag, sol, orta, kontrol = true;
    public bool sag1 = true;
    public bool sol1 = true;
    GameObject OyunYoneticisi;
    GameObject Fan;
    Touch parmak;
    public GameObject fan;
    bool kontrol2 = false;
    float randomX;
    float randomY;
    Vector2 vec;
    Vector2 vec2;
    public Sprite ortaResim;
    public Sprite solResim;
    public Sprite sagResim;
    SpriteRenderer spriterenderer;
    float deltaX, deltaY;
    public float yanHiz;
    public GameObject camera;
    void Start()
    {
        
        Fan = GameObject.FindGameObjectWithTag("fan");
        fizik = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        
        Debug.Log("randomX: " + randomX);
    }

    
    void FixedUpdate()
    {
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), transform.position.y, transform.position.z);
        
        
        spriterenderer.sprite = ortaResim;
        if (kontrol == true)
        {
            transform.Translate(Vector2.down * hiz * Time.deltaTime);
            


        }
        



        
        Vector3 ortaHareket = new Vector3(0f, transform.position.y, transform.position.z);
        if (Input.touchCount > 0)
        {
            parmak = Input.GetTouch(0);
            Vector2 parmak2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if (parmak2.x > 0)
            {
                sag = true;
                sol = false;
                orta = false;
                spriterenderer.sprite = sagResim;
            }
            
            if (parmak2.x < 0)
            {
                sag = false;
                sol = true;
                orta = false;

                spriterenderer.sprite = solResim;

            }
            if (parmak2.x == 0)
            {
                sag = false;
                sol = false;
                orta = true;
                spriterenderer.sprite = ortaResim;
            }
            if (sag == true && sag1 == true)
            {
                Vector3 sagHareket = new Vector3(1.88f, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, sagHareket, 1f * Time.deltaTime);


            }
            if (sol == true && sol1 == true)
            {
                Vector3 solHareket = new Vector3(-1.88f, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, solHareket, 1f * Time.deltaTime);


            }
            if (orta == true)
            {
                Vector3 Hareket = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                transform.position = Hareket;


            }


        }
       
        if (kontrol2 == true)
        {
            
            vec = new Vector2(randomX, transform.position.y);
            Debug.Log("vec: " + vec);
            vec2=Vector2.Lerp(transform.position, vec, 4*Time.fixedDeltaTime);
            Debug.Log("vec2: " + vec2);
            transform.position = vec2;
            Debug.Log("pos: " + transform.position);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "bulut")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
        if (col.gameObject.tag == "bomba")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (col.gameObject.tag == "kasirga")
        {
            randomX = Random.Range(-1.78f, 1.78f);
            kontrol2 = true;
            Invoke("Kontrol2", 1f);
        }
        if (col.gameObject.tag == "delik")
        {
            randomX = Random.Range(-1.78f, 1.78f);
            randomY = Random.Range(0f, -20f);
            transform.position = new Vector2(randomX, randomY);
           /* Vector2 vec = new Vector2(1.4f, 3.7f);
            transform.position = vec;
            camera.transform.position = new Vector3(0, 0, -10);*/

        }
        if (col.gameObject.tag == "yer")
        {
            kontrol = false;
            transform.Translate(0,0,0);
            fizik.velocity = Vector2.zero;
            sag1 = false;
            sol1 = false;
        }
        if (col.gameObject.tag == "deniz")
        {
            kontrol = false;
            transform.Translate(0,0,0);
            fizik.velocity = Vector2.zero;
            sag1 = false;
            sol1 = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    
    void Kontrol2()
    {
        kontrol2 = false;
    }
}
