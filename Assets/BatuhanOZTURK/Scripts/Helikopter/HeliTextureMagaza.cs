using UnityEngine;
using System.Collections;

public class HeliTextureMagaza : MonoBehaviour {

    public GameObject Pervane, Kuyruk, AC1, AC2, AC3, AC4, AC5, AC6;
    public Material DefaultPervane, DefaultKuyruk, DefaultAC123456;
    // PERVANE
    public Material KirmiziPervane, YesilPervane, MaviPervane;
    // GOVDE
    
    // ALTLIK
    public Material KirmiziAltlik, YesilAltlik, MaviAltlik;
    // ALTLIK
    public Material KirmiziKuyruk, YesilKuyruk, MaviKuyruk;
    // TRAIL
    public GameObject ilkTrail, ikinciTrail, ucuncuTrail;

    void Update()
    {
        if (HelikopterAyari.TraileBasla)
        {
            if (Helikopter.TrailDegerligi == 0)
            {
                ilkTrail.SetActive(false);
                ikinciTrail.SetActive(false);
                ucuncuTrail.SetActive(false);
            }
            if (Helikopter.TrailDegerligi == 1)
            {
                ilkTrail.SetActive(true);
            }
            else if (Helikopter.TrailDegerligi == 2)
            {
                ikinciTrail.SetActive(true);
            }
            else if (Helikopter.TrailDegerligi == 3)
            {
                ucuncuTrail.SetActive(true);
            }
        }
    }

    void Start () {

        Helikopter.PervaneKaplamaDegerligi = PlayerPrefs.GetInt("Pervane");
        Helikopter.AltlikKaplamaDegerligi = PlayerPrefs.GetInt("Altlik");
        Helikopter.KuyrukKaplamaDegerligi = PlayerPrefs.GetInt("Kuyruk");

        Helikopter.TrailDegerligi = PlayerPrefs.GetInt("Trail");

        if (Helikopter.PervaneKaplamaDegerligi == 0)
        {
            Pervane.GetComponent<Renderer>().material = DefaultPervane;
        }
        else if (Helikopter.PervaneKaplamaDegerligi == 1)
        {
            Pervane.GetComponent<Renderer>().material = KirmiziPervane;
        }
        else if (Helikopter.PervaneKaplamaDegerligi == 2)
        {
            Pervane.GetComponent<Renderer>().material = YesilPervane;
        }
        else if (Helikopter.PervaneKaplamaDegerligi == 3)
        {
            Pervane.GetComponent<Renderer>().material = MaviPervane;
        }

        if (Helikopter.AltlikKaplamaDegerligi == 0)
        {
            AC1.GetComponent<Renderer>().material = DefaultAC123456;
            AC2.GetComponent<Renderer>().material = DefaultAC123456;
            AC3.GetComponent<Renderer>().material = DefaultAC123456;
            AC4.GetComponent<Renderer>().material = DefaultAC123456;
            AC5.GetComponent<Renderer>().material = DefaultAC123456;
            AC6.GetComponent<Renderer>().material = DefaultAC123456;
        }
        else if (Helikopter.AltlikKaplamaDegerligi == 1)
        {
            AC1.GetComponent<Renderer>().material = KirmiziAltlik;
            AC2.GetComponent<Renderer>().material = KirmiziAltlik;
            AC3.GetComponent<Renderer>().material = KirmiziAltlik;
            AC4.GetComponent<Renderer>().material = KirmiziAltlik;
            AC5.GetComponent<Renderer>().material = KirmiziAltlik;
            AC6.GetComponent<Renderer>().material = KirmiziAltlik;
        }
        else if (Helikopter.AltlikKaplamaDegerligi == 2)
        {
            AC1.GetComponent<Renderer>().material = YesilAltlik;
            AC2.GetComponent<Renderer>().material = YesilAltlik;
            AC3.GetComponent<Renderer>().material = YesilAltlik;
            AC4.GetComponent<Renderer>().material = YesilAltlik;
            AC5.GetComponent<Renderer>().material = YesilAltlik;
            AC6.GetComponent<Renderer>().material = YesilAltlik;
        }
        else if (Helikopter.AltlikKaplamaDegerligi == 3)
        {
            AC1.GetComponent<Renderer>().material = MaviAltlik;
            AC2.GetComponent<Renderer>().material = MaviAltlik;
            AC3.GetComponent<Renderer>().material = MaviAltlik;
            AC4.GetComponent<Renderer>().material = MaviAltlik;
            AC5.GetComponent<Renderer>().material = MaviAltlik;
            AC6.GetComponent<Renderer>().material = MaviAltlik;
        }

        if (Helikopter.KuyrukKaplamaDegerligi == 0)
        {
            Kuyruk.GetComponent<Renderer>().material = DefaultKuyruk;
        }
        else if (Helikopter.KuyrukKaplamaDegerligi == 1)
        {
            Kuyruk.GetComponent<Renderer>().material = KirmiziKuyruk;
        }
        else if (Helikopter.KuyrukKaplamaDegerligi == 2)
        {
            Kuyruk.GetComponent<Renderer>().material = YesilKuyruk;
        }
        else if (Helikopter.KuyrukKaplamaDegerligi == 3)
        {
            Kuyruk.GetComponent<Renderer>().material = MaviKuyruk;
        }

    }
}
