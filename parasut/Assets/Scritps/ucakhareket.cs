using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucakhareket : MonoBehaviour
{
    public float hiz;
    bool kontrol = false;
    bool kontrol2 = false;
    public GameObject[] bomba;
    public float sayacBitir;
    public float bombaAtmaSuresi;
    public float ucakGecmeSuresi;
    void Start()
    {
        
    }

    
    void Update()
    {
       
        if (kontrol==true)
        {
            transform.Translate(Vector3.right * hiz * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="parasut")
        {
            kontrol = true;
            kontrol2 = true;
            //sayac++;
            StartCoroutine(BombaIptal());
            
        }
    }
    IEnumerator BombaIptal()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < sayacBitir; i++)
        {
            Instantiate(bomba[i], transform.position, transform.rotation);
            yield return new WaitForSeconds(bombaAtmaSuresi);
            
        }
       
    }
}
