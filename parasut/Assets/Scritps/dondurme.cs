using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme : MonoBehaviour
{
    public float hiz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
