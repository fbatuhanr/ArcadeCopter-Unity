using UnityEngine;
using System.Collections;

public class HelikopterAyariSonsuzMod : MonoBehaviour
{
    public GameObject HeliPervSesi;
    public AudioSource HelikopterPervaneSesi, Ses;
    public AudioClip ParaToplamaSesi;
    public GUIStyle GeriSayimStil;
    public Transform Helikopter;
    public Animator HeliAnimatoru, KameraAnimatoru;
    static Rigidbody HelikopterOtoHareket, HelikopterHavalanmasi;

    public static float GeriSayim;
    public static float PervGucu, PervAzalma, Dokununca, Dokunmayinca;

    public static int YanmaSayaci;
    bool Goster;
    public static bool Animle;

    void Start()
    {
        HelikopterPervaneSesi.pitch = 0.2f;
        HelikopterPervaneSesi.volume = 0.0f;

        Animle = false;
        YanmaSayaci = 0;
        PlayerPrefs.SetInt("YanmaSayaci", YanmaSayaci);

        HelikopterOtoHareket = GetComponent<Rigidbody>();
        HelikopterHavalanmasi = GetComponent<Rigidbody>();

        PervGucu = 0;
        PervAzalma = 0;
        Dokununca = 0;
        Dokunmayinca = 0;

        GeriSayim = 3.2f;

        AudioListener.volume = 0;

        AyarlarMenu.MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");
        AyarlarMenu.MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");
    }

    void FixedUpdate()
    {
        AyarlarMenu.MuteMuzik = PlayerPrefs.GetInt("MuteMuzik");
        AyarlarMenu.MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");

        if (transform.position.x > -110 && transform.position.x < -75)
        {
            if (HelikopterPervaneSesi.pitch < 0.85f)
            {
                HelikopterPervaneSesi.pitch += 0.01f;
            }
            if (HelikopterPervaneSesi.volume < 0.8f)
            {
                HelikopterPervaneSesi.volume += 0.01f;
            }
        }

        if (AyarlarMenu.MuteHeliSFX == 0)
        {
            HeliPervSesi.SetActive(true);
        }
        else
        {
            HeliPervSesi.SetActive(false);
        }

        otoyol.BolumluMod = false;

        GeriSayimStil.fontSize = Screen.width / 4;
        if (AyarlarMenu.MuteMuzik == 0 || AyarlarMenu.MuteHeliSFX == 0) { 
        if (AudioListener.volume < 1.0f)
        {
            AudioListener.volume += 0.002f;
        }

        if (OyuncuAyar.OyunBitti)
        {
            if (AudioListener.volume > 0.3f)
            {
                AudioListener.volume -= 0.015f;
            }
        }
        if (OyuncuAyar.OyunDalgaDevamSesArttir)
        {
            if (AudioListener.volume < 1.0f)
            {
                AudioListener.volume += 0.015f;
            }
        }

        if (OyuncuAyar.DurdurmaMenusu)
        {
            if (AudioListener.volume > 0.0f)
            {
                AudioListener.volume -= 0.015f;
            }
            if (AudioListener.volume <= 0.025f)
            {
                AudioListener.pause = true;
            }
        }
        if (OyuncuAyar.OyunDevamSesArttir)
        {
            AudioListener.pause = false;

            if (AudioListener.volume < 1.0f)
            {
                AudioListener.volume += 0.015f;
            }
        }
        }
        else
        {
            AudioListener.volume = 0;
        }


        if (Helikopter.transform.position.x >= -95.0 && Helikopter.transform.position.x <= -53.0f)
        {
            if (GeriSayim > 0)
            {
                GeriSayim -= Time.deltaTime;
            }
            if (GeriSayim > 0.2f)
            {
                Goster = true;
            }
            else
            {
                Goster = false;             
            }
        }
        if (!OyuncuAyar.OyunBitti || !OyuncuAyar.DurdurmaMenusu) {
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

        if (Input.GetKeyDown(KeyCode.Escape) && !OyuncuAyar.HelikopterYanma)
        {
            OyuncuAyar.DurdurulmaHareket = true;
            OyuncuAyar.DurdurulmaPervane = true;
            OyuncuAyar.DurdurmayaBasincaSayacDur = true;
            OyuncuAyar.DurdurmaMenusu = true;

            OyuncuAyar.OyunDevamSesArttir = false;
            OyuncuAyar.OyunDalgaDevamSesArttir = false;
        }


        if (OyuncuAyar.DurdurmaMenusu || OyuncuAyar.OyunBitti)
        {
            HelikopterHavalanmasi.constraints = RigidbodyConstraints.FreezeAll;
            PervGucu = 0;
            PervAzalma = 0;
            Dokununca = 0;
            Dokunmayinca = 0;
        }
        else if (Helikopter.transform.position.x >= -59.8f && !OyuncuAyar.DurdurmaMenusu && !OyuncuAyar.OyunBitti && !SnszModOyunMenusu.HelikopteriYukariyaTasi)
        {
            PervGucu = 27.5f;
            PervAzalma = -22.5f;
            Dokununca = 17.5f;
            Dokunmayinca = 17.5f;

            if (HelikopterHavalanmasi.constraints == RigidbodyConstraints.FreezeAll)
            {
                HelikopterHavalanmasi.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            }
        }
        else if (SnszModOyunMenusu.HelikopteriYukariyaTasi)
        {
            if (GeriSayim > 0)
            {
                GeriSayim -= Time.deltaTime;
            }
            if (GeriSayim > 0.2f)
            {
                Goster = true;
            }
            else
            {
                Goster = false;
                Animle = true;
                SnszModOyunMenusu.HelikopteriYukariyaTasi = false;
            }

            PervGucu = 0;
            PervAzalma = 0;
            Dokununca = 20.0f;
            Dokunmayinca = 10.0f;

            if (HelikopterHavalanmasi.constraints == RigidbodyConstraints.FreezeAll)
            {
                HelikopterHavalanmasi.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            }
        }

        if (Helikopter.transform.position.x >= -59.8 && !OyuncuAyar.DurdurmaMenusu && !OyuncuAyar.OyunBitti && !SnszModOyunMenusu.HelikopteriYukariyaTasi)
        {
            PervGucu = 27.5f;
            PervAzalma = -22.5f;
            Dokununca = 17.5f;
            Dokunmayinca = 17.5f;

            // HeliAnimatoru.Stop();
            HeliAnimatoru.enabled = false;
            
            // KameraAnimatoru.Stop();
            KameraAnimatoru.enabled = false;
        }
            if (Input.GetMouseButton(0))
            {
                HelikopterOtoHareket.velocity = new Vector2(Dokununca, HelikopterOtoHareket.velocity.y);
                HelikopterHavalanmasi.AddForce(new Vector3(0, PervGucu, 0));

            if (transform.eulerAngles.x > 345 && transform.position.x > -44.5f)
            {
                if (OyuncuAyar.DurdurmaMenusu || OyuncuAyar.OyunBitti)
                {
                    transform.Rotate(0, 0, 0);
                }
                else
                {
                    transform.Rotate(-0.7f, 0, 0);

                    if (HelikopterPervaneSesi.pitch < 1.0f)
                    {
                        HelikopterPervaneSesi.pitch += 0.005f;
                    }
                    if (HelikopterPervaneSesi.volume < 0.85f)
                    {
                        HelikopterPervaneSesi.volume += 0.005f;
                    }
                }
               }
              }
            else
            {
                HelikopterOtoHareket.velocity = new Vector2(Dokunmayinca, HelikopterOtoHareket.velocity.y);
                HelikopterHavalanmasi.AddForce(new Vector3(0, PervAzalma, 0));

                if (transform.eulerAngles.x < 359 && transform.position.x > -44.5f)
                {
                if (OyuncuAyar.DurdurmaMenusu || OyuncuAyar.OyunBitti)
                {
                    transform.Rotate(0, 0, 0);
                }
                else
                {
                    transform.Rotate(0.7f, 0, 0);

                    if (HelikopterPervaneSesi.pitch > 0.85f)
                    {
                        HelikopterPervaneSesi.pitch -= 0.005f;
                    }
                    if (HelikopterPervaneSesi.volume > 0.8f)
                    {
                        HelikopterPervaneSesi.volume -= 0.005f;
                    }
                }
            }
        }      
        
}
    void OnCollisionEnter(Collision dokunursa)
    {
        if (dokunursa.gameObject.tag == "KarakterYandi")
        {
            HelikopterPervaneSesi.volume = 0;
            SnszModOyunMenusu.MevcutBedeldenBuyukse = false;
            SnszModOyunMenusu.ToplamParayaAta = true;
            Animle = false;
            OyuncuAyar.HelikopterYanma = true;
            OyuncuAyar.OyunBitti = true;

            YanmaSayaci += 1;
        }
    }
    void OnCollisionExit(Collision ayrilirsa)
    {
        if (ayrilirsa.gameObject.tag == "KarakterYandi")
        {
            HelikopterPervaneSesi.pitch = 0.85f;
            HelikopterPervaneSesi.volume = 0.8f;
            OyuncuAyar.HelikopterYanma = false;
        }
    }

    void OnTriggerEnter(Collider temas)
    {
        if (temas.gameObject.tag == "yoluzat1" || temas.gameObject.tag == "yoluzat2" || temas.gameObject.tag == "yoluzat3")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<otoyol>().YolTemas = true;
        }
        else if (temas.gameObject.tag == "SonsuzModObj")
        {   
            SonsuzModRandomObje.IleriyeAta = true;
        }
        else if (temas.gameObject.tag == "SonsuzModObj2")
        {
            SonsuzModRandomObje2.IleriyeAta2 = true;
        }
        else if (temas.gameObject.tag == "SonsuzModObj3")
        {
            SonsuzModRandomObje3.IleriyeAta3 = true;
        }
        else if (temas.gameObject.tag == "SonsuzModBoslukluEngeller")
        {
            BoslukluEngelSnszMod.TemasOlayi = true;
        }
        else if (temas.gameObject.tag == "skorkap")
        {
            OyuncuAyar.Skor += 1;
            //  PuanArtisYazisi.SetActive(true); 
        }
        else if (temas.gameObject.tag == "goldmoney")
        {
            Ses.PlayOneShot(ParaToplamaSesi, 1);

            OyuncuAyar.Para += 1;

            temas.gameObject.transform.parent.gameObject.GetComponent<Para_Ayarlari>().TemasOlayi = true;
        }
        else if (temas.gameObject.tag == "goldmoney1")
        {
            Ses.PlayOneShot(ParaToplamaSesi, 1);

            OyuncuAyar.Para += 2;

            temas.gameObject.transform.parent.gameObject.GetComponent<Para_Ayarlari>().TemasOlayi = true;
        }
    }

        void OnGUI()
    {
        if (Goster)
        {
            GUI.Box(Fonksiyonlar.EkranBoyut(1, 1, 1, 1),GeriSayim.ToString("F0"), GeriSayimStil);
        }
    }
}
