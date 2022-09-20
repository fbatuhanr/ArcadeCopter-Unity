using UnityEngine;
using System.Collections;

public class Fonksiyonlar : MonoBehaviour {
    public static new Rect EkranBoyut(float top, float left, float width, float height)
    {
     return new Rect (Screen.width * 0.5f - Screen.width * top * 0.5f, Screen.height * 0.5f - Screen.height * left * 0.5f, Screen.width * width, Screen.height * height);
    }
    public static void YaziAyarlar(Font Fontunuz, int FontBoyutunuz, Color yazirengi) {

        GUI.skin.box.font = Fontunuz;
        GUI.skin.box.fontSize = FontBoyutunuz;
        GUI.skin.box.normal.background = null;
        GUI.skin.box.normal.textColor = yazirengi;

    }
    public static void Menu(Font OyunIsmiFont, Color OyunIsmiFontRengi)
    {

        GUI.skin.box.font = OyunIsmiFont;
        GUI.skin.box.normal.background = null;
        GUI.skin.box.normal.textColor = OyunIsmiFontRengi;
    }

    public static void Hiz1()
    {
        HelikopterAyari.EtkilesimdeHiz = 20.0f;
        HelikopterAyari.EtkilesimsizHiz = 15.0f;
        HelikopterAyari.PervaneGucu = 25.0f;
        HelikopterAyari.PervaneAzalma = -20.0f;
    }

    public static void Hiz2()
    {
        HelikopterAyari.EtkilesimdeHiz = 20.0f;
        HelikopterAyari.EtkilesimsizHiz = 15.0f;
        HelikopterAyari.PervaneGucu = 25.0f;
        HelikopterAyari.PervaneAzalma = -20.0f;
    }
    public static void Hiz3()
    {
        HelikopterAyari.EtkilesimdeHiz = 20.0f;
        HelikopterAyari.EtkilesimsizHiz = 15.0f;
        HelikopterAyari.PervaneGucu = 25.0f;
        HelikopterAyari.PervaneAzalma = -20.0f;
    }
}
