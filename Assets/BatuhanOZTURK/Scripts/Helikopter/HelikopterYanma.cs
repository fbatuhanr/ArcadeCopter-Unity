using UnityEngine;
using System.Collections;

public class HelikopterYanma : MonoBehaviour {

    public GameObject DefaultGovdeler, KirmiziGovdeler, YesilGovdeler, MaviGovdeler;

    public GameObject DefaultGovdeAnim, DefaultGovdeMat;
    public GameObject KirmiziGovdeAnim, KirmiziGovdeMat;
    public GameObject YesilGovdeAnim, YesilGovdeMat;
    public GameObject MaviGovdeAnim, MaviGovdeMat;


    void Start()
    {
        Helikopter.GovdeKaplamaDegerligi = PlayerPrefs.GetInt("Govde");
    }

    void Update () {

        if (OyuncuAyar.HelikopterYanma || SnszModOyunMenusu.HelikopteriYukariyaTasi)
        {
            if (Helikopter.GovdeKaplamaDegerligi == 0)
            {
                DefaultGovdeler.SetActive(true);
                DefaultGovdeAnim.SetActive(true);
                DefaultGovdeMat.SetActive(false);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 1)
            {
                KirmiziGovdeler.SetActive(true);
                KirmiziGovdeAnim.SetActive(true);
                KirmiziGovdeMat.SetActive(false);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 2)
            {
                YesilGovdeler.SetActive(true);
                YesilGovdeAnim.SetActive(true);
                YesilGovdeMat.SetActive(false);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 3)
            {
                MaviGovdeler.SetActive(true);
                MaviGovdeAnim.SetActive(true);
                MaviGovdeMat.SetActive(false);
            }
        }
        else
        {
            if (Helikopter.GovdeKaplamaDegerligi == 0)
            {
                DefaultGovdeler.SetActive(true);
                DefaultGovdeAnim.SetActive(false);
                DefaultGovdeMat.SetActive(true);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 1)
            {
                KirmiziGovdeler.SetActive(true);
                KirmiziGovdeAnim.SetActive(false);
                KirmiziGovdeMat.SetActive(true);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 2)
            {
                YesilGovdeler.SetActive(true);
                YesilGovdeAnim.SetActive(false);
                YesilGovdeMat.SetActive(true);
            }
            else if (Helikopter.GovdeKaplamaDegerligi == 3)
            {
                MaviGovdeler.SetActive(true);
                MaviGovdeAnim.SetActive(false);
                MaviGovdeMat.SetActive(true);
            }
        }
        	
	}
}
