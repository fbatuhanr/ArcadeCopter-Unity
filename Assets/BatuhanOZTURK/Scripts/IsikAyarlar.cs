using UnityEngine;
using System.Collections;

public class IsikAyarlar : MonoBehaviour {

    public Light isikkaynagi;

    public float zaman;

    public float zamanCokAydinlan;
    public float zamanAzAydinlan;

    public bool CokAydinlan;
    void Start () {

        isikkaynagi = GetComponent<Light>();

        zaman = 2.5f;

        zamanCokAydinlan = 5.0f;
        zamanAzAydinlan = 2.0f;
    }
  void Update () {
    
        if (OyuncuAyar.isiklarSonsun) {
            Invoke("HavaKarart", 0);
        }
        else if (OyuncuAyar.isiklarSonsun == false)
        {
            Invoke("HavaAydinlan", 0);
        } 
    }
    void HavaKarart()
    {
        if (zaman >= 0.0f)
        {
            zaman -= Time.deltaTime;
        }
        if (zaman <= 2.4f && zaman >= 0.2f)
        {
            isikkaynagi.color += Color.blue / 2.0f * Time.deltaTime;
            CokAydinlan = true;
        }
    }
    void HavaAydinlan()
    {

        if (CokAydinlan)
        {
            if (zamanCokAydinlan >= 0.0f)
            {
                zamanCokAydinlan -= Time.deltaTime;
            }

            if (zamanCokAydinlan < 4.0f && zamanCokAydinlan > 2.0f)
            {
                isikkaynagi.color += Color.white / 2.0f * Time.deltaTime;

            }

        }
        else
        {
            if (zamanAzAydinlan >= 0.0f)
            {
                zamanAzAydinlan -= Time.deltaTime;
            }

            if (zamanAzAydinlan < 1.5f && zamanAzAydinlan > 1.3f)
            {
                isikkaynagi.color += Color.white / 2.0f * Time.deltaTime;

            }
        }
      
    }
}
