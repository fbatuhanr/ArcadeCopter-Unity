using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunMenusu : MonoBehaviour
{
    public static bool BesinciDalgaBidahaOyna;
    public Slider IlkDalgaSlid, IkinciDalgaSlid, UcuncuDalgaSlid, DorduncuDalgaSlid, BesinciDalgaSlid;
    public GameObject BolumBitince;
    public Image BolumBitinceBG;
    public Text Baslik;
    public Text Kazanilan, BolumOdulu;
    public Text TekrarOyna, AnaMenu;
    public Text Rakam1, Rakam2, Rakam3, Rakam4;

    public static bool ReklamiGoster;

    // Ucuncu Dalgaya gecildiginde ileri atanan engeller geri alanacak - BASLANGIC

    public Transform BoslukluEngel1, BoslukluEngel2, BoslukluEngel3;

    // Ucuncu Dalgaya gecildiginde ileri atanan engeller geri alanacak - BITIS
    // Dorduncu Dalgaya gecildiginde ileri atanan engeller geri alanacak - BASLANGIC

    public Transform DonenSilindirEngel1, DonenSilindirEngel2, DonenSilindirEngel3, DonenSilindirEngel4;

    // Dorduncu Dalgaya gecildiginde ileri atanan engeller geri alanacak - BITIS

    public Rigidbody SilahMermisi;
    public Transform SMermisi;
    public Transform Silah;

    public Transform helikopter;

    public Transform yol1, yol2, yol3;

    public GUIStyle RewardedPara, SkorArtisBG, PauseBG, RePlayBG, DalgaYazisi, YeniDalgaStili, GeriSayimStili, HizlanimGeriSayim, BaslangicGeriSayimStil;

    public GUIStyle OyunIciPanelBG, ArkaPlanResmi, SkorParaPanelResmi, GOyazi, GOskor, GamePauseYazi, YeniOyun, DevamBGico, AnaMenuDon;

    public GUIStyle IkinciDalga, UcuncuDalga, DorduncuDalga, BesinciDalga;

    public GUIStyle SkorStili,YeniYuksekSkorStili, SkorStiliOyunIci, EnYuksekSkorStili,ParaStili, ParaStiliOyunIci, MevcutParaStil;

    public GUIStyle SkorParaPanelPauseMenu, SkorStiliPauseMenu, ParaStiliPauseMenu;

    public GUIStyle AsagiOK, YukariOK, MermiStili;

    public static bool MevcutBedeldenBuyukse2;
    public static bool MevcutBedeldenBuyukse3;
    public static bool MevcutBedeldenBuyukse4;
    public static bool MevcutBedeldenBuyukse5;

    string IkinciDalgadanDevam;
    string UcuncuDalgaDevam;
    string DorduncuDalgaDevam;
    string BesinciDalgaDevam;

    int IkinciDalgaBedeli, UcuncuDalgaBedeli, DorduncuDalgaBedeli, BesinciDalgaBedeli;

    int Bedel;
    string BedelYazi;

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


    public static string Duraklatildi_Paused; // OYUN DURAKLATILDI
    public static string YeniOyun_NewGame; // Yeni Oyun
    public static string Ana_MainMenu; // Ana Menu
    public static string DevamEt_Continue; // Oyun Durdurulduktan sonra Devam Ettirme Butonlu Yazısı;
    public static string OyunBitti_GameOver; // Oyun Bitti !
    public static string Mevcut_Available; // Mevcut

    public static string ikinciDalga_SecondWave; 
    public static string ucuncuDalga_ThirthWave;
    public static string dorduncuDalga_FourthWave;
    public static string besinciDalga_FifthWave;
    public static string birinciBolum_FirstChapter;

    public static string YeterliAltin_EnoughGold; // Yeterli Altın Yok
    public static string Devam_Continue; // Devam Et
    public static string Bedel_Price;
    public static string Can_Life; // KALAN HAK

    float saydamlik;
    Color Siyah;

    public static bool ParayiToplamParayaAta;

    public void AnaMenuClick()
    {
        OyuncuAyar.ToplamSkor += (OyuncuAyar.Skor + 150);
        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

        OyuncuAyar.ToplamPara += (OyuncuAyar.Para + 150);
        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

        SceneManager.LoadScene(AnaMenuyeDon);
    }
    public void TekrarOynaClick()
    {
        OyuncuAyar.ToplamPara += (OyuncuAyar.Para + 150);
        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

        OyuncuAyar.ToplamSkor += (OyuncuAyar.Skor + 150);
        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        BesinciDalgaBidahaOyna = false;
        ParayiToplamParayaAta = false;
        BolumBitince.SetActive(false);
        saydamlik = 0;

        // ReklamAyar.BannerReklamGizle();

        ReklamiGoster = false;
        MevcutBedeldenBuyukse2 = false;
        MevcutBedeldenBuyukse3 = false;

        sayisay = 3.0f;
        MenuGelsin = false;
        sagdansolakayanyazi = -1.0f;

        IkinciDalgadanDevam = Devam_Continue;
        UcuncuDalgaDevam = Devam_Continue;
        DorduncuDalgaDevam = Devam_Continue;
        BesinciDalgaDevam = Devam_Continue;

        IkinciDalgaBedeli = 20;
        UcuncuDalgaBedeli = 30;
        DorduncuDalgaBedeli = 40;
        BesinciDalgaBedeli = 50;

    }

    void Update()
    {
        Baslik.fontSize = Screen.width / 20;
        Kazanilan.fontSize = Screen.width / 30;
        BolumOdulu.fontSize = Screen.width / 30;
        
        TekrarOyna.fontSize = Screen.width / 45;
        AnaMenu.fontSize = Screen.width / 45;

        RewardedPara.fontSize = Screen.width / 28;

        Rakam1.fontSize = Screen.width / 36;
        Rakam1.text = OyuncuAyar.Para.ToString();

        Rakam2.fontSize = Screen.width / 36;
        Rakam2.text = OyuncuAyar.Skor.ToString();

        Rakam3.fontSize = Screen.width / 36;
        Rakam3.text = "150";

        Rakam4.fontSize = Screen.width / 36;
        Rakam4.text = "150";

        SkorStiliOyunIci.fontSize = Screen.width / 26;
        ParaStiliOyunIci.fontSize = Screen.width / 26;

        EnYuksekSkorStili.fontSize = Screen.width / 20;
        YeniYuksekSkorStili.fontSize = Screen.width / 20;
        SkorStili.fontSize = Screen.width / 20;
        ParaStili.fontSize = Screen.width / 20;

        SkorStiliPauseMenu.fontSize = Screen.width / 18;
        ParaStiliPauseMenu.fontSize = Screen.width / 18;

        DalgaYazisi.fontSize = Screen.width / 22;
        YeniDalgaStili.fontSize = Screen.width / 8;
        GeriSayimStili.fontSize = Screen.width / 52;
        BaslangicGeriSayimStil.fontSize = Screen.width / 4;
        HizlanimGeriSayim.fontSize = Screen.width / 24;

        GOskor.fontSize = Screen.width / 32;

        MevcutParaStil.fontSize = Screen.width / 28;
        YeniOyun.fontSize = Screen.width / 36;

        GamePauseYazi.fontSize = Screen.width / 10;
        GOyazi.fontSize = Screen.width / 10;

        IkinciDalga.fontSize = Screen.width / 30;
        UcuncuDalga.fontSize = Screen.width / 30;
        DorduncuDalga.fontSize = Screen.width / 30;
        BesinciDalga.fontSize = Screen.width / 30;

        DevamBGico.fontSize = Screen.width / 30;
        AnaMenuDon.fontSize = Screen.width / 30;
        RePlayBG.fontSize = Screen.width / 30;

        if (helikopter.transform.position.x > 3975)
        {
            OyuncuAyar.PauseVar = false;
            BolumBitince.SetActive(true);
            if (saydamlik < 0.85f)
            {
                saydamlik += 0.01f;
            }
            Siyah = new Vector4(0,0,0,saydamlik);
            BolumBitinceBG.color = Siyah;
        }


        // position x 1550 ye gelirse yazı akmaya başlasın
        if (OyuncuAyar.IkinciEngelGeliyor)
        {
            if (sagdansolakayanyazi <= 2.5f)
            {
                if (!OyuncuAyar.DurdurmaMenusu)
                {
                    // IKINCI DALGA GELIYOR YAZISI (YAVAS)
                    if (helikopter.transform.position.x < 1100)
                    {
                        sagdansolakayanyazi += 0.01f;
                    }
                    // UCUNCU DALGA GELIYOR YAZISI (HIZLI)
                    else if (helikopter.transform.position.x >= 1100 && helikopter.transform.position.x <= 2000)
                    {
                        sagdansolakayanyazi += 0.01f;
                    }
                    else if (helikopter.transform.position.x > 2000 && helikopter.transform.position.x < 3000)
                    {
                        sagdansolakayanyazi += 0.01f;
                    }
                    else if (helikopter.transform.position.x > 3000)
                    {
                        sagdansolakayanyazi += 0.013f;
                    }
                }
                else
                {
                    sagdansolakayanyazi += 0.0f;
                }
            }
        }
        else
        {
            sagdansolakayanyazi = -1.0f;
        }


        if (helikopter.transform.position.x > 840 && helikopter.transform.position.x < 1780) // 840 1780 OLARAK DEĞİŞTİRİLECEK
        {
            Bedel = IkinciDalgaBedeli;
            BedelYazi = Bedel_Price;
        }

        else if (helikopter.transform.position.x > 1780 && helikopter.transform.position.x < 2480) // 1780  2480 OLARAK DEĞİŞTİRİLECEK
        {
            Bedel = UcuncuDalgaBedeli;
            BedelYazi = Bedel_Price;          
        }
        else if (helikopter.transform.position.x > 2480 && helikopter.transform.position.x < 3090) // 2480 3090 OLARAK DEĞİŞTİRİLECEK
        {
            Bedel = DorduncuDalgaBedeli;
            BedelYazi = Bedel_Price;
        }
        else if (helikopter.transform.position.x > 3090) // 2480 OLARAK DEĞİŞTİRİLECEK
        {
            Bedel = BesinciDalgaBedeli;
            BedelYazi = Bedel_Price;
        }
    }
    void OnGUI()
    {
        if (HelikopterAyari.GeriSayimiGoster) { 
        GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1), HelikopterAyari.BaslangicSayiSay.ToString("F0"), BaslangicGeriSayimStil);
        }
        // Skor ve Geri Sayim Baslangic
        if (HelikopterAyari.HizlanmaGeriSayiminaBasla) {
        GUI.Box(Fonksiyonlar.EkranBoyut(0.95f, 0.8f, 0.06f, 0.09f), "  : " + HelikopterAyari.HizlanimicinGeriSayim.ToString("F1"), HizlanimGeriSayim);
        }     
        // Skor ve Geri Sayim Bitti


    if (OyuncuAyar.PauseVar) {   

            GUI.Box(Fonksiyonlar.EkranBoyut(0.97f, 0.98f, 0.3f, 0.1f), "", OyunIciPanelBG);
      GUI.Box(Fonksiyonlar.EkranBoyut(0.94f, 0.937f, 0.105f, 0.065f), "" + OyuncuAyar.Skor.ToString(), SkorStiliOyunIci);
      GUI.Box(Fonksiyonlar.EkranBoyut(0.63f, 0.94f, 0.1f, 0.07f), "" + OyuncuAyar.Para.ToString(), ParaStiliOyunIci);


            if (OyuncuAyar.BesinciDalgaGucu && helikopter.transform.position.x <= 3975) {

                if (GUI.RepeatButton(Fonksiyonlar.EkranBoyut(0.95f, -0.49f, 0.15f, 0.25f), "", AsagiOK))
                {
                     helikopter.transform.position = helikopter.transform.position + new Vector3(0, -0.15f, 0);
                }
                if (GUI.RepeatButton(Fonksiyonlar.EkranBoyut(0.53f, -0.49f, 0.15f, 0.25f), "", YukariOK))
                {
                     helikopter.transform.position = helikopter.transform.position + new Vector3(0, +0.15f, 0);
                }

                if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.65f, -0.49f, 0.15f, 0.25f), "", MermiStili))
                {
                  Rigidbody Mermi;
                   Mermi = Instantiate(SilahMermisi, Silah.position, SMermisi.rotation) as Rigidbody;
                    Mermi.AddForce(Silah.forward * -1500);

                    SesAyarSFX.SilahSesiCal = true;
               }
        }

        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.76f, 0.96f, 0.1f, 0.17f), "", PauseBG))
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
            GUI.Box(Fonksiyonlar.EkranBoyut(1, 0.97f, 1, 1), Duraklatildi_Paused, GamePauseYazi);
     
            GUI.Box(Fonksiyonlar.EkranBoyut(0.8f, 0.6f, 0.8f, 0.25f),"", SkorParaPanelPauseMenu);
            GUI.Box(Fonksiyonlar.EkranBoyut(0.63f, 0.498f, 0.2f, 0.15f), "" + OyuncuAyar.Skor.ToString(), SkorStiliPauseMenu);
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.22f, 0.5f, 0.19f, 0.15f), "" + OyuncuAyar.Para.ToString(), ParaStiliPauseMenu);

            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.7f, 0, 0.1f, 0.25f), YeniOyun_NewGame, RePlayBG))
            {
                // ReklamAyar.BannerReklamGizle();

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);          
            }

            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.1f, -0.2f, 0.1f, 0.25f), Ana_MainMenu, AnaMenuDon))
            {
                // ReklamAyar.BannerReklamGizle();
                SceneManager.LoadScene(AnaMenuyeDon);
            } 
            // Devama Basılırsa
            if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0, 0.1f, 0.25f), DevamEt_Continue, DevamBGico))
            {
                // ReklamAyar.BannerReklamGizle();
                Time.timeScale = 1;
                OyuncuAyar.DurdurulmaHareket = false;   
                OyuncuAyar.DurdurulmaPervane = false;

                    HelikopterAyari.EtkilesimdeHiz = 20.0f;
                    HelikopterAyari.EtkilesimsizHiz = 15.0f;
                    HelikopterAyari.PervaneGucu = 25.0f;
                    HelikopterAyari.PervaneAzalma = -20.0f;

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
                GUI.Box(Fonksiyonlar.EkranBoyut(1,1,1,1),"", ArkaPlanResmi);
                GUI.Box(Fonksiyonlar.EkranBoyut(0.95f, 0.65f, 0.95f, 0.2f),"", SkorParaPanelResmi);

                GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1), OyunBitti_GameOver, GOyazi);

                if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkor)
                {  
                    GUI.Box(Fonksiyonlar.EkranBoyut(0.23f, 0.563f, 0.172f, 0.12f), "" + OyuncuAyar.Skor.ToString(), YeniYuksekSkorStili);
                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.51f, 0.558f, 0.15f, 0.115f), "" + OyuncuAyar.Para.ToString(), ParaStili);
                }
                else
                {
                    GUI.Box(Fonksiyonlar.EkranBoyut(0.23f, 0.563f, 0.172f, 0.12f), "" + OyuncuAyar.Skor.ToString(), SkorStili);
                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.51f, 0.558f, 0.15f, 0.115f), "" + OyuncuAyar.Para.ToString(), ParaStili);
                }   

                GUI.Box(Fonksiyonlar.EkranBoyut(0.918f, 0.575f, 0.197f, 0.125f), "" + OyuncuAyar.EnYuksekSkor.ToString(), EnYuksekSkorStili);

                if (OyuncuAyar.DalgaYandi)
                {
                    if (ParayiToplamParayaAta)
                    {
                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        ParayiToplamParayaAta = false;
                    }

                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.41f, -0.4f, 0.2f, 0.085f), BedelYazi + Bedel + "       ", MevcutParaStil);
                    GUI.Box(Fonksiyonlar.EkranBoyut(-0.41f, -0.6f, 0.2f, 0.085f), Mevcut_Available + OyuncuAyar.ToplamPara.ToString() + "       ", MevcutParaStil);

                    if (helikopter.transform.position.x > 840 && helikopter.transform.position.x < 1780) // 840 1780 OLARAK DEĞİŞTİRİLECEK
                    {
                        if (OyuncuAyar.ToplamPara >= IkinciDalgaBedeli)
                        {
                            IkinciDalgadanDevam = Devam_Continue;
                        }
                        else
                        {
                            IkinciDalgadanDevam = YeterliAltin_EnoughGold;
                        }   
                                             
                        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0.15f, 0.1f, 0.25f), IkinciDalgadanDevam, IkinciDalga))
                      {
                            IkinciDalgaDevamAyarlari();
                            IlkDalgaSlid.value = Mathf.MoveTowards(helikopter.position.x, helikopter.position.x, 1.0f);
                            IkinciDalgaSlid.value = Mathf.MoveTowards(980, helikopter.position.x, 1.0f);
                            OyuncuAyar.OyunDalgaDevamSesArttir = true;
                        }
                    }

            else if (helikopter.transform.position.x > 1780 && helikopter.transform.position.x < 2480) // 1780 2480 OLARAK DEĞİŞTİRİLECEK
                    {
                        if (OyuncuAyar.ToplamPara >= UcuncuDalgaBedeli)
                        {
                            UcuncuDalgaDevam = Devam_Continue;
                        }
                        else
                        {
                            UcuncuDalgaDevam = YeterliAltin_EnoughGold;
                        }
                      
                        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0.15f, 0.1f, 0.25f), UcuncuDalgaDevam, UcuncuDalga))
                        {
                            UcuncuDalgaDevamAyarlari();
                            IkinciDalgaSlid.value = Mathf.MoveTowards(helikopter.position.x, helikopter.position.x, 1.0f);
                            UcuncuDalgaSlid.value = Mathf.MoveTowards(1875, helikopter.position.x, 1.0f);
                            OyuncuAyar.OyunDalgaDevamSesArttir = true;
                        }
                    }
            else if (helikopter.transform.position.x > 2480 && helikopter.transform.position.x < 3080) // 2480 3080 OLARAK DEĞİŞTİRİLECEK
                    {
                        if (OyuncuAyar.ToplamPara >= DorduncuDalgaBedeli)
                        {
                            DorduncuDalgaDevam = Devam_Continue;
                        }
                        else
                        {
                            DorduncuDalgaDevam = YeterliAltin_EnoughGold;
                        }

                        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0.15f, 0.1f, 0.25f), DorduncuDalgaDevam, DorduncuDalga))
                        {
                            DorduncuDalgaDevamAyarlari();
                            UcuncuDalgaSlid.value = Mathf.MoveTowards(helikopter.position.x, helikopter.position.x, 1.0f);
                            DorduncuDalgaSlid.value = Mathf.MoveTowards(2575, helikopter.position.x, 1.0f);
                            OyuncuAyar.OyunDalgaDevamSesArttir = true;
                        }
                    }
            else if (helikopter.transform.position.x > 3080) // 3080 OLARAK DEĞİŞTİRİLECEK
                    {
                        if (OyuncuAyar.ToplamPara >= BesinciDalgaBedeli)
                        {
                            BesinciDalgaDevam = Devam_Continue;
                        }
                        else
                        {
                            BesinciDalgaDevam = YeterliAltin_EnoughGold;
                        }

                        if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.5f, 0.15f, 0.1f, 0.25f), BesinciDalgaDevam, BesinciDalga))
                        {
                            BesinciDalgaDevamAyarlari();
                            DorduncuDalgaSlid.value = Mathf.MoveTowards(helikopter.position.x, helikopter.position.x, 1.0f);
                            BesinciDalgaSlid.value = Mathf.MoveTowards(3350, helikopter.position.x, 1.0f);
                            OyuncuAyar.OyunDalgaDevamSesArttir = true;
                        }
                    }

                    if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.25f, 0.12f, 0.0855f, 0.155f), "5", RewardedPara))
                    {
                        // ReklamAyar.TiklaAltinveSkorKazan();
                    }


                    if (GUI.Button(Fonksiyonlar.EkranBoyut(0.1f, -0.2f, 0.1f, 0.25f), Ana_MainMenu, AnaMenuDon))
                    {
                        // ReklamAyar.BannerReklamGizle();

                        if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkor)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkor", OyuncuAyar.Skor);
                        }

                        OyuncuAyar.ToplamSkor += OyuncuAyar.Skor;
                        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        OyuncuAyar.HelikopterYanma = false;
                        SceneManager.LoadScene(AnaMenuyeDon);
                    }

            if (GUI.Button(Fonksiyonlar.EkranBoyut(0.7f, 0.15f, 0.1f, 0.25f), YeniOyun_NewGame, RePlayBG))
                    {
                        // ReklamAyar.BannerReklamGizle();

                        if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkor)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkor", OyuncuAyar.Skor);
                        }

                        OyuncuAyar.ToplamSkor += OyuncuAyar.Skor;
                        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        OyuncuAyar.HelikopterYanma = false;
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }
                else
                { // burasx
                    if (GUI.Button(Fonksiyonlar.EkranBoyut(-0.2f, -0.25f, 0.1f, 0.25f), Ana_MainMenu, AnaMenuDon))
                    {
                        // ReklamAyar.BannerReklamGizle();

                        if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkor)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkor", OyuncuAyar.Skor);
                        }
                        OyuncuAyar.ToplamSkor += OyuncuAyar.Skor;
                        PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

                        OyuncuAyar.ToplamPara += OyuncuAyar.Para;
                        PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

                        OyuncuAyar.HelikopterYanma = false;
                        SceneManager.LoadScene(AnaMenuyeDon);
                    }

                    if (GUI.Button(Fonksiyonlar.EkranBoyut(0.4f, -0.25f, 0.1f, 0.25f), YeniOyun_NewGame, RePlayBG))
                    {
                        // ReklamAyar.BannerReklamGizle();

                        if (OyuncuAyar.Skor > OyuncuAyar.EnYuksekSkor)
                        {
                            PlayerPrefs.SetInt("EnYuksekSkor", OyuncuAyar.Skor);
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
        }
        else
        {
            sayisay = 3.0f;
        }


        // Karakter Bir Yere Carparsa Oyun Bitti Aktiflesir - Bitti

        if (OyuncuAyar.IkinciEngelGeliyor)
         {
            if (helikopter.transform.position.x < 1100) {
        GUI.Box(Fonksiyonlar.EkranBoyut(sagdansolakayanyazi, 0.6f, 0, 0), ikinciDalga_SecondWave, DalgaYazisi);
            }
            else if (helikopter.transform.position.x > 1100 && helikopter.transform.position.x < 2000)
            {
        GUI.Box(Fonksiyonlar.EkranBoyut(sagdansolakayanyazi, 0.6f, 0, 0), ucuncuDalga_ThirthWave, DalgaYazisi);
            }
            else if (helikopter.transform.position.x > 2000 && helikopter.transform.position.x < 3000)
            {
         GUI.Box(Fonksiyonlar.EkranBoyut(sagdansolakayanyazi, 0.6f, 0, 0), dorduncuDalga_FourthWave, DalgaYazisi);
            }
            else if (helikopter.transform.position.x > 3091 && helikopter.transform.position.x < 3145)
            {
                GUI.Box(Fonksiyonlar.EkranBoyut(sagdansolakayanyazi, 0.6f, 0, 0), besinciDalga_FifthWave, DalgaYazisi);
            }
            else if (helikopter.transform.position.x >= 3145 && helikopter.transform.position.x < 3150)
            {
                sagdansolakayanyazi = -1.0f;
            }
            else if (helikopter.transform.position.x > 3150 && helikopter.transform.position.x < 3200)
            {
                GUI.Box(Fonksiyonlar.EkranBoyut(sagdansolakayanyazi, 0.6f, 0, 0), birinciBolum_FirstChapter, DalgaYazisi);
            }
        }
        if (OyuncuAyar.YeniDalga)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(0,0,0,0), HelikopterAyari.GeriSayim.ToString("F0"), YeniDalgaStili);
        }

    }

    //ß\\ ^^^-_-_-^^^ //ß\\
    // DALGA AYARLARI 

    // 2.DALGA DEVAM AYARI
    void IkinciDalgaDevamAyarlari()
    {
        if (OyuncuAyar.ToplamPara >= IkinciDalgaBedeli)
        {
            OyuncuAyar.ToplamPara -= IkinciDalgaBedeli;

            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            OyuncuAyar.Para = 0;
            MevcutBedeldenBuyukse2 = true;
        }
        else
        {
            MevcutBedeldenBuyukse2 = false;
        }

        if (MevcutBedeldenBuyukse2)
        {       
            // ReklamAyar.BannerReklamGizle();

            OyuncuAyar.HelikopterYanma = false;

            KameraAyar.DefaultKamera = true;

            KameraAyar.x = 9;
            KameraAyar.z = -25.25f;

            KameraAyar.KameraSerbestYukari = false;
            KameraAyar.KameraSerbestAsagi = false;
            KameraAyar.KameraKilitAsagi = false;
            KameraAyar.KameraKilitYukari = false;

            OyuncuAyar.DurdurmaMenusu = false;
            OyuncuAyar.DurdurulmaHareket = false;
            OyuncuAyar.DurdurulmaPervane = false;
            OyuncuAyar.DurdurmayaBasincaSayacDur = false;
            OyuncuAyar.OyunBitti = false;
            OyuncuAyar.PauseVar = true;
            Time.timeScale = 1;
            sagdansolakayanyazi = -1.0f;
            OyuncuAyar.IkinciDalgaGucu = false;
            HelikopterAyari.GeriSayim = 3.0f;

            helikopter.transform.position = new Vector3(901.0f, 8.0f, 2);
            yol1.transform.position = new Vector3(895.14f, 6, 19);
            yol2.transform.position = new Vector3(939.9399f, 6, 19);
            yol3.transform.position = new Vector3(850.3199f, 6, 19);

            MevcutBedeldenBuyukse2 = false;
        }
        else { }
    }

    // 3.DALGA DEVAM AYARI
    void UcuncuDalgaDevamAyarlari()
    {
        if (OyuncuAyar.ToplamPara >= UcuncuDalgaBedeli)
        {
            OyuncuAyar.ToplamPara -= UcuncuDalgaBedeli;

            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            OyuncuAyar.Para = 0;
            MevcutBedeldenBuyukse3 = true;
        }
        else
        {
            MevcutBedeldenBuyukse3 = false;
        }

        if (MevcutBedeldenBuyukse3)
        {
            // ReklamAyar.BannerReklamGizle();

            OyuncuAyar.HelikopterYanma = false;

            KameraAyar.KameraKilitYukari = true;

            KameraAyar.x = 9;
            KameraAyar.z = -25.25f;

            KameraAyar.KameraKilitAsagi = false;
            KameraAyar.KameraSerbestAsagi = false;
            KameraAyar.KameraSerbestYukari = false;
            KameraAyar.DefaultKamera = false;

            OyuncuAyar.DurdurmaMenusu = false;
            OyuncuAyar.DurdurulmaHareket = false;
            OyuncuAyar.DurdurulmaPervane = false;
            OyuncuAyar.DurdurmayaBasincaSayacDur = false;
            OyuncuAyar.OyunBitti = false;
            OyuncuAyar.PauseVar = true;
            Time.timeScale = 1;
            sagdansolakayanyazi = -1.0f;
            OyuncuAyar.IkinciDalgaGucu = false;

            HelikopterAyari.GeriSayim = 3.0f;

            helikopter.transform.position = new Vector3(1781.0f, 31.0f, 2);
            yol1.transform.position = new Vector3(1844.48f, 30.212f, 19);
            yol2.transform.position = new Vector3(1889.28f, 30.212f, 19);
            yol3.transform.position = new Vector3(1934.08f, 30.212f, 19);

            BoslukluEngel1.transform.position = new Vector3(1898.9f, 49.2f, 34);
            BoslukluEngel2.transform.position = new Vector3(1923.9f, 49.2f, 34);
            BoslukluEngel3.transform.position = new Vector3(1948.9f, 49.2f, 34);

            MevcutBedeldenBuyukse3 = false;
        }
        else { }
    }

    // 4.DALGA DEVAM AYARI
    void DorduncuDalgaDevamAyarlari()
    {
        if (OyuncuAyar.ToplamPara >= DorduncuDalgaBedeli)
        {         
            OyuncuAyar.ToplamPara -= DorduncuDalgaBedeli;

            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            OyuncuAyar.Para = 0;
            MevcutBedeldenBuyukse4 = true;
        }
        else
        {
            MevcutBedeldenBuyukse4 = false;
        }

        if (MevcutBedeldenBuyukse4)
        {
            // ReklamAyar.BannerReklamGizle();

            OyuncuAyar.HelikopterYanma = false;

            KameraAyar.DefaultKamera = false;
            KameraAyar.KameraSerbestYukari = false;
            KameraAyar.KameraSerbestAsagi = false;

            KameraAyar.KameraKilitAsagi = true;

            KameraAyar.x = 9;
            KameraAyar.z = -25.25f;

            KameraAyar.KameraKilitYukari = false;

            OyuncuAyar.DurdurmaMenusu = false;
            OyuncuAyar.DurdurulmaHareket = false;
            OyuncuAyar.DurdurulmaPervane = false;
            OyuncuAyar.DurdurmayaBasincaSayacDur = false;
            OyuncuAyar.OyunBitti = false;
            OyuncuAyar.PauseVar = true;
            Time.timeScale = 1;
            sagdansolakayanyazi = -1.0f;
            OyuncuAyar.IkinciDalgaGucu = false;

            HelikopterAyari.GeriSayim = 3.0f;

            helikopter.transform.position = new Vector3(2500, 8.0f, 2);
            yol1.transform.position = new Vector3(2505.7f, 6, 19);
            yol2.transform.position = new Vector3(2550.5f, 6, 19);
            yol3.transform.position = new Vector3(2595.3f, 6, 19);

            DonenSilindirEngel1.transform.position = new Vector3(2601.7f, 10.6341f, -12.45675f);
            DonenSilindirEngel2.transform.position = new Vector3(2631.7f, 10.6341f, -12.45675f);
            DonenSilindirEngel3.transform.position = new Vector3(2661.7f, 10.6341f, -12.45675f);
            DonenSilindirEngel4.transform.position = new Vector3(2691.7f, 10.6341f, -12.45675f);

            MevcutBedeldenBuyukse4 = false;
        }
        else { }
    }

    // 5.DALGA DEVAM AYARI
    void BesinciDalgaDevamAyarlari()
    {
        if (OyuncuAyar.ToplamPara >= BesinciDalgaBedeli)
        {
            OyuncuAyar.ToplamPara -= BesinciDalgaBedeli;

            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);

            OyuncuAyar.Para = 0;
            MevcutBedeldenBuyukse5 = true;
        }
        else
        {
            MevcutBedeldenBuyukse5 = false;
        }

        if (MevcutBedeldenBuyukse5)
        {
            BesinciDalgaBidahaOyna = true;
            // ReklamAyar.BannerReklamGizle();

            OyuncuAyar.HelikopterYanma = false;

            KameraAyar.DefaultKamera = false;
            KameraAyar.KameraSerbestYukari = false;
            KameraAyar.KameraSerbestAsagi = false;

            KameraAyar.KameraKilitAsagi = true;

            KameraAyar.x = 9;
            KameraAyar.z = -25.25f;


            KameraAyar.KameraKilitYukari = false;

            OyuncuAyar.DurdurmaMenusu = false;
            OyuncuAyar.DurdurulmaHareket = false;
            OyuncuAyar.DurdurulmaPervane = false;
            OyuncuAyar.DurdurmayaBasincaSayacDur = false;
            OyuncuAyar.OyunBitti = false;
            OyuncuAyar.PauseVar = true;
            Time.timeScale = 1;
            sagdansolakayanyazi = -1.0f;
            OyuncuAyar.IkinciDalgaGucu = false;

            HelikopterAyari.GeriSayim = 3.0f;

            helikopter.transform.position = new Vector3(3250.0f, 8.0f, 2);
            yol1.transform.position = new Vector3(3329.9f, 6, 19); //3329.9
            yol2.transform.position = new Vector3(3240.3f, 6, 19); //3240.3
            yol3.transform.position = new Vector3(3285.1f, 6, 19); //3285.1

            MevcutBedeldenBuyukse5 = false;
        }
        else { }
    }
}