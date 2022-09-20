using UnityEngine;
using System.Collections;

public class otoyol : MonoBehaviour
{
    public bool YolTemas;

    public static bool YoluUsteTasi;
    public static bool YoluAltaTasi;

    public bool YolTemasBitisi;

    public Transform YoluSec;

    public Transform ilkYol, ikinciYol, ucuncuYol;

    public Material[] BgMateryalleri;

    public Transform karakter;

    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;
    public GameObject BG4;
    public GameObject BG5;
    public GameObject BG6;

    public static bool BolumluMod;

    void Start()
    {
        YolTemas = false;
        YoluUsteTasi = false;
        YoluAltaTasi = false;
        YolTemasBitisi = false;
    }

    void Update()
    {
        if (YolTemas)
        {
         Invoke("YolAta", 0.0f);
         YolTemas = false;
        }

        if (BolumluMod) {
        if (karakter.transform.position.x > 1660 && karakter.transform.position.x < 1780)
        {
            YolTemasBitisi = true;
        }
        else if (karakter.transform.position.x >= 1780 && karakter.transform.position.x < 2330)
        {
            YolTemasBitisi = false;
        }
        else if (karakter.transform.position.x >= 2330 && karakter.transform.position.x <= 2480)
        {
            YolTemasBitisi = true;
        }
        else if (karakter.transform.position.x >= 2480)
        {
            YolTemasBitisi = false;
        }

        if (karakter.transform.position.x >= -500 && karakter.transform.position.x < 1740)
        {
            BG1.GetComponent<Renderer>().material = BgMateryalleri[0];
            BG2.GetComponent<Renderer>().material = BgMateryalleri[0];
            BG3.GetComponent<Renderer>().material = BgMateryalleri[0];
            BG4.GetComponent<Renderer>().material = BgMateryalleri[0];
            BG5.GetComponent<Renderer>().material = BgMateryalleri[0];
            BG6.GetComponent<Renderer>().material = BgMateryalleri[0];
        }
        else if (karakter.transform.position.x >= 1740 && karakter.transform.position.x < 2450)
        {
            BG1.GetComponent<Renderer>().material = BgMateryalleri[1];
            BG2.GetComponent<Renderer>().material = BgMateryalleri[1];
            BG3.GetComponent<Renderer>().material = BgMateryalleri[1];
            BG4.GetComponent<Renderer>().material = BgMateryalleri[1];
            BG5.GetComponent<Renderer>().material = BgMateryalleri[1];
            BG6.GetComponent<Renderer>().material = BgMateryalleri[1];
        }
        else if (karakter.transform.position.x >= 2450 && karakter.transform.position.x < 3275)
        {
            BG1.GetComponent<Renderer>().material = BgMateryalleri[2];
            BG2.GetComponent<Renderer>().material = BgMateryalleri[2];
            BG3.GetComponent<Renderer>().material = BgMateryalleri[2];
            BG4.GetComponent<Renderer>().material = BgMateryalleri[2];
            BG5.GetComponent<Renderer>().material = BgMateryalleri[2];
            BG6.GetComponent<Renderer>().material = BgMateryalleri[2];
        }
        else if (karakter.transform.position.x >= 3275)
        {
            BG1.GetComponent<Renderer>().material = BgMateryalleri[3];
            BG2.GetComponent<Renderer>().material = BgMateryalleri[3];
            BG3.GetComponent<Renderer>().material = BgMateryalleri[3];
            BG4.GetComponent<Renderer>().material = BgMateryalleri[3];
            BG5.GetComponent<Renderer>().material = BgMateryalleri[3];
            BG6.GetComponent<Renderer>().material = BgMateryalleri[3];
        }

        // x -> 1843.84f y -> 30.21f z -> 19  += 44.8
        if (YoluUsteTasi)
        {
            ilkYol.transform.position = new Vector3(1844.48f, 30.212f, 19);
            ikinciYol.transform.position = new Vector3(1889.28f, 30.212f, 19);
            ucuncuYol.transform.position = new Vector3(1934.08f, 30.212f, 19);
            YoluUsteTasi = false;
        }
        if (YoluAltaTasi)
        {
            ilkYol.transform.position = new Vector3(2505.7f, 6, 19);
            ikinciYol.transform.position = new Vector3(2550.5f, 6, 19);
            ucuncuYol.transform.position = new Vector3(2595.3f, 6, 19);
            YoluAltaTasi = false;
        }
        }
        else
        {
            if (karakter.transform.position.x >= -500 && karakter.transform.position.x < 250)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[0];
            }
            else if (karakter.transform.position.x >= 250 && karakter.transform.position.x < 750)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[1];
            }
            else if (karakter.transform.position.x >= 750 && karakter.transform.position.x < 1250)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[2];
            }
            else if (karakter.transform.position.x >= 1250 && karakter.transform.position.x < 1750)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[3];
            }
            else if (karakter.transform.position.x >= 1750 && karakter.transform.position.x < 2250)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[0];
            }
            else if (karakter.transform.position.x >= 2250 && karakter.transform.position.x < 2750)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[1];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[1];
            }
            else if (karakter.transform.position.x >= 2750 && karakter.transform.position.x < 3250)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[2];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[2];
            }
            else if (karakter.transform.position.x >= 3250 && karakter.transform.position.x < 3750)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[3];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[3];
            }
            else if (karakter.transform.position.x >= 3750 && karakter.transform.position.x < 4250)
            {
                BG1.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG2.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG3.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG4.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG5.GetComponent<Renderer>().material = BgMateryalleri[0];
                BG6.GetComponent<Renderer>().material = BgMateryalleri[0];
            }
        }
    }
    void YolAta()
    {
        if (!YolTemasBitisi) { 
        YoluSec.transform.localPosition = YoluSec.transform.position + new Vector3(134.42f, 0, 0); 
        }
        else
        {
        YoluSec.transform.localPosition = YoluSec.transform.position + new Vector3(0, 0, 0);
        }
  }
}