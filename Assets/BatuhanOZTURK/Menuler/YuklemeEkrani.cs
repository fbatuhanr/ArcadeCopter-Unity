using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YuklemeEkrani : MonoBehaviour {

    public Text FBRGames,ArcadeCopter,YuzdeYukleniyor;

    public static bool Gecis;

    public string MenuGec;
    public string DilSec;

    public static int i;
    void Start()
    {
        // ReklamAyar.BannerReklamGoster();
    }
    void Update()
    {
        AnaMenu.OyunaIlkGiris = PlayerPrefs.GetInt("OyunaIlkGiris");

        Time.timeScale = 1;

        FBRGames.fontSize = Screen.width / 12;
        ArcadeCopter.fontSize = Screen.width / 12;
        YuzdeYukleniyor.fontSize = Screen.width / 20;

        i = 1;
        if (Gecis)
        {
            if (AnaMenu.OyunaIlkGiris == 1) {
                SceneManager.LoadScene(MenuGec);
            }
            else
            {
                SceneManager.LoadScene(DilSec);
                GunlukBonusOdul.TarihAy = System.DateTime.Now.Month;
                GunlukBonusOdul.TarihGun = System.DateTime.Now.Day;
                GunlukBonusOdul.TarihYil = System.DateTime.Now.Year;

                PlayerPrefs.SetInt("OyunaIlkGirilisYili", GunlukBonusOdul.TarihYil);
                PlayerPrefs.SetInt("OyunaIlkGirilisAyi", GunlukBonusOdul.TarihAy);
                PlayerPrefs.SetInt("OyunaIlkGirilisGunu", GunlukBonusOdul.TarihGun);
            }
        }
    }
}
