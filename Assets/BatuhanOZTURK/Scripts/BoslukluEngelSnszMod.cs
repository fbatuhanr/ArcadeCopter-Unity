using UnityEngine;
using System.Collections;

public class BoslukluEngelSnszMod : MonoBehaviour
{
    public GameObject Gold, Silver;
    public Transform Alt, Ust;

    public static bool TemasOlayi;
    float YukseklikAlcaklikBaslangic;

    void Start()
    {
        TemasOlayi = false;
        
        float YukseklikAlcaklikBaslangic = Random.Range(20.0f, 25.0f);
        transform.position = new Vector3(transform.position.x, YukseklikAlcaklikBaslangic, transform.position.z);

        float RandomGenislikBaslangic = Random.Range(0.7f, 7.1f);
        Alt.transform.localScale = new Vector3(RandomGenislikBaslangic, Alt.transform.localScale.y, Alt.transform.localScale.z);
        Ust.transform.localScale = new Vector3(RandomGenislikBaslangic, Ust.transform.localScale.y, Ust.transform.localScale.z);

        int ParaSpawnBaslangic = Random.Range(0, 2);
        int GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
        if (ParaSpawnBaslangic == 0)
        {
            if (GoldSilverGoldSpawnBaslangic == 0)
            {
                Gold.SetActive(true);
                Silver.SetActive(false);
            }
            else
            {
                Silver.SetActive(true);
                Gold.SetActive(false);
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
         float YukseklikAlcaklik = Random.Range(20.0f, 27.0f);
          transform.position = new Vector3(transform.position.x, YukseklikAlcaklik, transform.position.z);

            float RandomGenislik = Random.Range(0.7f, 7.1f);
            Alt.transform.localScale = new Vector3(RandomGenislik, Alt.transform.localScale.y, Alt.transform.localScale.z);
            Ust.transform.localScale = new Vector3(RandomGenislik, Ust.transform.localScale.y, Ust.transform.localScale.z);

        int ParaSpawn = Random.Range(0,2);
        int GoldSilverGoldSpawn = Random.Range(0,3);
        if (ParaSpawn == 0)
        {
            if (GoldSilverGoldSpawn == 0)
            {
                Gold.SetActive(true);
                Silver.SetActive(false);
            }
            else
            {
                Silver.SetActive(true);
                Gold.SetActive(false);
            }
        }
        else
        {
            Gold.SetActive(false);
            Silver.SetActive(false);
        }
    }
}