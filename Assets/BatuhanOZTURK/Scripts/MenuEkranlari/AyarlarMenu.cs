using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarMenu : MonoBehaviour {

    public GUIStyle AnaMenuDonus;

    public GameObject Turkish;
    public GameObject English;

    public Toggle Turkce, Ingilizce;
    public Text DiliniSecYazisi,TurkceYazisi,EnglishYazisi;

    public Toggle Sustur_Mutele,Sustur_MuteleSFX;

    public Text AyarlarYazisi;
    public Text MusicMute,SFXMute;
    public Text SesAyarlariYazisi;

    public string AnaMenuIsmi;

    public static int MuteMuzik;
    public static int MuteHeliSFX;

    public static int DilAyari;
    public static string Ayarlar_Settings;
    public static string SesAyarlari_Settings;
    public static string Sustur_Mute_Music;
    public static string Sustur_Mute_HeliPervaneSFX;

    bool TR, ENG;

    void Start () {

        // ReklamAyar.BannerReklamGoster();

        MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");
        MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");

        TR = false;
        ENG = false;

        if (MuteMuzik == 0)
        {
            Sustur_Mutele.isOn = false;
        }
        else if (MuteMuzik == 1)
        {
            Sustur_Mutele.isOn = true;
        }

        if (MuteHeliSFX == 0)
        {
            Sustur_MuteleSFX.isOn = false;
        }
        else if (MuteHeliSFX == 1)
        {
            Sustur_MuteleSFX.isOn = true;
        }

        if (DilAyari == 0)
        {
            Turkce.isOn = true;
            Ingilizce.isOn = false;

            DiliniSecYazisi.text = "Dil Ayarları";
            Turkish.SetActive(true);
            English.SetActive(false);

        }
        else if (DilAyari == 1)
        {
            Turkce.isOn = false;
            Ingilizce.isOn = true;

            DiliniSecYazisi.text = "Language Settings";
            Turkish.SetActive(false);
            English.SetActive(true);
        }

    }
	
	void Update () {

        MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");
        MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");

        DilAyari = PlayerPrefs.GetInt("DilAyari");

        Time.timeScale = 1;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(AnaMenuIsmi);
        }

        DiliniSecYazisi.fontSize = Screen.width / 24;
        SesAyarlariYazisi.fontSize = Screen.width / 24;

        TurkceYazisi.fontSize = Screen.width / 28;
        EnglishYazisi.fontSize = Screen.width / 28;

        AyarlarYazisi.fontSize = Screen.width / 14;
        MusicMute.fontSize = Screen.width / 30;
        SFXMute.fontSize = Screen.width / 34;

        AyarlarYazisi.text = Ayarlar_Settings;
        SesAyarlariYazisi.text = SesAyarlari_Settings;
        MusicMute.text = Sustur_Mute_Music;
        SFXMute.text = Sustur_Mute_HeliPervaneSFX;

        if (Sustur_Mutele.isOn == true) {
            MuteMuzik = 1;
            PlayerPrefs.SetInt("MuteMuzik", MuteMuzik);
        }
        else
        {
            MuteMuzik = 0;
            PlayerPrefs.SetInt("MuteMuzik", MuteMuzik);
        }

        if (MuteMuzik == 0)
        {
            Sustur_Mutele.isOn = false;
        }
        else if ( MuteMuzik == 1)
        {
            Sustur_Mutele.isOn = true;
        }


        if (Sustur_MuteleSFX.isOn == true)
        {
            MuteHeliSFX = 1;
            PlayerPrefs.SetInt("MuteHeliSFX", MuteHeliSFX);
        }
        else
        {
            MuteHeliSFX = 0;
            PlayerPrefs.SetInt("MuteHeliSFX", MuteHeliSFX);
        }

        if (MuteHeliSFX == 0)
        {
            Sustur_MuteleSFX.isOn = false;
        }
        else if (MuteHeliSFX == 1)
        {
            Sustur_MuteleSFX.isOn = true;
        }



        if (Turkce.isOn == true)
        {
            if (TR)
            {
                Invoke("ENGisOnFalse",0);
                TR = false;
            }

            DilAyari = 0;
            PlayerPrefs.SetInt("DilAyari", DilAyari);

            DiliniSecYazisi.text = "Dil Ayarları";

            Turkish.SetActive(true);
            English.SetActive(false);
        }
        if (Ingilizce.isOn == true)
        {
            if (ENG)
            {
                Invoke("TRisOnFalse", 0);
                ENG = false;
            }

            DilAyari = 1;
            PlayerPrefs.SetInt("DilAyari", DilAyari);

            DiliniSecYazisi.text = "Language Settings";

            Turkish.SetActive(false);
            English.SetActive(true);
        }

        if (DilAyari == 0)
        {
            if (!ENG)
            {
                Turkce.isOn = true;
            }
        }
        else if (DilAyari == 1)
        {
            if (!TR)
            {
                Ingilizce.isOn = true;
            }
        }
    }

    void ENGisOnFalse()
    {
        Ingilizce.isOn = false;
    }
    void TRisOnFalse()
    {
        Turkce.isOn = false;
    }

    public void TurkishClick()
    {
        Ingilizce.isOn = true;
        Turkce.isOn = false;
    }
    public void EnglishClick()
    {
        Ingilizce.isOn = false;
        Turkce.isOn = true;
    }

    public void TurkceClick()
    {
        TR = true;
        ENG = false;
    }
    public void IngilizceClick()
    {
        ENG = true;
        TR = false;
    }

    void OnGUI() { 
    if (GUI.Button(Fonksiyonlar.EkranBoyut(0.98f, 0.98f, 0.08f, 0.14f), "", AnaMenuDonus)){

            SceneManager.LoadScene(AnaMenuIsmi);
        }
    }
}
