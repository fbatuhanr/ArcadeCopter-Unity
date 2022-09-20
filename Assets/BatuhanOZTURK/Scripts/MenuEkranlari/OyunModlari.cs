using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunModlari : MonoBehaviour {

    public GUIStyle AnaMenuDonus;

    public GameObject Bolum1Tamamlandimi, Bolum1, Bolum2;
    public Image BolumButon1, BolumButon2, BolumButon3, BolumButon4, BolumButon5, BolumlerDevamiButon;

    Color Gri = new Vector4(0.75f, 0.75f, 0.75f, 1);

    public Text Bolum1TamamlandimiText ,BolumKacYazi, Bolum1ButonYazi, Bolum2ButonYazi, Bolum3ButonYazi, Bolum4ButonYazi, Bolum5ButonYazi;
    public static string BolumChapter_Yazisi;

    public Text SonsuzOynamakIcinTiklaYazisi;
    public Text YakindaYazisi;

    public static string Bolum_Chapter_Play;
    public static string Sinirsiz_Limitless_Play;
    public static string Yakinda_ComingSoon;

    public static string BolumKac_Yazi1, BolumKac_Yazi2, BolumKac_Yazi3, BolumKac_Yazi4, BolumKac_Yazi5, BolumKac_YaziSoruIsareti;

    public string AnaMenuIsmi;
    public string YuklemeEkrani;

    public GUIStyle SonsuzModSkor, GelinenDalga;

    public static string SonsuzMod_SkorScore, BolumTamamlandi_Completed;
    public static string Gelinen_DalgaWave, DalgaSkor_Score;

    bool Yep;

	void Start () {

        // ReklamAyar.BannerReklamGizle();

        Yep = true;

        Bolum1.SetActive(true);
        Bolum2.SetActive(false);   

        BolumButon1.color = Color.white;
        BolumButon2.color = Gri;
        BolumButon3.color = Gri;
        BolumButon4.color = Gri;
        BolumButon5.color = Gri;
        BolumlerDevamiButon.color = Gri; 
    }
    void Yepyep()
    {
        BolumKacYazi.text = BolumKac_Yazi1;
    }
	
	void Update () {
        Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(AnaMenuIsmi);
        }

        if (Yep)
        {
            Invoke("Yepyep",0);
            Yep = false;
        }

        AyarlarMenu.DilAyari = PlayerPrefs.GetInt("DilAyari");
        OyuncuAyar.EnYuksekSkorSonsuzMod = PlayerPrefs.GetInt("EnYuksekSkorSonsuzMod");

        OyuncuAyar.BirinciBolumOyuncuKacinciDalgadaKaldi = PlayerPrefs.GetInt("BirinciBolumKacinciDalgadaKaldi");
        OyuncuAyar.BolumTamamlandi = PlayerPrefs.GetInt("BolumTamamlandi");

        if (AyarlarMenu.DilAyari == 0)
        {
            Bolum1ButonYazi.text = "1." + BolumChapter_Yazisi;
            Bolum2ButonYazi.text = "2." + BolumChapter_Yazisi;
            Bolum3ButonYazi.text = "3." + BolumChapter_Yazisi;
            Bolum4ButonYazi.text = "4." + BolumChapter_Yazisi;
            Bolum5ButonYazi.text = "5." + BolumChapter_Yazisi;
        }
        else if (AyarlarMenu.DilAyari == 1)
        {
            Bolum1ButonYazi.text = BolumChapter_Yazisi + " 1";
            Bolum2ButonYazi.text = BolumChapter_Yazisi + " 2";
            Bolum3ButonYazi.text = BolumChapter_Yazisi + " 3";
            Bolum4ButonYazi.text = BolumChapter_Yazisi + " 4";
            Bolum5ButonYazi.text = BolumChapter_Yazisi + " 5";
        }

        if (OyuncuAyar.BolumTamamlandi == 1)
        {
            Bolum1Tamamlandimi.SetActive(true);
        }
        else
        {
            Bolum1Tamamlandimi.SetActive(false);
        }

        SonsuzOynamakIcinTiklaYazisi.text = Sinirsiz_Limitless_Play;
        YakindaYazisi.text = Yakinda_ComingSoon;

        Bolum1ButonYazi.fontSize = Screen.width / 65;
        Bolum2ButonYazi.fontSize = Screen.width / 65;
        Bolum3ButonYazi.fontSize = Screen.width / 65;
        Bolum4ButonYazi.fontSize = Screen.width / 65;
        Bolum5ButonYazi.fontSize = Screen.width / 65;


        Bolum1TamamlandimiText.text = BolumTamamlandi_Completed;
        Bolum1TamamlandimiText.fontSize = Screen.width / 24;

        SonsuzOynamakIcinTiklaYazisi.fontSize = Screen.width / 18;
        YakindaYazisi.fontSize = Screen.width / 24;

        BolumKacYazi.fontSize = Screen.width / 24;
        SonsuzModSkor.fontSize = Screen.width / 24;
        GelinenDalga.fontSize = Screen.width / 24;

    }

    public void BolumButon1Click()
    {
        BolumlerDevamiButon.color = Gri;
        BolumButon1.color = Color.white;
        BolumButon2.color = Gri;
        BolumButon3.color = Gri;
        BolumButon4.color = Gri;
        BolumButon5.color = Gri;

        BolumKacYazi.text = BolumKac_Yazi1;
    }
    public void BolumButon2Click()
    {
        BolumlerDevamiButon.color = Gri;
        BolumButon1.color = Gri;
        BolumButon2.color = Color.white;
        BolumButon3.color = Gri;
        BolumButon4.color = Gri;
        BolumButon5.color = Gri;

        BolumKacYazi.text = BolumKac_Yazi2;
    }
    public void BolumButon3Click()
    {
        BolumlerDevamiButon.color = Gri;
        BolumButon1.color = Gri;
        BolumButon2.color = Gri;
        BolumButon3.color = Color.white;
        BolumButon4.color = Gri;
        BolumButon5.color = Gri;

        BolumKacYazi.text = BolumKac_Yazi3;
    }
    public void BolumButon4Click()
    {
        BolumlerDevamiButon.color = Gri;
        BolumButon1.color = Gri;
        BolumButon2.color = Gri;
        BolumButon3.color = Gri;
        BolumButon4.color = Color.white;
        BolumButon5.color = Gri;

        BolumKacYazi.text = BolumKac_Yazi4;
    }
    public void BolumButon5Click()
    {
        BolumlerDevamiButon.color = Gri;
        BolumButon1.color = Gri;
        BolumButon2.color = Gri;
        BolumButon3.color = Gri;
        BolumButon4.color = Gri;
        BolumButon5.color = Color.white;

        BolumKacYazi.text = BolumKac_Yazi5;
    }
    public void BolumlerYakindaClick()
    {
        BolumlerDevamiButon.color = Color.white;
        BolumButon1.color = Gri;
        BolumButon2.color = Gri;
        BolumButon3.color = Gri;
        BolumButon4.color = Gri;
        BolumButon5.color = Gri;

        BolumKacYazi.text = BolumKac_YaziSoruIsareti;
    }

    public void SonsuzOyunModu()
    {
        Yukleniyor.Yukle = 0;
        SceneManager.LoadScene(YuklemeEkrani);
    }

    public void BirinciBolumStart()
    {
        Yukleniyor.Yukle = 1;
        SceneManager.LoadScene(YuklemeEkrani);
    }


    void OnGUI()
    {
        GUI.Box(Fonksiyonlar.EkranBoyut(0.97f, 0.96f, 0, 0), SonsuzMod_SkorScore + " " + OyuncuAyar.EnYuksekSkorSonsuzMod, SonsuzModSkor);


        if (BolumKacYazi.text == BolumKac_Yazi1)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + OyuncuAyar.BirinciBolumOyuncuKacinciDalgadaKaldi.ToString() + Gelinen_DalgaWave, GelinenDalga);
        }
        else if (BolumKacYazi.text == BolumKac_Yazi2)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + "?" + Gelinen_DalgaWave, GelinenDalga);
        }
        else if (BolumKacYazi.text == BolumKac_Yazi3)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + "?" + Gelinen_DalgaWave, GelinenDalga);
        }
        else if (BolumKacYazi.text == BolumKac_Yazi4)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + "?" + Gelinen_DalgaWave, GelinenDalga);
        }
        else if (BolumKacYazi.text == BolumKac_Yazi5)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + "?" + Gelinen_DalgaWave, GelinenDalga);
        }
        else if (BolumKacYazi.text == BolumKac_YaziSoruIsareti)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.2f, 0.96f, 0, 0), DalgaSkor_Score + "?" + Gelinen_DalgaWave, GelinenDalga);
        }


        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.83f, 0.98f, 0.08f, 0.14f),"", AnaMenuDonus))
        {
            SceneManager.LoadScene(AnaMenuIsmi);
        }  
    }
}
