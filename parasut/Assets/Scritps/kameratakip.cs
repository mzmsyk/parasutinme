using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public Transform player;
    //Vector3 offset;
    public float smoothX;
    public float smoothY;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    bool kontrol = true;
    public float kameraSinir;
    public float hiz;
    void Start()
    {
        //player = GameObject.Find("ambulans").transform;
        //offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY),transform.position.z);//player.transform.position + offset;
        float posX = Mathf.Lerp(player.transform.position.x, transform.position.x, smoothX);
        float posY = Mathf.Lerp(player.transform.position.y, transform.position.y, smoothY);
        //float posY = Mathf.MoveTowards(transform.position.x, player.position.x, smoothY);
        //Vector2 kamera = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -15, 0));
        if (kontrol==true)
        {                                                                   //posY-4
            transform.position = new Vector3(Mathf.Clamp(posX, minX, maxX), transform.position.y, transform.position.z);
            transform.Translate(Vector2.down * hiz*Time.deltaTime);
        }
        

        //transform.position = kamera;

        // transform.position = player.position;
        if (transform.position.y<=kameraSinir)
        {
            kontrol = false;
            transform.position = new Vector3(transform.position.x, kameraSinir, transform.position.z);
        }
        if(player.transform.position.y>transform.position.y)
        {
            kontrol = true;
           // transform.position = new Vector3(Mathf.Clamp(posX, minX, maxX), player.transform.position.y - 4, transform.position.z);
        }
    }
}
