using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OyuncuAyar : MonoBehaviour
{
    public string AnaMenuAd;

    public static int ReklamGosterimSayisi;

    public static bool OyunDalgaDevamSesArttir;
    public static bool OyunDevamSesArttir;

    public static bool IkinciDalgaGucu;
    public static bool BesinciDalgaGucu;

    public static int KalanHak;

    public static bool HelikopterYanma;

    public static bool DalgaYandi;

    public static bool PauseVar;

    public static int Skor;
    public static int ToplamSkor;
    public static int EnYuksekSkor;
    public static int EnYuksekSkorSonsuzMod;
    public static int ReklamGosterim;

    public static int Para;
    public static int ToplamPara;

    public static bool DurdurmaMenusu;
    public static bool DurdurmayaBasincaSayacDur;
    public static bool OyunBitti;

    public static bool IkinciEngelGeliyor;
    public static bool YeniDalga;

    public static bool isiklarSonsun;
    public static bool DurdurulmaHareket;
    public static bool DurdurulmaPervane;

    public static bool ArkaPlanRengiDegis;

    public static bool YolEngelineBasla;

    public static bool ReklamiGoster;

    bool ReklamInvoke;

    float GeriSayim;

    public static int BirinciBolumOyuncuKacinciDalgadaKaldi,BolumTamamlandi;
    public Transform Helikopter;

    void Start()
    {
        OyunDalgaDevamSesArttir = false;
        OyunDevamSesArttir = false;

        KalanHak = 3;

        IkinciDalgaGucu = false;
        BesinciDalgaGucu = false;

        HelikopterYanma = false;

        DalgaYandi = false;

        PauseVar = true;

        Skor = 0;
        Para = 0;

        GeriSayim = 3.0f;

        YolEngelineBasla = false;
        ArkaPlanRengiDegis = false;
        YeniDalga = false;
        DurdurulmaHareket = false;
        DurdurulmaPervane = false;
        isiklarSonsun = false;
        IkinciEngelGeliyor = false;
        DurdurmayaBasincaSayacDur = false;
        DurdurmaMenusu = false;
        OyunBitti = false;

        ReklamInvoke = true;

        EnYuksekSkor = PlayerPrefs.GetInt("EnYuksekSkor");
        EnYuksekSkorSonsuzMod = PlayerPrefs.GetInt("EnYuksekSkorSonsuzMod");
    }
    void Update()
    {

        if (Helikopter.transform.position.x < 900)
        {
            BirinciBolumOyuncuKacinciDalgadaKaldi = 1;
            PlayerPrefs.SetInt("BirinciBolumKacinciDalgadaKaldi", BirinciBolumOyuncuKacinciDalgadaKaldi);
        }
        else if (Helikopter.transform.position.x >= 900 && Helikopter.transform.position.x < 1780)
        {
            BirinciBolumOyuncuKacinciDalgadaKaldi = 2;
            PlayerPrefs.SetInt("BirinciBolumKacinciDalgadaKaldi", BirinciBolumOyuncuKacinciDalgadaKaldi);
        }
        else if (Helikopter.transform.position.x >= 1780 && Helikopter.transform.position.x < 2490)
        {
            BirinciBolumOyuncuKacinciDalgadaKaldi = 3;
            PlayerPrefs.SetInt("BirinciBolumKacinciDalgadaKaldi", BirinciBolumOyuncuKacinciDalgadaKaldi);
        }
        else if (Helikopter.transform.position.x >= 2490 && Helikopter.transform.position.x < 3090)
        {
            BirinciBolumOyuncuKacinciDalgadaKaldi = 4;
            PlayerPrefs.SetInt("BirinciBolumKacinciDalgadaKaldi", BirinciBolumOyuncuKacinciDalgadaKaldi);
        }
        else if (Helikopter.transform.position.x >= 3090)
        {
            BirinciBolumOyuncuKacinciDalgadaKaldi = 5;
            PlayerPrefs.SetInt("BirinciBolumKacinciDalgadaKaldi", BirinciBolumOyuncuKacinciDalgadaKaldi);
        }

        if (Helikopter.transform.position.x > 3975)
        {
            BolumTamamlandi = 1;
            PlayerPrefs.SetInt("BolumTamamlandi", BolumTamamlandi);
        }



        ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");
        ToplamPara = PlayerPrefs.GetInt("ToplamPara");
        ReklamGosterim = PlayerPrefs.GetInt("ReklamGosterim");

        if (ReklamGosterim == 5)
        {
            ReklamGosterim -= 4;
            PlayerPrefs.SetInt("ReklamGosterim", ReklamGosterim);
        }

        if (!OyunBitti)
        {
            // ReklamInvoke = true;
        }

        if (OyunBitti)
        {
            if (ReklamInvoke)
            {
                if (GeriSayim > 0.0f)
                {
                    GeriSayim -= Time.unscaledDeltaTime;
                }
                if (GeriSayim < 0.75f)
                {
                    Invoke("ReklamGoster",0);
                    ReklamGosterim += 1;
                    PlayerPrefs.SetInt("ReklamGosterim", ReklamGosterim);
                    ReklamInvoke = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(AnaMenuAd);
            }
        }
        if (DurdurmaMenusu)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(AnaMenuAd);
            }
        }
    }
   public void ReklamGoster()
    {
        ReklamiGoster = true;
        GeriSayim = 3.0f;
    }
}
