using UnityEngine;
using System.Collections;

public class Engel_Bosluklu : MonoBehaviour
{
    public GameObject Silver, Gold;

    public Transform helikopter;

    public Transform Alt, Ust;

    public bool TemasOlayi;
    float YukseklikAlcaklikBaslangic;

    void Start()
    {
        TemasOlayi = false;

        float YukseklikAlcaklikBaslangic = Random.Range(43.3f, 53.4f);
        transform.position = new Vector3(transform.position.x, YukseklikAlcaklikBaslangic, transform.position.z);

        int SpawnParaBaslangic = Random.Range(0, 2); // %50 ihtimal
        int GoldSilverGoldOranBaslangic = Random.Range(0, 3);
        if (SpawnParaBaslangic == 0)
        {
            if (GoldSilverGoldOranBaslangic == 0)
            {
                Gold.SetActive(true);
                Silver.SetActive(false);
            }
            else
            {
                Gold.SetActive(false);
                Silver.SetActive(true);
            }
        }
        else
        {
            Gold.SetActive(false);
            Silver.SetActive(false);
        }

    }

    void Update()
    {
        if (TemasOlayi)
        {
            Invoke("OtoAta", 0);
            TemasOlayi = false;
        }


    }

    void OtoAta()
    {
        if (helikopter.transform.position.x > 2360) {
            transform.position = transform.position + new Vector3(0, 0, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(75.0f, 0, 0);

            float YukseklikAlcaklik = Random.Range(43.3f, 53.4f);
            transform.position = new Vector3(transform.position.x, YukseklikAlcaklik, transform.position.z);

            float RandomGenislik = Random.Range(0.7f, 7.1f);
            Alt.transform.localScale = new Vector3(RandomGenislik, Alt.transform.localScale.y, Alt.transform.localScale.z);
            Ust.transform.localScale = new Vector3(RandomGenislik, Ust.transform.localScale.y, Ust.transform.localScale.z);

            int SpawnPara = Random.Range(0, 2); // %50 ihtimal
            int GoldSilverGoldOran = Random.Range(0,3);
                if (SpawnPara == 0) {
                    if (GoldSilverGoldOran == 0)
                    {
                    Gold.SetActive(true);
                    Silver.SetActive(false);
                     }
                    else
                    {
                    Gold.SetActive(false);
                    Silver.SetActive(true);
                    }
               }
                else
                {
                Gold.SetActive(false);
                Silver.SetActive(false);
            }
        }
    }
}