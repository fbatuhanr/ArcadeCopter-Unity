using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunlukBonusOdul : MonoBehaviour {


    public Text CarkAdiYazi, CarkiCevirYazi, CarkHakkiSatinAlYazi,BirGunBirSansYazi;

    public GameObject DondurmeButonu, ButonHakkiKalmadi;
    public Animator ButonTiklanamazAnim;
    
    public Button DondurmeButon, HakSatinAlButon;
    public Image DondurmeButonImg, HakAl;

    public GameObject KirmiziGovde, MaviGovde, YesilGovde;
    public GameObject KirmiziPervane, MaviPervane, YesilPervane;

    public GameObject KazanilanMaviTrail, KMT_Yazi;
    public GameObject KazanilanGOLD, KGold_Yazi;
    public GameObject KazanilanSkor, KSkor_Yazi;
    public GameObject KazanilanGovde, KazanilanGovdeKirmizi, KazanilanGovdeMavi, KazanilanGovdeYesil,KGovde_Yazi;
    public GameObject KazanilanPervane, KazanilanPervaneKirmizi, KazanilanPervaneMavi, KazanilanPervaneYesil,KPervane_Yazi;

    public Transform OyunAdiRotSifirla;

    public Text SatinAlArtiBir, SatinAlArti, SatinAlOnGold, KalanHak, KazanilanOge, Trail, Pervane, Govde, Gold1,Gold2,Gold3,Skor1,Skor2;
    public Text TrailKazanildi, KazanilanGoldYazi, KazanilanSkorYazi, KazanilanGovdeYazi, KazanilanPervaneYazi;

    public static string CarkName,CarkSpinCevir,CarkHakkiSatinAlBuy,BirGunOneDaySans,Kazandin_YouWin;

    public static int TarihGun, TarihAy, TarihYil;
    

    int ButonKullanimHakki;

    bool Kombinasyon1, Kombinasyon2, Kombinasyon3, Kombinasyon4;
    bool KirmiziGovdeTrue, MaviGovdeTrue, YesilGovdeTrue;
    bool KirmiziPervaneTrue, MaviPervaneTrue, YesilPervaneTrue;

    public static bool MagazadaGosterim, Yuzde2, Yuzde8, Yuzde5, Yuzde10_1, Yuzde10_2, Yuzde15, Yuzde25_1, Yuzde25_2;

    float sayiyor,ButonEtkinSure;
    bool CarkButonuClick;
    public void CarkButonuTiklama()
    {
        CarkButonuClick = true;
        ButonTiklanamazAnim.Play("DailyRewardButon", -1, 0f);
    }

	void Start () {
        
        sayiyor = 1.5f;
        ButonEtkinSure = 4.0f;

        CarkButonuClick = false;

        TarihAy = PlayerPrefs.GetInt("OyunaIlkGirilisAyi");
        TarihGun = PlayerPrefs.GetInt("OyunaIlkGirilisGunu");
        TarihYil = PlayerPrefs.GetInt("OyunaIlkGirilisYili");
        ButonKullanimHakki = PlayerPrefs.GetInt("SaatYonuDondurmeHakki");

        KirmiziGovde.SetActive(false);
        MaviGovde.SetActive(false);
        YesilGovde.SetActive(false);

        KirmiziPervane.SetActive(false);
        MaviPervane.SetActive(false);
        YesilPervane.SetActive(false);

        if (MagazadaGosterim)
        {
            if (OyunAdiRotSifirla.localEulerAngles.z > 0)
            {
                OyunAdiRotSifirla.Rotate(0, 0, -2.15f);
            }

            int RandomGovde = Random.Range(0, 3);
            if (RandomGovde == 0)
            {
                KirmiziGovde.SetActive(true);
                MaviGovde.SetActive(false);
                YesilGovde.SetActive(false);

                KirmiziGovdeTrue = true;
                MaviGovdeTrue = false;
                YesilGovdeTrue = false;
            }
            else if (RandomGovde == 1)
            {
                KirmiziGovde.SetActive(false);
                MaviGovde.SetActive(true);
                YesilGovde.SetActive(false);

                KirmiziGovdeTrue = false;
                MaviGovdeTrue = true;
                YesilGovdeTrue = false;
            }
            else if (RandomGovde == 2)
            {
                KirmiziGovde.SetActive(false);
                MaviGovde.SetActive(false);
                YesilGovde.SetActive(true);

                KirmiziGovdeTrue = false;
                MaviGovdeTrue = false;
                YesilGovdeTrue = true;
            }

            int RandomPervane = Random.Range(0, 3);
            if (RandomPervane == 0)
            {
                KirmiziPervane.SetActive(true);
                MaviPervane.SetActive(false);
                YesilPervane.SetActive(false);

                KirmiziPervaneTrue = true;
                MaviPervaneTrue = false;
                YesilPervaneTrue = false;
            }
            else if (RandomPervane == 1)
            {
                KirmiziPervane.SetActive(false);
                MaviPervane.SetActive(true);
                YesilPervane.SetActive(false);

                KirmiziPervaneTrue = false;
                MaviPervaneTrue = true;
                YesilPervaneTrue = false;
            }
            else if (RandomPervane == 2)
            {
                KirmiziPervane.SetActive(false);
                MaviPervane.SetActive(false);
                YesilPervane.SetActive(true);

                KirmiziPervaneTrue = false;
                MaviPervaneTrue = false;
                YesilPervaneTrue = true;
            }

            int RandomGoldSkor = Random.Range(0, 4);
            if (RandomGoldSkor == 0)
            {
                Kombinasyon1 = true;
                Kombinasyon2 = false;
                Kombinasyon3 = false;
                Kombinasyon4 = false;
            }
            else if (RandomGoldSkor == 1)
            {
                Kombinasyon1 = false;
                Kombinasyon2 = true;
                Kombinasyon3 = false;
                Kombinasyon4 = false;
            }
            else if (RandomGoldSkor == 2)
            {
                Kombinasyon1 = false;
                Kombinasyon2 = false;
                Kombinasyon3 = true;
                Kombinasyon4 = false;
            }
            else if (RandomGoldSkor == 3)
            {
                Kombinasyon1 = false;
                Kombinasyon2 = false;
                Kombinasyon3 = false;
                Kombinasyon4 = true;
            }

            if (System.DateTime.Now.Day > TarihGun && System.DateTime.Now.Month >= TarihAy)
            {

                if (OyunAdiRotSifirla.localEulerAngles.z > 0)
                {
                    OyunAdiRotSifirla.Rotate(0, 0, -2.15f);
                }

                TarihAy = System.DateTime.Now.Month;
                TarihGun = System.DateTime.Now.Day;
                TarihYil = System.DateTime.Now.Year;

                PlayerPrefs.SetInt("OyunaIlkGirilisAyi", TarihAy);
                PlayerPrefs.SetInt("OyunaIlkGirilisGunu", TarihGun);
                PlayerPrefs.SetInt("OyunaIlkGirilisYili", TarihYil);

                ButonKullanimHakki += 1;
                PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);
            }
            else
            {
                if (System.DateTime.Now.Month > TarihAy && System.DateTime.Now.Year >= TarihYil)
                {
                    if (OyunAdiRotSifirla.localEulerAngles.z > 0)
                    {
                        OyunAdiRotSifirla.Rotate(0, 0, -2.15f);
                    }

                    TarihAy = System.DateTime.Now.Month;
                    TarihGun = System.DateTime.Now.Day;
                    TarihYil = System.DateTime.Now.Year;

                    PlayerPrefs.SetInt("OyunaIlkGirilisAyi", TarihAy);
                    PlayerPrefs.SetInt("OyunaIlkGirilisGunu", TarihGun);
                    PlayerPrefs.SetInt("OyunaIlkGirilisYili", TarihYil);

                    ButonKullanimHakki += 1;
                    PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);
                }
                else
                {

                    if (System.DateTime.Now.Year > TarihYil)
                    {
                        if (OyunAdiRotSifirla.localEulerAngles.z > 0)
                        {
                            OyunAdiRotSifirla.Rotate(0, 0, -2.15f);
                        }

                        TarihAy = System.DateTime.Now.Month;
                        TarihGun = System.DateTime.Now.Day;
                        TarihYil = System.DateTime.Now.Year;

                        PlayerPrefs.SetInt("OyunaIlkGirilisAyi", TarihAy);
                        PlayerPrefs.SetInt("OyunaIlkGirilisGunu", TarihGun);
                        PlayerPrefs.SetInt("OyunaIlkGirilisYili", TarihYil);

                        ButonKullanimHakki += 1;
                        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);
                    }
                    else
                    {
                        if (OyunAdiRotSifirla.localEulerAngles.z < 2.15f)
                        {
                            OyunAdiRotSifirla.Rotate(0, 0, +2.15f);
                        }
                    }
                }
            }
        }
    }

    public void BaslikRotateNormalize()
    {
        if (OyunAdiRotSifirla.localEulerAngles.z < 2.15f)
        {
            OyunAdiRotSifirla.Rotate(0, 0, +2.15f);
        }  
    }

    public void DondurmeHakSatinAl()
    {
        if (OyuncuAyar.ToplamPara >= 15)
        {    
            OyuncuAyar.ToplamPara -= 25;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            ButonKullanimHakki += 1;
            PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);
        }
        else
        {
            sayiyor = 1.5f;
            HakAl.color = Color.red;
        }
    }

    void Update()
    {
        OyuncuAyar.ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");
        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");
        ButonKullanimHakki = PlayerPrefs.GetInt("SaatYonuDondurmeHakki");

        Time.timeScale = 1;


        DondurmeButon.enabled = true;

        if (ButonKullanimHakki > 0)
        {
            ButonHakkiKalmadi.SetActive(false);
        }
        else
        {
            ButonHakkiKalmadi.SetActive(true);
        }

        if (CarkButonuClick)
        {
            if (ButonEtkinSure > 0)
            {
                ButonEtkinSure -= Time.deltaTime;
            }
            if (ButonEtkinSure > 0.1f)
            {  
                DondurmeButon.interactable = false;
            }
            if (ButonEtkinSure <= 0.1f && ButonKullanimHakki > 0)
            {
                DondurmeButon.interactable = true;
                CarkButonuClick = false;
            }
            else
            {
                DondurmeButon.interactable = false;
            }
        }
        else
        {
            ButonEtkinSure = 4.0f;
        }

        if (OyuncuAyar.ToplamPara >= 15)
        {

            HakAl.color = Color.white;
        }
        else
        {
            if (sayiyor > 0)
            {
                sayiyor -= Time.deltaTime;
            }
            if (sayiyor <= 0.1f)
            {
                HakAl.color = Color.white;
            }

        }

        CarkAdiYazi.text = CarkName;
        CarkiCevirYazi.text = CarkSpinCevir;
        CarkHakkiSatinAlYazi.text = CarkHakkiSatinAlBuy;
        BirGunBirSansYazi.text = BirGunOneDaySans;
        
        CarkAdiYazi.fontSize = Screen.width / 34;
        CarkiCevirYazi.fontSize = Screen.width / 48;
        CarkHakkiSatinAlYazi.fontSize = Screen.width / 48;
        BirGunBirSansYazi.fontSize = Screen.width / 56;

        KalanHak.text = ButonKullanimHakki.ToString();
        KalanHak.fontSize = Screen.width / 30;
        SatinAlArtiBir.fontSize = Screen.width / 16;
        SatinAlArti.fontSize = Screen.width / 16;
        SatinAlOnGold.fontSize = Screen.width / 16;

        Trail.text = Magaza.Mavi_TrailIz;
        TrailKazanildi.text = Magaza.Mavi_TrailIz;
        KazanilanOge.text = Kazandin_YouWin;

        KazanilanOge.fontSize = Screen.width / 32;

        if (KirmiziPervaneTrue)
        {
            Pervane.text = Magaza.KirmiziRed_Pervane;
        }
        else if (MaviPervaneTrue)
        {
            Pervane.text = Magaza.MaviBlue_Pervane;
        }
        else if (YesilPervaneTrue)
        {
            Pervane.text = Magaza.YesilGreen_Pervane;
        }

        if (KirmiziGovdeTrue)
        {
            Govde.text = Magaza.KirmiziRed_Govde;
        }
        else if (MaviGovdeTrue)
        {
            Govde.text = Magaza.MaviBlue_Govde;
        }
        else if (YesilGovdeTrue)
        {
            Govde.text = Magaza.YesilGreen_Govde;
        }

        Trail.fontSize = Screen.width / 82;
        Pervane.fontSize = Screen.width / 88;
        Govde.fontSize = Screen.width / 82;

        Gold1.fontSize = Screen.width / 45;
        Gold2.fontSize = Screen.width / 45;
        Gold3.fontSize = Screen.width / 45;

        Skor1.fontSize = Screen.width / 45;
        Skor2.fontSize = Screen.width / 45;

        if (Kombinasyon1)
        {
            Gold1.text = "5";
            Gold2.text = "10";
            Gold3.text = "15";

            Skor1.text = "5";
            Skor2.text = "10";
        }
        else if (Kombinasyon2)
        {
            Gold1.text = "10";
            Gold2.text = "15";
            Gold3.text = "5";

            Skor1.text = "5";
            Skor2.text = "10";
        }
        else if (Kombinasyon3)
        {
            Gold1.text = "15";
            Gold2.text = "10";
            Gold3.text = "5";

            Skor1.text = "10";
            Skor2.text = "5";
        }
        else if (Kombinasyon4)
        {
            Gold1.text = "5";
            Gold2.text = "15";
            Gold3.text = "10";

            Skor1.text = "10";
            Skor2.text = "5";
        }

        TrailKazanildi.fontSize = Screen.width / 75;
        KazanilanGoldYazi.fontSize = Screen.width / 30;
        KazanilanSkorYazi.fontSize = Screen.width / 30;
        KazanilanGovdeYazi.fontSize = Screen.width / 75;
        KazanilanPervaneYazi.fontSize = Screen.width / 75;


        if (Yuzde2)
        {
            Invoke("Yuzde2_Trail",0);        
            Yuzde2 = false;
        }
        else if (Yuzde8)
        {
            Invoke("Yuzde8_Pervane",0);
            Yuzde8 = false;
        }
        else if (Yuzde10_1)
        {
            Invoke("Yuzde10_Gold_1",0);
            Yuzde10_1 = false;
        }
        else if (Yuzde25_1)
        {
            Invoke("Yuzde25_Skor",0);
            Yuzde25_1 = false;
        }
        else if (Yuzde5)
        {
            Invoke("Yuzde5_Govde",0);
            Yuzde5 = false;
        }
        else if (Yuzde10_2)
        {
            Invoke("Yuzde10_Gold",0);
            Yuzde10_2 = false;
        }
        else if (Yuzde15)
        {
            Invoke("Yuzde15_Skor", 0);
            Yuzde15 = false;
        }
        else if (Yuzde25_2)
        {
            Invoke("Yuzde25_Gold",0);
            Yuzde25_2 = false;
        }
    }
    void Yuzde2_Trail()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(true);
        KMT_Yazi.SetActive(true);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(false);
        KGold_Yazi.SetActive(false);

        Helikopter.TrailSatinAlindi3 = 1;
        PlayerPrefs.SetInt("TrailSatinAlindi3", Helikopter.TrailSatinAlindi3);
    }
    void Yuzde8_Pervane()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(true);
        KPervane_Yazi.SetActive(true);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(false);
        KGold_Yazi.SetActive(false);

        if (KirmiziPervaneTrue)
        {
            KazanilanPervaneYazi.text = Magaza.KirmiziRed_Pervane;

            KazanilanPervaneKirmizi.SetActive(true);
            Helikopter.PervaneSatinAlindi1 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi1", Helikopter.PervaneSatinAlindi1);
        }
        else if (MaviPervaneTrue)
        {
            KazanilanPervaneYazi.text = Magaza.MaviBlue_Pervane;

            KazanilanPervaneMavi.SetActive(true);
            Helikopter.PervaneSatinAlindi3 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi3", Helikopter.PervaneSatinAlindi3);
        }
        else if (YesilPervaneTrue)
        {
            KazanilanPervaneYazi.text = Magaza.YesilGreen_Pervane;

            KazanilanPervaneYesil.SetActive(true);
            Helikopter.PervaneSatinAlindi2 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi2", Helikopter.PervaneSatinAlindi2);
        }
    }
    void Yuzde10_Gold_1()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(true);
        KGold_Yazi.SetActive(true);

        if (Gold2.text == "10")
        {
            KazanilanGoldYazi.text = "10";
            OyuncuAyar.ToplamPara += 10;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
        else if (Gold2.text == "15")
        {
            KazanilanGoldYazi.text = "15";
            OyuncuAyar.ToplamPara += 15;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
    }
    void Yuzde5_Govde()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(true);
        KGovde_Yazi.SetActive(true);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(false);
        KGold_Yazi.SetActive(false);

        if (KirmiziGovdeTrue)
        {
            KazanilanGovdeYazi.text = Magaza.KirmiziRed_Govde;

            KazanilanGovdeKirmizi.SetActive(true);
            Helikopter.GovdeSatinAlindi1 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi1", Helikopter.GovdeSatinAlindi1);
        }
        else if (MaviGovdeTrue)
        {
            KazanilanGovdeYazi.text = Magaza.MaviBlue_Govde;

            KazanilanGovdeMavi.SetActive(true);
            Helikopter.GovdeSatinAlindi3 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi3", Helikopter.GovdeSatinAlindi3);
        }
        else if (YesilGovdeTrue)
        {
            KazanilanGovdeYazi.text = Magaza.YesilGreen_Govde;

            KazanilanGovdeYesil.SetActive(true);
            Helikopter.GovdeSatinAlindi2 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi2", Helikopter.GovdeSatinAlindi2);
        }
    }
    void Yuzde10_Gold()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(true);
        KGold_Yazi.SetActive(true);

        if (Gold3.text == "5")
        {
            KazanilanGoldYazi.text = "5";
            OyuncuAyar.ToplamPara += 5;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
        else if (Gold3.text == "10")
        {
            KazanilanGoldYazi.text = "10";
            OyuncuAyar.ToplamPara += 10;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
        else if (Gold3.text == "15")
        {
            KazanilanGoldYazi.text = "15";
            OyuncuAyar.ToplamPara += 15;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
    }
    void Yuzde15_Skor()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(true);
        KSkor_Yazi.SetActive(true);

        KazanilanGOLD.SetActive(false);
        KGold_Yazi.SetActive(false);

        if (Skor2.text == "5")
        {
            KazanilanSkorYazi.text = "5";
            OyuncuAyar.ToplamSkor += 5;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);
        }
        else if (Skor2.text == "10")
        {
            KazanilanSkorYazi.text = "10";
            OyuncuAyar.ToplamSkor += 10;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);
        }
    }
    void Yuzde25_Gold()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(false);
        KSkor_Yazi.SetActive(false);

        KazanilanGOLD.SetActive(true);
        KGold_Yazi.SetActive(true);

        if (Gold1.text == "5")
        {
            KazanilanGoldYazi.text = "5";
            OyuncuAyar.ToplamPara += 5;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
        else if (Gold1.text == "10")
        {
            KazanilanGoldYazi.text = "10";
            OyuncuAyar.ToplamPara += 10;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
        else if (Gold1.text == "15")
        {
            KazanilanGoldYazi.text = "15";
            OyuncuAyar.ToplamPara += 15;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
        }
    }
    void Yuzde25_Skor()
    {
        ButonKullanimHakki -= 1;
        PlayerPrefs.SetInt("SaatYonuDondurmeHakki", ButonKullanimHakki);

        KazanilanMaviTrail.SetActive(false);
        KMT_Yazi.SetActive(false);

        KazanilanPervane.SetActive(false);
        KPervane_Yazi.SetActive(false);

        KazanilanGovde.SetActive(false);
        KGovde_Yazi.SetActive(false);

        KazanilanSkor.SetActive(true);
        KSkor_Yazi.SetActive(true);

        KazanilanGOLD.SetActive(false);
        KGold_Yazi.SetActive(false);

        if (Skor1.text == "5")
        {
            KazanilanSkorYazi.text = "5";
            OyuncuAyar.ToplamSkor += 5;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);
        }
        else if (Skor1.text == "10")
        {
            KazanilanSkorYazi.text = "10";
            OyuncuAyar.ToplamSkor += 10;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);
        }
    }
}
