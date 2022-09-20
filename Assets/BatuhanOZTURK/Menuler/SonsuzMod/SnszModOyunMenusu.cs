using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SnszModOyunMenusu : MonoBehaviour
{
    public Text SonsuzModSkor, SonsuzModPara;
    public Collider HelikopterGovdeCol;

    public static bool ReklamiGoster, ToplamParayaAta;

    public Transform helikopter;

    public GUIStyle SnszModDevamEt,RewardedPara;

    public GUIStyle SkorArtisBG, PauseBG, RePlayBG, HizlanimGeriSayim;

    public GUIStyle OyunIciPanelBG, ArkaPlanResmi, SkorParaPanelResmi, GOyazi, GOskor, GamePauseYazi, YeniOyun, DevamBGico, AnaMenuDon;

    public GUIStyle SkorStili, YeniYuksekSkorStili, SkorStiliOyunIci, EnYuksekSkorStili, ParaStili, ParaStiliOyunIci, MevcutParaStil;

    public GUIStyle SkorParaPanelPauseMenu, SkorStiliPauseMenu, ParaStiliPauseMenu;
        
    int Bedel;
    string BedelYazi;

    public static bool HelikopteriYukariyaTasi;

    public static string AnaMenuYazi_SnszMod;
    public static bool MenuGelsin;
    public string AnaMenuyeDon;

    public float a1, a2, a3, a4;
    public float b1, b2, b3, b4;
    public float c1, c2, c3, c4;

    public float o;
    public float z;
    public float t;
    public float u;

    public static float sayisay;

    public static float sagdansolakayanyazi;

    public static bool MevcutBedeldenBuyukse;
    void Start()
    {
        MevcutBedeldenBuyukse = false;
           ToplamParayaAta = false;
        HelikopteriYukariyaTasi = false;

        // ReklamAyar.BannerReklamGizle();

        ReklamiGoster = false;

        sayisay = 3.0f;
        MenuGelsin = false;

    }

    void Update()
    {
        RewardedPara.fontSize = Screen.width / 28;

        SonsuzModSkor.fontSize = Screen.width / 22;
             SonsuzModSkor.text = OyuncuAyar.Skor.ToString();
        SonsuzModPara.fontSize = Screen.width / 22;
             SonsuzModPara.text = OyuncuAyar.Para.ToString();

        SkorStiliOyunIci.fontSize = Screen.width / 20;
        ParaStiliOyunIci.fontSize = Screen.width / 20;

        EnYuksekSkorStili.fontSize = Screen.width / 14;
        YeniYuksekSkorStili.fontSize = Screen.width / 14;
        SkorStili.fontSize = Screen.width / 14;
        ParaStili.fontSize = Screen.width / 14;

        SkorStiliPauseMenu.fontSize = Screen.width / 12;
        ParaStiliPauseMenu.fontSize = Screen.width / 12;

        HizlanimGeriSayim.fontSize = Screen.width / 24;

        GOskor.fontSize = Screen.width / 20;

        MevcutParaStil.fontSize = Screen.width / 20;
        YeniOyun.fontSize = Screen.width / 20;

        GamePauseYazi.fontSize = Screen.width / 12;
        GOyazi.fontSize = Screen.width / 12;


        DevamBGico.fontSize = Screen.width / 20;
        AnaMenuDon.fontSize = Screen.width / 20;
        RePlayBG.fontSize = Screen.width / 20;
        SnszModDevamEt.fontSize = Screen.width / 20;

        if (HelikopterAyariSonsuzMod.YanmaSayaci == 1)
        {
            Bedel = 10;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 2)
        {
            Bedel = 20;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 3)
        {
            Bedel = 30;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 4)
        {
            Bedel = 40;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 5)
        {
            Bedel = 50;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 6)
        {
            Bedel = 60;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 7)
        {
            Bedel = 70;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 8)
        {
            Bedel = 80;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 9)
        {
            Bedel = 90;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 10)
        {
            Bedel = 100;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 11)
        {
            Bedel = 110;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 12)
        {
            Bedel = 120;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 13)
        {
            Bedel = 130;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 14)
        {
            Bedel = 140;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 15)
        {
            Bedel = 150;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 16)
        {
            Bedel = 160;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 17)
        {
            Bedel = 170;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 18)
        {
            Bedel = 180;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 19)
        {
            Bedel = 190;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 20)
        {
            Bedel = 200;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 21)
        {
            Bedel = 210;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 22)
        {
            Bedel = 220;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 23)
        {
            Bedel = 230;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 24)
        {
            Bedel = 240;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 25)
        {
            Bedel = 250;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 26)
        {
            Bedel = 260;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 27)
        {
            Bedel = 270;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 28)
        {
            Bedel = 280;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 29)
        {
            Bedel = 290;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 30)
        {
            Bedel = 300;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 31)
        {
            Bedel = 310;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 32)
        {
            Bedel = 320;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 33)
        {
            Bedel = 330;
        }
        else if (HelikopterAyariSonsuzMod.YanmaSayaci == 34)
        {
            Bedel = 340;
        }
        else
        {
            Bedel = 350;
        }

        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");


        if (HelikopteriYukariyaTasi)
        {
            if (helikopter.transform.position.y < 7.0f)
            {
                helikopter.transform.position = helikopter.transform.position + new Vector3(0, 0.1f, 0);
            }
            else if (helikopter.transform.position.y >= 7.5f)
            {
                helikopter.transform.position = helikopter.transform.position + new Vector3(0, -0.1f, 0);
            }
        }
        else
        {
            HelikopterGovdeCol.isTrigger = false;
        }
    }

    void OnGUI()
    {
        /*
        if (HelikopterAyari.HizlanmaGeriSayiminaBasla)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(0.95f, 0.8f, 0.06f, 0.09f), "  : " + HelikopterAyari.HizlanimicinGeriSayim.ToString("F1"), HizlanimGeriSayim);
        }
        */


        if (OyuncuAyar.PauseVar)
        {/*
            GUI.Box(Fonksiyonlar.EkranBoyut(0.97f, 0.98f, 0.3f, 0.1f), "", OyunIciPanelBG);
            GUI.Box(Fonksiyonlar.EkranBoyut(0.94f, 0.937f, 0.09f, 0.065f), "" + OyuncuAyar.Skor.ToString(), SkorStiliOyunIci);
            GUI.Box(Fonksiyonlar.EkranBoyut(0.63f, 0.94f, 0.09f, 0.07f), "" + OyuncuAyar.Para.ToString(), ParaStiliOyunIci);
            */

            if (GUI.Button(Fonksiyonlar.EkranBoyut(o, z, t, u), "", PauseBG))
            {
                  // ReklamAyar.BannerReklamGoster();

                OyuncuAyar.DurdurulmaHareket = true;
                OyuncuAyar.DurdurulmaPervane = true;
                OyuncuAyar.DurdurmayaBasincaSayacDur = true;
                OyuncuAyar.DurdurmaMenusu = true;
                OyuncuAyar.OyunDevamSesArttir = false;
                OyuncuAyar.OyunDalgaDevamSesArttir = false;
            }
        }

        // Devam Baslangic
        if (OyuncuAyar.DurdurmaMenusu)
        {
            Time.timeScale = 0;
            OyuncuAyar.PauseVar = false;

            GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1), "", ArkaPlanResmi);
            GUI.Box(Fonksiyonlar.EkranBoyut(1, 0.97f, 1, 1), OyunMenusu.Duraklatildi_Paused, GamePauseYazi);

            GUI.Box(Fonksiyonlar.EkranBoyut(0.8f, 0.6f, 0.8f, 0.25f), "", SkorParaPanelPauseMenu);
            GUI.Box(Fonksiyonlar.EkranBoyut(0.63f, 0.498f, 0.2f, 0.15f), "" + OyuncuAyar.Skor.ToString(), SkorStiliPauseMenu);
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.22f, 0.5f, 0.19f, 0.15f), "" + OyuncuAyar.Para.ToString(), ParaStiliPauseMenu);

            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.7f, 0, 0.1f, 0.25f), OyunMenusu.YeniOyun_NewGame, RePlayBG))
            {
                // ReklamAyar.BannerReklamGizle();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.1f, -0.2f, 0.1f, 0.25f), AnaMenuYazi_SnszMod, AnaMenuDon))
            {
                // ReklamAyar.BannerReklamGoster();
                SceneManager.LoadScene(AnaMenuyeDon);
            }
            // Devama Basılırsa
            if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0, 0.1f, 0.25f), OyunMenusu.DevamEt_Continue, DevamBGico))
            {
                // ReklamAyar.BannerReklamGizle();
                if (OyuncuAyar.Skor < 5)
                {
                    Time.timeScale = 1;
                }
                else if (OyuncuAyar.Skor >= 5 && OyuncuAyar.Skor <= 10)
                {
                    Time.timeScale = 1.1f;
                }
                else if (OyuncuAyar.Skor > 10 && OyuncuAyar.Skor <= 20)
                {
                    Time.timeScale = 1.2f;
                }
                else if (OyuncuAyar.Skor > 20 && OyuncuAyar.Skor <= 30)
                {
                    Time.timeScale = 1.3f;
                }
                else if (OyuncuAyar.Skor > 30 && OyuncuAyar.Skor <= 40)
                {
                    Time.timeScale = 1.4f;
                }
                else if (OyuncuAyar.Skor > 40 && OyuncuAyar.Skor <= 50)
                {
                    Time.timeScale = 1.5f;
                }
                else if (OyuncuAyar.Skor > 50 && OyuncuAyar.Skor <= 60)
                {
                    Time.timeScale = 1.6f;
                }
                else if (OyuncuAyar.Skor > 60 && OyuncuAyar.Skor <= 70)
                {
                    Time.timeScale = 1.7f;
                }
                else if (OyuncuAyar.Skor > 70 && OyuncuAyar.Skor <= 80)
                {
                    Time.timeScale = 1.8f;
                }
                else if (OyuncuAyar.Skor > 80 && OyuncuAyar.Skor <= 90)
                {
                    Time.timeScale = 1.85f;
                }
                else if (OyuncuAyar.Skor > 90 && OyuncuAyar.Skor < 100)
                {
                    Time.timeScale = 1.9f;
                }
                else
                {
                    Time.timeScale = 2;
                }
                OyuncuAyar.DurdurulmaHareket = false;
                OyuncuAyar.DurdurulmaPervane = false;

                OyuncuAyar.PauseVar = true;

                OyuncuAyar.DurdurmayaBasincaSayacDur = false;

                OyuncuAyar.DurdurmaMenusu = false;

                OyuncuAyar.OyunDevamSesArttir = true;
            }
        }

        // BASILDIGINDAKI MENU Bitis


        // Karakter Bir Yere Carparsa Oyun Bitti Aktiflesir - Baslangic
        if (OyuncuAyar.OyunBitti)
        {
            OyuncuAyar.OyunDalgaDevamSesArttir = false;
            OyuncuAyar.OyunDevamSesArttir = false;

            OyuncuAyar.DurdurulmaHareket = true;
            OyuncuAyar.DurdurulmaPervane = true;
            OyuncuAyar.PauseVar = false;
            Time.timeScale = 0;
            OyuncuAyar.DurdurmayaBasincaSayacDur = true;
            if (sayisay >= 0.0f)
            {
                sayisay -= Time.unscaledDeltaTime * 0.4f;

            }
            if (sayisay <= 1.0f)
            {
                GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1), "", ArkaPlanResmi);
                GUI.Box(Fonksiyonlar.EkranBoyut(0.95f, 0.6f, 0.95f, 0.2f), "", SkorParaPanelResmi);

                GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1), OyunMenusu.OyunBitti_GameOver, GOyazi);

                if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.25f, 0.12f, 0.0855f, 0.155f), "5", RewardedPara))
                {
                    // ReklamAyar.TiklaAltinveSkorKazan();
                }

                if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkorSonsuzMod)
                {
                    GUI.Box(Fonksiyonlar.EkranBoyut(0.23f, 0.513f, 0.172f, 0.12f), "" + OyuncuAyar.Skor.ToString(), YeniYuksekSkorStili);
                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.51f, 0.508f, 0.15f, 0.115f), "" + OyuncuAyar.Para.ToString(), ParaStili);
                }
                else
                {
                    GUI.Box(Fonksiyonlar.EkranBoyut(0.23f, 0.513f, 0.172f, 0.12f), "" + OyuncuAyar.Skor.ToString(), SkorStili);
                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.51f, 0.508f, 0.15f, 0.115f), "" + OyuncuAyar.Para.ToString(), ParaStili);
                }

                GUI.Box(Fonksiyonlar.EkranBoyut(0.918f, 0.525f, 0.19f, 0.125f), "" + OyuncuAyar.EnYuksekSkorSonsuzMod.ToString(), EnYuksekSkorStili);
                  GUI.Box(Fonksiyonlar.EkranBoyut(-0.44f, -0.4f, 0.2f, 0.07f), OyunMenusu.Bedel_Price + Bedel + "    ", MevcutParaStil);
                  GUI.Box(Fonksiyonlar.EkranBoyut(a1, a2, a3, a4), OyunMenusu.Mevcut_Available + OyuncuAyar.ToplamPara.ToString() + "    ", MevcutParaStil);

                            if (ToplamParayaAta)
                            {
                                OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                                PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                                ToplamParayaAta = false;
                            }
                if (OyuncuAyar.ToplamPara >= Bedel)
                        {      OyunMenusu.DevamEt_Continue = OyunMenusu.Devam_Continue;    }      else    { OyunMenusu.DevamEt_Continue = OyunMenusu.YeterliAltin_EnoughGold; }

                if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0.15f, 0.1f, 0.25f), OyunMenusu.DevamEt_Continue, SnszModDevamEt))
                    {         
                    SonsuzModDevamEt();
                  }
                           
                    if (GUI.Button(Fonksiyonlar.EkranBoyut(0.1f, -0.2f, 0.1f, 0.25f), AnaMenuYazi_SnszMod, AnaMenuDon))
                    {
                        // ReklamAyar.BannerReklamGoster();
                    if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkorSonsuzMod)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkorSonsuzMod", OyuncuAyar.Skor);
                        }
                        OyuncuAyar.ToplamSkor += OyuncuAyar.Skor;
                        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        OyuncuAyar.HelikopterYanma = false;
                        SceneManager.LoadScene(AnaMenuyeDon);
                    }

                    if (GUI.Button(Fonksiyonlar.EkranBoyut(0.7f, 0.15f, 0.1f, 0.25f), OyunMenusu.YeniOyun_NewGame, RePlayBG))
                      {
                      // ReklamAyar.BannerReklamGizle();
                    if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkorSonsuzMod)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkorSonsuzMod", OyuncuAyar.Skor);
                        }
                        OyuncuAyar.ToplamSkor += OyuncuAyar.Skor;
                        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        OyuncuAyar.HelikopterYanma = false;
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
            }
        }
        else
        {
            sayisay = 3.0f;
        }
    }

    void SonsuzModDevamEt()
    {
        if (OyuncuAyar.ToplamPara >= Bedel)
        {
            OyuncuAyar.ToplamPara -= Bedel;

            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            OyuncuAyar.Para = 0;
            MevcutBedeldenBuyukse = true;
        }
        else
        {
            MevcutBedeldenBuyukse = false;
        }
        if (MevcutBedeldenBuyukse)
        {
            // ReklamAyar.BannerReklamGizle();
            HelikopteriYukariyaTasi = true;
            HelikopterGovdeCol.isTrigger = true;
            HelikopterAyariSonsuzMod.Animle = false;
            HelikopterAyariSonsuzMod.GeriSayim = 5.2f;

            OyuncuAyar.HelikopterYanma = false;
            OyuncuAyar.DurdurmaMenusu = false;

            OyuncuAyar.DurdurmayaBasincaSayacDur = false;
            OyuncuAyar.OyunBitti = false;
            OyuncuAyar.PauseVar = true;
            if (OyuncuAyar.Skor < 5)
            {
                Time.timeScale = 1;
            }
            else if (OyuncuAyar.Skor >= 5 && OyuncuAyar.Skor <= 10)
            {
                Time.timeScale = 1.1f;
            }
            else if (OyuncuAyar.Skor > 10 && OyuncuAyar.Skor <= 20)
            {
                Time.timeScale = 1.2f;
            }
            else if (OyuncuAyar.Skor > 20 && OyuncuAyar.Skor <= 30)
            {
                Time.timeScale = 1.3f;
            }
            else if (OyuncuAyar.Skor > 30 && OyuncuAyar.Skor <= 40)
            {
                Time.timeScale = 1.4f;
            }
            else if (OyuncuAyar.Skor > 40 && OyuncuAyar.Skor <= 50)
            {
                Time.timeScale = 1.5f;
            }
            else if (OyuncuAyar.Skor > 50 && OyuncuAyar.Skor <= 60)
            {
                Time.timeScale = 1.6f;
            }
            else if (OyuncuAyar.Skor > 60 && OyuncuAyar.Skor <= 70)
            {
                Time.timeScale = 1.7f;
            }
            else if (OyuncuAyar.Skor > 70 && OyuncuAyar.Skor <= 80)
            {
                Time.timeScale = 1.8f;
            }
            else if (OyuncuAyar.Skor > 80 && OyuncuAyar.Skor <= 90)
            {
                Time.timeScale = 1.85f;
            }
            else if (OyuncuAyar.Skor > 90 && OyuncuAyar.Skor < 100)
            {
                Time.timeScale = 1.9f;
            }
            else
            {
                Time.timeScale = 2;
            }
        }
    }
}