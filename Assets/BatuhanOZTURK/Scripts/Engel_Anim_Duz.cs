using UnityEngine;
using System.Collections;

public class Engel_Anim_Duz : MonoBehaviour
{
    public Transform karakter;

    public bool Engel_Anim_Temas;

    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;

    public static bool EngelAnimBitisi;

    public static int Sayac;

    void Start()
    {
        anim1.speed = 0.25f;
        anim2.speed = 0.5f;
        anim3.speed = 0.75f;
        anim4.speed = 0.9f;
        anim5.speed = 1.0f;

        EngelAnimBitisi = false;
        Engel_Anim_Temas = false;
    }
    
    void Update()
    {
        if (Engel_Anim_Temas)
        {
            if (EngelAnimBitisi == false) { 

               Invoke("OtoAta", 0);
               Engel_Anim_Temas = false;
            }
            else {}
        }

        if (Sayac < 5)
        {
            EngelAnimBitisi = false;
        }
        else
        {
            EngelAnimBitisi = true;
        }
      


        if (transform.position.x == 1000)
        {
            anim1.speed = 0.25f;
        }
        if (transform.position.x == 1020)
        {
            anim1.speed = 0.5f;
        }
        if (transform.position.x == 1040)
        {
            anim1.speed = 0.75f;
        }
        if (transform.position.x == 1060)
        {
            anim1.speed = 0.9f;
        }
        if (transform.position.x == 1080)
        {
            anim1.speed = 1.0f;
        }
    }

    void OtoAta()
    {
        Sayac++;
       transform.position = transform.position + new Vector3(75.0f, 0, 0);

        if (transform.position.x == 1100)
        {
            anim1.speed = 1.1f;
        }
        if (transform.position.x == 1120)
        {
            anim2.speed = 1.2f;
        }
        if (transform.position.x == 1140)
        {
            anim3.speed = 1.3f;
        }
        if (transform.position.x == 1160)
        {
            anim4.speed = 1.4f;
        }
        if (transform.position.x == 1180)
        {
            anim5.speed = 1.5f;
        }
    }
}

   
