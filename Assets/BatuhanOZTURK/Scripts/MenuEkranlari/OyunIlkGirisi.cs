using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunIlkGirisi : MonoBehaviour {

    public GameObject[] SolSag_OK;
    public GameObject TRTR, ENEN;
    public Image TR,EN;
    public Text Dil,Language;

    public Button solBut,SagBut;
    public Image SolButIMG, SagButIMG;

    Color SonukRenk  = new Vector4( 1, 1, 1, 0.1f);

    bool SagdakineTikanirsa;
    bool SoldakineTiklanirsa;
    int SagaKaydir;
    int SolaKaydir;

    public static string DilSecYazisi;

    public string AnaMenuyeGit;

    void Start () {

        AyarlarMenu.DilAyari = 0; // Cunku ilk basta TURK BAYRAGI 
        PlayerPrefs.SetInt("DilAyari", AyarlarMenu.DilAyari);

        TRTR.SetActive(true);
        ENEN.SetActive(false);

        solBut.interactable = false;
        SagBut.interactable = true;

        SolButIMG.color = SonukRenk;
        SagButIMG.color = Color.white;
        
    }

    void Update()
    {
        solBut.enabled = true;
        SagBut.enabled = true;

        AyarlarMenu.DilAyari = PlayerPrefs.GetInt("DilAyari");

        if (AyarlarMenu.DilAyari == 0)
        {
            Dil.text = "Dil";
            Language.text = "Language";
            Dil.fontSize = Screen.width / 14;
            Language.fontSize = Screen.width / 14;
            Dil.color = Color.red;
            Language.color = Color.black;
        }
        else
        {
            Dil.text = "Dil";
            Language.text = "Language";
            Dil.fontSize = Screen.width / 14;
            Language.fontSize = Screen.width / 14;
            Dil.color = Color.black;
            Language.color = Color.red;
        }
       
    }

    public void Sagdaki()
    {
        AyarlarMenu.DilAyari = 1;
        PlayerPrefs.SetInt("DilAyari", AyarlarMenu.DilAyari);

        ENEN.SetActive(true);
        TRTR.SetActive(false);

        solBut.interactable = true;
        SagBut.interactable = false;

        SolButIMG.color = Color.white;
        SagButIMG.color = SonukRenk;
    }
    public void Soldaki()
    {
        AyarlarMenu.DilAyari = 0;
        PlayerPrefs.SetInt("DilAyari", AyarlarMenu.DilAyari);

        ENEN.SetActive(false);
        TRTR.SetActive(true);

        solBut.interactable = false;
        SagBut.interactable = true;

        SolButIMG.color = SonukRenk;
        SagButIMG.color = Color.white;
    }
    
    public void TUR()
    {
        AyarlarMenu.DilAyari = 0;
        PlayerPrefs.SetInt("DilAyari", AyarlarMenu.DilAyari);

        SceneManager.LoadScene(AnaMenuyeGit);
    }
    public void ENG()
    {
        AyarlarMenu.DilAyari = 1;
        PlayerPrefs.SetInt("DilAyari", AyarlarMenu.DilAyari);

        SceneManager.LoadScene(AnaMenuyeGit);
    }
}
