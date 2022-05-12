using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class okengelhareket : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    public float boyut;
    public float uzama;
    bool kontrol = true;
    bool kontrol2 = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kontrol==true)
        {
            boyut -= hiz * Time.deltaTime;
        }
        if (kontrol2 == true)
        {
            boyut += hiz * Time.deltaTime;
        }
        if (boyut < 1)
        {
            kontrol = false;
            kontrol2 = true;
            
            
        }
        if (boyut >=uzama)
        {
            kontrol = true;
            kontrol2 = false;
        }
        
        transform.localScale = new Vector3(boyut, transform.localScale.y, transform.localScale.z);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "parasut")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
