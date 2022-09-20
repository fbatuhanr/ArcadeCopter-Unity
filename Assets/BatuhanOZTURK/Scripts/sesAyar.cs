using UnityEngine;
using System.Collections;

public class sesAyar : MonoBehaviour
{
    public AudioSource BGSound;

    public AudioClip[] sesler;
    public static bool SonDalgaMusic;
    public static bool SonDalgaSesAsagiya;
    public static bool SonDalgaSesYukariya;

    void Start()
    {
        SonDalgaMusic = false;
        SonDalgaSesAsagiya = false;
        SonDalgaSesYukariya = false;

        AyarlarMenu.MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");

        BGSound.clip = sesler[0];


        if (AyarlarMenu.MuteMuzik == 0)
        {
            BGSound.volume = 0;
            BGSound.Play();
        }
        else
        {
            BGSound.Stop();
        }

        BGSound.time = 4.0f;

    }
    void Update()
    {

        if (AyarlarMenu.MuteMuzik == 0)
        {
            // Baslangic

            if (BGSound.volume < 1.0f)
            {
                BGSound.volume += 0.002f;
            }

            if (OyuncuAyar.OyunBitti)
            {
                if (BGSound.volume > 0.3f)
                {
                    BGSound.volume -= 0.015f;
                }
            }
            if (OyuncuAyar.OyunDalgaDevamSesArttir)
            {
                if (BGSound.volume < 1.0f)
                {
                    BGSound.volume += 0.015f;
                }
            }

            if (OyuncuAyar.DurdurmaMenusu)
            {
                if (BGSound.volume > 0.0f)
                {
                    BGSound.volume -= 0.015f;
                }
                if (BGSound.volume <= 0.025f)
                {
                    AudioListener.pause = true;
                }
            }
            if (OyuncuAyar.OyunDevamSesArttir)
            {
                AudioListener.pause = false;

                if (BGSound.volume < 1.0f)
                {
                    BGSound.volume += 0.015f;
                }
            }

            // SON DALGA MUSİCcC-
            if (SonDalgaMusic)
            {

                Invoke("SonDalgaSarkisi", 0);
                SonDalgaMusic = false;
            }

            if (SonDalgaSesAsagiya)
            {
                if (BGSound.volume >= 0.0f)
                {
                    BGSound.volume -= 0.004f;
                }
            }
            if (SonDalgaSesYukariya)
            {
                if (BGSound.volume < 1.0f)
                {
                    BGSound.volume += 0.005f;
                }
            }
        }
    }
    void SonDalgaSarkisi()
    {
        BGSound.volume = 0;
        BGSound.clip = sesler[1];
        BGSound.Play();
    }
}
