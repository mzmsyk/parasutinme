using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yarimdondurme : MonoBehaviour
{
    public float aci;
    public float hiz;
    bool kontrol1 = true;
    bool kontrol2 = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kontrol1==true)
        {
            aci += hiz * Time.deltaTime;
        }
        if (kontrol2 == true)
        {
            aci -= hiz * Time.deltaTime;
        }
        if (aci <= 90&&kontrol1==true)
        {
            
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, aci);
            if (aci>=88&&kontrol2==false)
            {
                kontrol1 = false;
                kontrol2 = true;
            }
        }
        if (aci>=-90&&kontrol2==true)
        {
           
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, aci);
            if (aci < -88 && kontrol1 == false)
            {
                kontrol1 = true;
                kontrol2 = false;
            }
        }
        
        

    }
}
