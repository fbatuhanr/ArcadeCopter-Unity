using UnityEngine;
using System.Collections;

public class Engel_Bir : MonoBehaviour
{

    public bool TemasOlayi;
    public GameObject CisimSec;
    public Transform OtoAnimObje;

    void Start()
    {
        TemasOlayi = false;
    }

    void Update()
    {
        if (TemasOlayi)
        {
            Invoke("OtoAta", 0);
            TemasOlayi = false;
        }

      //  if (transform.position.x > 680)
       // {
        //    transform.position = new Vector3(1100, 0, 0);
        // }

    }

    void OtoAta()
    {

        // Engel Mesafesi Rastgele
        // Yükseklik Rastgelle

        float EngelMesafesi = Random.Range(50.0f, 150.0f);
        float YukseklikAlcaklik = Random.Range(23.5f, 33.5f);

        transform.position = transform.position + new Vector3(EngelMesafesi,0,0);
        transform.localPosition =  new Vector3(transform.position.x, YukseklikAlcaklik, transform.position.z);       

        // Ne kadar büyüklük arasında rastgele

        float RastgeleGenislik = Random.Range(1,4);
        float SabitZ = 6.5f;
        CisimSec.transform.localScale = new Vector3(RastgeleGenislik, RastgeleGenislik, SabitZ);
    }
}