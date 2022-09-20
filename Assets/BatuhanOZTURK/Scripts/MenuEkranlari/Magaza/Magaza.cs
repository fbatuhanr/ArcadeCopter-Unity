using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Magaza : MonoBehaviour {

    public Text ParaIcinTikla, RewardedParaBoyutu;
    public Transform Heli_Tasiyici;
    public Animator Pervane, Touch;
    public GameObject TouchObject;

    public Button ilkButon, IkinciButon, UcuncuButon, DorduncuButon, BesinciButon, AltinciButon;
    ColorBlock ilkButonRenkleri, IkinciButonRenkleri, UcuncuButonRenkleri, DorduncuButonRenkleri, BesinciButonRenkleri, AltinciButonRenkleri;

    public Color Beyaz,Gri;

    public GUIStyle Para, ParaBG, ToplamSkor, ToplamSkorBG, HelikopterUstuButonu, AnaMenuDonus,SolButon,SagButon;

    public static string ParaIcinTikla_Rewarded, Para_Money, ToplamSkor_TotalScore, Pervane_FiyatPrice;

    public Text[] SkorAltinYazi_Boyutlari;

    // TRAILS
    public Text KirmiziTrailYazisi, KirmiziTrail_FiyatYazisi;
    public Text YesilTrailYazisi, YesilTrail_FiyatYazisi;
    public Text MaviTrailYazisi, MaviTrail_FiyatYazisi;

    // PERVANELER
    public Text KirmiziPervaneYazisi, KirmiziPervane_FiyatYazisi;
    public Text YesilPervaneYazisi, YesilPervane_FiyatYazisi;
    public Text MaviPervaneYazisi, MaviPervane_FiyatYazisi;

    // GOVDELER
    public Text KirmiziGovdeYazisi, KirmiziGovde_FiyatYazisi;
    public Text YesilGovdeYazisi, YesilGovde_FiyatYazisi;
    public Text MaviGovdeYazisi, MaviGovde_FiyatYazisi;

    // ALTLIKLAR
    public Text KirmiziAltlikYazisi, KirmiziAltlik_FiyatYazisi;
    public Text YesilAltlikYazisi, YesilAltlik_FiyatYazisi;
    public Text MaviAltlikYazisi, MaviAltlik_FiyatYazisi;

    // ALTLIKLAR
    public Text KirmiziKuyrukYazisi, KirmiziKuyruk_FiyatYazisi;
    public Text YesilKuyrukYazisi, YesilKuyruk_FiyatYazisi;
    public Text MaviKuyrukYazisi, MaviKuyruk_FiyatYazisi;

    public static string Kirmizi_TrailIz, Yesil_TrailIz, Mavi_TrailIz;

    public static string KirmiziRed_Pervane, YesilGreen_Pervane, MaviBlue_Pervane;

    public static string KirmiziRed_Govde, YesilGreen_Govde, MaviBlue_Govde;

    public static string KirmiziRed_Altlik, YesilGreen_Altlik, MaviBlue_Altlik;

    public static string KirmiziRed_Kuyruk, YesilGreen_Kuyruk, MaviBlue_Kuyruk;

    float ParaKonumOrani;

    public string AnaMenuIsmi;
    public float v, a, y, b;

    int Sayac;
    public static int TouchAnimOlayi;

    public static bool HeliDurdurmaAktif;

    bool dondurmesagsol;

    void Start () {

        // ReklamAyar.BannerReklamGizle();

        dondurmesagsol = false;

        ilkButonRenkleri.normalColor = Beyaz;
        ilkButonRenkleri.highlightedColor = Beyaz;
        ilkButonRenkleri.pressedColor = Beyaz;
        ilkButonRenkleri.disabledColor = Beyaz;
        ilkButonRenkleri.colorMultiplier = 1;
        ilkButonRenkleri.fadeDuration = 0.1f;


        IkinciButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.highlightedColor = Beyaz;
        IkinciButonRenkleri.pressedColor = Beyaz;
        IkinciButonRenkleri.disabledColor = Beyaz;
        IkinciButonRenkleri.colorMultiplier = 1;
        IkinciButonRenkleri.fadeDuration = 0.1f;

        UcuncuButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.highlightedColor = Beyaz;
        UcuncuButonRenkleri.pressedColor = Beyaz;
        UcuncuButonRenkleri.disabledColor = Beyaz;
        UcuncuButonRenkleri.colorMultiplier = 1;
        UcuncuButonRenkleri.fadeDuration = 0.1f;


        DorduncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.highlightedColor = Beyaz;
        DorduncuButonRenkleri.pressedColor = Beyaz;
        DorduncuButonRenkleri.disabledColor = Beyaz;
        DorduncuButonRenkleri.colorMultiplier = 1;
        DorduncuButonRenkleri.fadeDuration = 0.1f;


        BesinciButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.highlightedColor = Beyaz;
        BesinciButonRenkleri.pressedColor = Beyaz;
        BesinciButonRenkleri.disabledColor = Beyaz;
        BesinciButonRenkleri.colorMultiplier = 1;
        BesinciButonRenkleri.fadeDuration = 0.1f;

        AltinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.highlightedColor = Beyaz;
        AltinciButonRenkleri.pressedColor = Beyaz;
        AltinciButonRenkleri.disabledColor = Beyaz;
        AltinciButonRenkleri.colorMultiplier = 1;
        AltinciButonRenkleri.fadeDuration = 0.1f;

        Sayac = 1;
        Pervane.speed = 0.0f;

        HeliDurdurmaAktif = false;
        Pervane.speed = 1.0f;

        AyarlarMenu.DilAyari = PlayerPrefs.GetInt("DilAyari");
        TouchAnimOlayi = PlayerPrefs.GetInt("MagazaTouchAnimi");
       
        if (TouchAnimOlayi == 0)
        {
            TouchObject.SetActive(true);
            Touch.Play("TouchAnim", -1, 0f);
        }
        else
        {
            TouchObject.SetActive(false);
        }

        GunlukBonusOdul.MagazadaGosterim = true;
    }
	
	void Update () {

        RewardedParaBoyutu.fontSize = Screen.width / 28;
        ParaIcinTikla.fontSize = Screen.width / 42;

        ParaIcinTikla.text = ParaIcinTikla_Rewarded;

        ilkButon.colors = ilkButonRenkleri;
        IkinciButon.colors = IkinciButonRenkleri;
        UcuncuButon.colors = UcuncuButonRenkleri;
        DorduncuButon.colors = DorduncuButonRenkleri;
        BesinciButon.colors = BesinciButonRenkleri;
        AltinciButon.colors = AltinciButonRenkleri;

        Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(AnaMenuIsmi);
        }
         
        OyuncuAyar.ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");
        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");

        ToplamSkor.fontSize = Screen.width / 20;
        Para.fontSize = Screen.width / 20;

        SkorAltinYazi_Boyutlari[0].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[1].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[2].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[3].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[4].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[5].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[6].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[7].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[8].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[9].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[10].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[11].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[12].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[13].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[14].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[15].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[16].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[17].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[18].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[19].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[20].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[21].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[22].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[23].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[24].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[25].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[26].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[27].fontSize = Screen.width / 45;
        SkorAltinYazi_Boyutlari[28].fontSize = Screen.width / 38;
        SkorAltinYazi_Boyutlari[29].fontSize = Screen.width / 45;


        KirmiziTrailYazisi.text = Kirmizi_TrailIz;
            KirmiziTrail_FiyatYazisi.text = Pervane_FiyatPrice;
        YesilTrailYazisi.text = Yesil_TrailIz;
            YesilTrail_FiyatYazisi.text = Pervane_FiyatPrice;
        MaviTrailYazisi.text = Mavi_TrailIz;
            MaviTrail_FiyatYazisi.text = Pervane_FiyatPrice;

        YesilPervaneYazisi.text = YesilGreen_Pervane;
        YesilPervane_FiyatYazisi.text = Pervane_FiyatPrice;
        KirmiziPervaneYazisi.text = KirmiziRed_Pervane;
        KirmiziPervane_FiyatYazisi.text = Pervane_FiyatPrice;
        MaviPervaneYazisi.text = MaviBlue_Pervane;
        MaviPervane_FiyatYazisi.text = Pervane_FiyatPrice;

        KirmiziGovdeYazisi.text = KirmiziRed_Govde;
        KirmiziGovde_FiyatYazisi.text = Pervane_FiyatPrice;
        YesilGovdeYazisi.text = YesilGreen_Govde;
        YesilGovde_FiyatYazisi.text = Pervane_FiyatPrice;
        MaviGovdeYazisi.text = MaviBlue_Govde;
        MaviGovde_FiyatYazisi.text = Pervane_FiyatPrice;

        KirmiziAltlikYazisi.text = KirmiziRed_Altlik;
        KirmiziAltlik_FiyatYazisi.text = Pervane_FiyatPrice;
        YesilAltlikYazisi.text = YesilGreen_Altlik;
        YesilAltlik_FiyatYazisi.text = Pervane_FiyatPrice;
        MaviAltlikYazisi.text = MaviBlue_Altlik;
        MaviAltlik_FiyatYazisi.text = Pervane_FiyatPrice;

        KirmiziKuyrukYazisi.text = KirmiziRed_Kuyruk;
        KirmiziKuyruk_FiyatYazisi.text = Pervane_FiyatPrice;
        YesilKuyrukYazisi.text = YesilGreen_Kuyruk;
        YesilKuyruk_FiyatYazisi.text = Pervane_FiyatPrice;
        MaviKuyrukYazisi.text = MaviBlue_Kuyruk;
        MaviKuyruk_FiyatYazisi.text = Pervane_FiyatPrice;

          KirmiziTrailYazisi.fontSize = Screen.width / 36;
          KirmiziTrail_FiyatYazisi.fontSize = Screen.width / 40;
             YesilTrailYazisi.fontSize = Screen.width / 36;
             YesilTrail_FiyatYazisi.fontSize = Screen.width / 40;
                 MaviTrailYazisi.fontSize = Screen.width / 36;
                 MaviTrail_FiyatYazisi.fontSize = Screen.width / 40;
                      YesilPervaneYazisi.fontSize = Screen.width / 36;
                        YesilPervane_FiyatYazisi.fontSize = Screen.width / 40;          
                             KirmiziPervaneYazisi.fontSize = Screen.width / 36;
                             KirmiziPervane_FiyatYazisi.fontSize = Screen.width / 40;
                                MaviPervaneYazisi.fontSize = Screen.width / 36;
                                MaviPervane_FiyatYazisi.fontSize = Screen.width / 40;       
                                    KirmiziGovdeYazisi.fontSize = Screen.width / 36;
                                    KirmiziGovde_FiyatYazisi.fontSize = Screen.width / 40;        
                                        YesilGovdeYazisi.fontSize = Screen.width / 36;
                                        YesilGovde_FiyatYazisi.fontSize = Screen.width / 40;       
                                           MaviGovdeYazisi.fontSize = Screen.width / 36;
                                           MaviGovde_FiyatYazisi.fontSize = Screen.width / 40;       
                                                KirmiziAltlikYazisi.fontSize = Screen.width / 36;
                                                KirmiziAltlik_FiyatYazisi.fontSize = Screen.width / 40;       
                                                    YesilAltlikYazisi.fontSize = Screen.width / 36;
                                                    YesilAltlik_FiyatYazisi.fontSize = Screen.width / 40;      
                                                        MaviAltlikYazisi.fontSize = Screen.width / 36;
                                                        MaviAltlik_FiyatYazisi.fontSize = Screen.width / 40;
                                                            KirmiziKuyrukYazisi.fontSize = Screen.width / 36;
                                                            KirmiziKuyruk_FiyatYazisi.fontSize = Screen.width / 40;           
                                                                YesilKuyrukYazisi.fontSize = Screen.width / 36;
                                                                YesilKuyruk_FiyatYazisi.fontSize = Screen.width / 40;    
                                                                    MaviKuyrukYazisi.fontSize = Screen.width / 36;
                                                                    MaviKuyruk_FiyatYazisi.fontSize = Screen.width / 40;


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

        if (Sayac % 2 == 0)
        {
            if (Pervane.speed < 1.0f)
            {
                Pervane.speed += 0.01f;
            }
        }
        else
        {
            if (Pervane.speed > 0.1f)
            {
                Pervane.speed -= 0.02f;
                if (Pervane.speed <= 0.1f)
                {
                    Pervane.speed = 0;
                }
            }
        }
    }

    public void BirinciButonTiklama()
    {
        ilkButonRenkleri.normalColor = Beyaz;
        IkinciButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.normalColor = Gri;
    }

   public void IkinciButonTiklama()
    {
        ilkButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.normalColor = Beyaz;
        UcuncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.normalColor = Gri;
    }
    public void UcuncuButonTiklama()
    {
        ilkButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.normalColor = Beyaz;
        DorduncuButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.normalColor = Gri;
    }
    public void DorduncuButonTiklama()
    {
        ilkButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.normalColor = Beyaz;
        BesinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.normalColor = Gri;
    }
    public void BesinciButonTiklama()
    {
        ilkButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.normalColor = Beyaz;
        AltinciButonRenkleri.normalColor = Gri;
    }
    public void AltinciButonTiklama()
    {
        ilkButonRenkleri.normalColor = Gri;
        IkinciButonRenkleri.normalColor = Gri;
        UcuncuButonRenkleri.normalColor = Gri;
        DorduncuButonRenkleri.normalColor = Gri;
        BesinciButonRenkleri.normalColor = Gri;
        AltinciButonRenkleri.normalColor = Beyaz;
    }

    public void sagsolgizle()
    {
        dondurmesagsol = true;
    }
    public void sagsolac()
    {
        dondurmesagsol = false;
    }

    void OnGUI()
    {
        if (GUI.Button(Fonksiyonlar.EkranBoyut(0.08f, 0.98f, 0.08f, 0.13f), "", AnaMenuDonus))
        {
            TouchAnimOlayi = 1;
            PlayerPrefs.SetInt("MagazaTouchAnimi", TouchAnimOlayi);

            SceneManager.LoadScene(AnaMenuIsmi);
        }
       
            GUI.Box(Fonksiyonlar.EkranBoyut(0.988f, 0.95f, 0, 0), Para_Money + OyuncuAyar.ToplamPara.ToString(), Para);
            GUI.Box(Fonksiyonlar.EkranBoyut(ParaKonumOrani, 0.96f, 0.045f, 0.075f), "", ParaBG);

            GUI.Box(Fonksiyonlar.EkranBoyut(-0.89f, 0.95f, 0, 0), ToplamSkor_TotalScore + OyuncuAyar.ToplamSkor.ToString(), ToplamSkor);
            GUI.Box(Fonksiyonlar.EkranBoyut(-0.9f, 0.96f, 0.045f, 0.075f), "", ToplamSkorBG);
        

      if(GUI.Button(Fonksiyonlar.EkranBoyut(0.4f, -0.2f, 0.4f, 0.4f), "", HelikopterUstuButonu))
         {
        Sayac += 1; 
         }

        if (!dondurmesagsol)
        {
            if (GUI.RepeatButton(Fonksiyonlar.EkranBoyut(0.85f, -0.4f, 0.11f, 0.2f), "", SolButon))
            {
                Heli_Tasiyici.transform.Rotate(+2.5f, 0, 0);
            }

            if (GUI.RepeatButton(Fonksiyonlar.EkranBoyut(-0.62f, -0.4f, 0.11f, 0.2f), "", SagButon))
            {
                Heli_Tasiyici.transform.Rotate(-2.5f, 0, 0);
            }
        }
  }
}
