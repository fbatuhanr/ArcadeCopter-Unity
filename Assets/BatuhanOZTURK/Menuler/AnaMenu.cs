using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenu : MonoBehaviour
{
    public Text OynaYazi, MagazaYazi, AyarlarYazi;
    public AudioSource AnaMenuBGSound;
    public GameObject DefaultGovde, KirmiziGovde, YesilGovde, MaviGovde;
    public static bool GunlukGiris;
    public Image BG;
    Color Koyulastir;
    bool Oyna, Ayar, MagazaShop;

    public Text oyunAdi,CikmakIcinBidahaBas;
    public GameObject CikmakIcinYazi,Trail1,Trail2,Trail3;

    public GUIStyle EnYuksekSkor, EnYuksekSkorBG;

    public GUIStyle Para, ParaBG;

    public GUIStyle ToplamSkor,ToplamSkorBG;

    public GUIStyle PlayBG, AyarBG, ShopBG;

    public string NewGame;
    public string SettingsMenu;
    public string PlayMenu;
    public string MagazaMenu;

    public static string OynaPlayYazi, MagazaShopYazi, AyarlarSettingsYazi;
    public static string Para_Money;
    public static string ToplamSkor_TotalScore;
    public static string EnYuksekSkor_BestScore;

    public static string CikisYazisi;

    public static int OyunaIlkGiris;

    float ParaKonumOrani;

    bool CikisEmin;

    bool GeriSayimaBasla;
    float Gerisayim;

    int Sayac;

    void Start()
    {
        // ReklamAyar.BannerReklamGoster();

        Gerisayim = 3.2f;
        CikmakIcinYazi.SetActive(false);
        Sayac = 0;
        GeriSayimaBasla = false;

        Oyna = false;
        Ayar = false;
        MagazaShop = false;

        CikisEmin = false;

        Koyulastir = new Vector4(0, 0, 0, 0.02f);

        OyunaIlkGiris = PlayerPrefs.GetInt("OyunaIlkGiris");

        if (OyunaIlkGiris == 0)
        {
            Magaza.TouchAnimOlayi = 0;
            PlayerPrefs.SetInt("MagazaTouchAnimi", Magaza.TouchAnimOlayi);

            OyunaIlkGiris = 1;
            PlayerPrefs.SetInt("OyunaIlkGiris", OyunaIlkGiris);
        }
        else
        {
            Magaza.TouchAnimOlayi = 1;
            PlayerPrefs.SetInt("MagazaTouchAnimi", Magaza.TouchAnimOlayi);
        }

        AyarlarMenu.DilAyari = PlayerPrefs.GetInt("DilAyari");

        HelikopterAyari.TraileBasla = true;

        GunlukBonusOdul.MagazadaGosterim = false;

        AnaMenuBGSound.volume = 0;

        Helikopter.GovdeKaplamaDegerligi = PlayerPrefs.GetInt("Govde");
        if (Helikopter.GovdeKaplamaDegerligi == 0)
        {
            DefaultGovde.SetActive(true);
        }
        else if (Helikopter.GovdeKaplamaDegerligi == 1)
        {
            KirmiziGovde.SetActive(true);
        }
        else if (Helikopter.GovdeKaplamaDegerligi == 2)
        {
            YesilGovde.SetActive(true);
        }
        else if (Helikopter.GovdeKaplamaDegerligi == 3)
        {
            MaviGovde.SetActive(true);
        }


        AyarlarMenu.MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");
        if (AyarlarMenu.MuteMuzik == 0)
        {
            AnaMenuBGSound.Play();
        }
        else
        {
            AnaMenuBGSound.Stop();
        }
    }

    void Update()
    {
        if (AyarlarMenu.MuteMuzik == 0) {
        if (AnaMenuBGSound.volume < 1.0f && !Oyna && !Ayar && !MagazaShop)
        {
                AnaMenuBGSound.volume += 0.005f;
        }
        }
        else
        {
            AnaMenuBGSound.volume = 0;
        }

        Time.timeScale = 1;

        OyunaIlkGiris = 1;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GeriSayimaBasla = true;
            Sayac += 1;              
        }

        OyuncuAyar.EnYuksekSkor = PlayerPrefs.GetInt("EnYuksekSkor");
        OyuncuAyar.EnYuksekSkorSonsuzMod = PlayerPrefs.GetInt("EnYuksekSkorSonsuzMod");
        OyuncuAyar.ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");
        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");

        if (GeriSayimaBasla) {
            if (Gerisayim > 0.0f)
            {
                Gerisayim -= Time.deltaTime;
            }
            if (Gerisayim >= 0.2f)
            {
                CikmakIcinYazi.SetActive(true);
                if (Sayac == 2)
                {
                    Application.Quit();
                }
            }
            else
            {
                GeriSayimaBasla = false;
                Sayac = 0;
                Gerisayim = 3.2f;
                CikmakIcinYazi.SetActive(false);
            }
        }

        OynaYazi.text = OynaPlayYazi;
        MagazaYazi.text = MagazaShopYazi;
        AyarlarYazi.text = AyarlarSettingsYazi;

        OynaYazi.fontSize = Screen.width / 40;
        MagazaYazi.fontSize = Screen.width / 40;
        AyarlarYazi.fontSize = Screen.width / 40;

        oyunAdi.fontSize = Screen.width / 20;

        CikmakIcinBidahaBas.fontSize = Screen.width / 21;
        CikmakIcinBidahaBas.text = CikisYazisi;

        EnYuksekSkor.fontSize = Screen.width / 22;
        ToplamSkor.fontSize = Screen.width / 20;
        Para.fontSize = Screen.width / 20;

        if (AyarlarMenu.DilAyari == 0)
        {
            if (OyuncuAyar.ToplamPara.ToString().Length == 1)
            {
                ParaKonumOrani = 0.75f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 2)
            {
                ParaKonumOrani = 0.72f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 3)
            {
                ParaKonumOrani = 0.68f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 4)
            {
                ParaKonumOrani = 0.64f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 5)
            {
                ParaKonumOrani = 0.6f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 6)
            {
                ParaKonumOrani = 0.56f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 7)
            {
                ParaKonumOrani = 0.52f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 8)
            {
                ParaKonumOrani = 0.48f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 9)
            {
                ParaKonumOrani = 0.44f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 10)
            {
                ParaKonumOrani = 0.4f;
            }
        }
        else if (AyarlarMenu.DilAyari == 1)
        {
            if (OyuncuAyar.ToplamPara.ToString().Length == 1)
            {
                ParaKonumOrani = 0.68f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 2)
            {
                ParaKonumOrani = 0.65f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 3)
            {
                ParaKonumOrani = 0.61f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 4)
            {
                ParaKonumOrani = 0.57f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 5)
            {
                ParaKonumOrani = 0.53f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 6)
            {
                ParaKonumOrani = 0.49f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 7)
            {
                ParaKonumOrani = 0.45f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 8)
            {
                ParaKonumOrani = 0.41f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 9)
            {
                ParaKonumOrani = 0.37f;
            }
            else if (OyuncuAyar.ToplamPara.ToString().Length == 10)
            {
                ParaKonumOrani = 0.335f;
            }
        }

        if (Oyna)
        {
            BG.color += Koyulastir;
            if (AnaMenuBGSound.volume > 0.0f)
            {
                AnaMenuBGSound.volume -= 0.02f;
            }
            if (BG.color.a >= 1)
            {
                SceneManager.LoadScene(PlayMenu);
            }
        }
        if (Ayar)
        {
            BG.color += Koyulastir;
            if (AnaMenuBGSound.volume > 0.0f)
            {
                AnaMenuBGSound.volume -= 0.02f;
            }
            if (BG.color.a >= 1)
            {
                SceneManager.LoadScene(SettingsMenu);
            }
        }
        if (MagazaShop)
        {
            BG.color += Koyulastir;
            if (AnaMenuBGSound.volume > 0.0f)
            {
                AnaMenuBGSound.volume -= 0.02f;
            }
            if (BG.color.a >= 1)
            {
                SceneManager.LoadScene(MagazaMenu);
            }
        }


    }

    void OnGUI()
    {
        if (!GeriSayimaBasla) {
        GUI.Box(Fonksiyonlar.EkranBoyut(0.988f, 0.95f, 0, 0), Para_Money + OyuncuAyar.ToplamPara.ToString(), Para);
        GUI.Box(Fonksiyonlar.EkranBoyut(ParaKonumOrani, 0.96f, 0.045f, 0.075f), "", ParaBG);

        GUI.Box(Fonksiyonlar.EkranBoyut(-0.89f, 0.95f, 0, 0), ToplamSkor_TotalScore + OyuncuAyar.ToplamSkor.ToString(), ToplamSkor);
        GUI.Box(Fonksiyonlar.EkranBoyut(-0.9f, 0.96f, 0.045f, 0.075f), "", ToplamSkorBG);

        GUI.Box(Fonksiyonlar.EkranBoyut(0.19f, 0.997f, 0.1f, 0.12f), "", EnYuksekSkorBG);

            if (OyuncuAyar.EnYuksekSkor > OyuncuAyar.EnYuksekSkorSonsuzMod) {
          GUI.Box(Fonksiyonlar.EkranBoyut(-0.09f, 0.942f, 0, 0), ": " + OyuncuAyar.EnYuksekSkor.ToString(), EnYuksekSkor);
            }
            else
            {
                GUI.Box(Fonksiyonlar.EkranBoyut(-0.09f, 0.942f, 0, 0), ": " + OyuncuAyar.EnYuksekSkorSonsuzMod.ToString(), EnYuksekSkor);
            }
            if (!GunlukGiris) {
            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.6f, -0.2f, 0.12f, 0.21f), "", PlayBG))
            {Oyna = true;}
            if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.365f, -0.2f, 0.12f, 0.21f), "", AyarBG))
            {Ayar = true;}
            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.12f, -0.3f, 0.12f, 0.21f), "", ShopBG))
            {MagazaShop = true;}
            }
        }

    }
}
    