using UnityEngine;
using System.Collections;

public class Engel_Anim_Kare : MonoBehaviour
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
        Sayac = 0;

        anim1.speed = 1.0f;
        anim2.speed = 1.0f;
        anim3.speed = 1.0f;
        anim4.speed = 1.0f;
        anim5.speed = 1.0f;

        EngelAnimBitisi = false;
        Engel_Anim_Temas = false;
    }

    void Update()
    {
        if (Engel_Anim_Temas)
        {
            if (EngelAnimBitisi == false)
            {
                Invoke("OtoAta", 0);
                Engel_Anim_Temas = false;
            }
            else  {}           
        }

        if (Sayac < 5)
        {
            EngelAnimBitisi = false;
        }
        else
        {
            EngelAnimBitisi = true;
        }

        //1215 1250 1285 1320 1355
        if (transform.position.x == 1215 || transform.position.x == 1250 || transform.position.x == 1285 || transform.position.x == 1320 || transform.position.x == 1355)
        {
            anim1.speed = 1.0f;
            anim2.speed = 1.0f;
            anim3.speed = 1.0f;
            anim4.speed = 1.0f;
            anim5.speed = 1.0f;
        }
    }

    void OtoAta()
    {
        Sayac++;
        transform.position = transform.position + new Vector3(175.0f, 0, 0);

        if (transform.position.x == 1390)
        {
            anim1.speed = 1.25f;
        }
        if (transform.position.x == 1425)
        {
            anim2.speed = 1.5f;
        }
        if (transform.position.x == 1460)
        {
            anim3.speed = 1.75f;
        }
        if (transform.position.x == 1495)
        {
            anim4.speed = 2.0f;
        }
        if (transform.position.x == 1530)
        {
            anim5.speed = 2.25f;
        }
    }
}


