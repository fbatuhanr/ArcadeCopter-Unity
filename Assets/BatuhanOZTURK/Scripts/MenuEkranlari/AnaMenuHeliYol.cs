using UnityEngine;
using System.Collections;

public class AnaMenuHeliYol : MonoBehaviour
{
    public GameObject[] YolBGrounds;
    public Material[] YolBgMats;

    public GameObject[] TemasNormaleDonus;

    float BgZaman = 10.2f;

    public Transform[] Yollar;
    public Transform Helikopter;
    public Animator HeliAnim;

    float SadeceIleriGeriAnimSuresiRotate = 10.0f;
    float SadeceIleriGeriAnimSuresi = 6.0f;
    float SadeceIleriGeri = 0.0f;

    bool Temas1,Temas2,Temas3, TemasNormal1, TemasNormal2, TemasNormal3;

    void Start()
    {
       HeliAnim.Play("Helikopter", -1, 0f);

        Temas1 = false;
        Temas2 = false;
        Temas3 = false;
        TemasNormal1 = false;
        TemasNormal2 = false;
        TemasNormal3 = false;

        TemasNormaleDonus[0].SetActive(false);
        TemasNormaleDonus[1].SetActive(false);
        TemasNormaleDonus[2].SetActive(false);
    }

    void FixedUpdate()
    {
        Time.timeScale = 1;

        Yollar[0].transform.position = Yollar[0].transform.position + new Vector3(-0.25f, 0, 0);

        if (SadeceIleriGeriAnimSuresi >= 0.0f)
        {
            SadeceIleriGeriAnimSuresi -= Time.deltaTime * 2.0f;
        }
        if (SadeceIleriGeriAnimSuresiRotate >= 0.0f)
        {
            SadeceIleriGeriAnimSuresiRotate -= Time.deltaTime * 2.0f;
        }
        //
        if (SadeceIleriGeriAnimSuresi <= 0.0f)
        {
            SadeceIleriGeriAnimSuresi = 6.0f;
        }
        if (SadeceIleriGeriAnimSuresiRotate <= 0.0f)
        {
            SadeceIleriGeriAnimSuresiRotate = 10.0f;
        }
        //

        if (SadeceIleriGeriAnimSuresi <= 6.0f && SadeceIleriGeriAnimSuresi > 3.0f)
        {
            transform.position = transform.position + new Vector3(0, 0.004f, 0);
        }
        else if (SadeceIleriGeriAnimSuresi <= 3.0f && SadeceIleriGeriAnimSuresi >= 0.0f)
        {
            transform.position = transform.position + new Vector3(0, -0.004f, 0);
        }

        if (SadeceIleriGeriAnimSuresiRotate <= 10.0f && SadeceIleriGeriAnimSuresiRotate > 8.0f)
        {
            transform.Rotate(0, 0, +0.05f);
        }
        else if (SadeceIleriGeriAnimSuresiRotate <= 8.0f && SadeceIleriGeriAnimSuresiRotate > 6.0f)
        {
            transform.Rotate(0, 0, -0.1f);
        }
        else if (SadeceIleriGeriAnimSuresiRotate <= 6.0f && SadeceIleriGeriAnimSuresiRotate > 4.0f)
        {
            transform.Rotate(0, 0, +0.1f);
        }
        else if (SadeceIleriGeriAnimSuresiRotate <= 4.0f && SadeceIleriGeriAnimSuresiRotate >= 2.0f)
        {
            transform.Rotate(0, 0, -0.1f);
        }
        else if (SadeceIleriGeriAnimSuresiRotate <= 2.0f && SadeceIleriGeriAnimSuresiRotate >= 0.0f)
        {
            transform.Rotate(0, 0, +0.05f);
        }

        if (Temas1)
        {
            Invoke("YoluIleriAta1", 0);
            Temas1 = false;
        }
        if (Temas2)
        {
            Invoke("YoluIleriAta2", 0);
            Temas2 = false;
        }
        if (Temas3)
        {
            Invoke("YoluIleriAta3", 0);
            Temas3 = false;
        }

        if (TemasNormal1)
        {
            Invoke("YoluIleriAtaNormal1", 0);
            TemasNormal1 = false;
        }
        if (TemasNormal2)
        {
            Invoke("YoluIleriAtaNormal2", 0);
            TemasNormal2 = false;
        }
        if (TemasNormal3)
        {
            Invoke("YoluIleriAtaNormal3", 0);
            TemasNormal3 = false;
        }

    }

    void YoluIleriAta1()
    {
       Yollar[1].transform.position = Yollar[1].transform.position + new Vector3(672.0f, 0, 0);
        TemasNormaleDonus[0].SetActive(true);
    }
    void YoluIleriAta2()
    {
       Yollar[2].transform.position = Yollar[2].transform.position + new Vector3(672.0f, 0, 0);
        TemasNormaleDonus[1].SetActive(true);
    }
    void YoluIleriAta3()
    {
       Yollar[3].transform.position = Yollar[3].transform.position + new Vector3(672.0f, 0, 0);
        TemasNormaleDonus[2].SetActive(true);
    }

    void YoluIleriAtaNormal1()
    {
        Yollar[1].transform.position = Yollar[1].transform.position + new Vector3(134.4f, 0, 0);
    }
    void YoluIleriAtaNormal2()
    {
        Yollar[2].transform.position = Yollar[2].transform.position + new Vector3(134.4f, 0, 0);
    }
    void YoluIleriAtaNormal3()
    {
        Yollar[3].transform.position = Yollar[3].transform.position + new Vector3(134.4f, 0, 0);
    }

    void OnTriggerEnter(Collider TemasNok)
    {
        if (TemasNok.gameObject.tag == "yoluzat1")
        {
             Temas1 = true;
        }
        else if (TemasNok.gameObject.tag == "yoluzat2")
        {
            Temas2 = true;
        }
        else if (TemasNok.gameObject.tag == "yoluzat3")
        {
            Temas3 = true;
        }


        else if (TemasNok.gameObject.tag == "yoluzatnormal1")
        {
            TemasNormal1 = true;
        }
        else if (TemasNok.gameObject.tag == "yoluzatnormal2")
        {
            TemasNormal2 = true;
        }
        else if (TemasNok.gameObject.tag == "yoluzatnormal3")
        {
            TemasNormal3 = true;
        }
    }
}
