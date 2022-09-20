using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelikopterAyari : MonoBehaviour
{
    public GameObject HeliPervSesi;
    public AudioSource HelikopterPervaneSesi;

    float SadeceIleriGeriAnimSuresiRotate = 10.0f;
    float SadeceIleriGeriAnimSuresi = 6.0f;
    float SadeceIleriGeri = 0.0f;

    public GameObject[] TegetNoktasi;
    public Material[] GoldSilverOnTexture;

    public Animator HeliAnim;
    public Animator KameraAnim;

    public GameObject SilahveMontaj;
    public GameObject SilahTasiyicisi;
    public Animator SilahMontaj;
    public static bool SilahMontajKamera;
    public static float KameraX;
    public static float KameraZ;

    public GameObject BaslangicParkuru;
    public GameObject ip1;
    public GameObject ip2;
    public GameObject asansor;
    public GameObject HelikopterTasiyicisi;

    public Transform Pervane;

    static Rigidbody oto;

    public static float EtkilesimdeHiz;
    public static float EtkilesimsizHiz;

    static Rigidbody havalan;
    public static float PervaneGucu;
    public static float PervaneAzalma;

    public static float GeriSayim = 3.0f;
    public static bool GeriSayimiGoster;

    public static float SkorArtisGeriSayim = 3.0f;
    public static float HizlanimicinGeriSayim = 3.0f;
    public static bool HizlanmaGeriSayiminaBasla;

    public static float BaslangicSayiSay;

    public GameObject KarsilikliCisim1;
    public GameObject KarsilikliCisim2;
    public GameObject KarsilikliCisim3;
    public GameObject KarsilikliCisim4;

    public static bool TraileBasla;
    void Start()
    {
        SnszModOyunMenusu.HelikopteriYukariyaTasi = false;

        HelikopterPervaneSesi.pitch = 0.0f;
        HelikopterPervaneSesi.volume = 0.0f;
 

        otoyol.BolumluMod = true;

        TraileBasla = false;
        SadeceIleriGeriAnimSuresiRotate = 10.0f;
        SadeceIleriGeriAnimSuresi = 6.0f;
        SadeceIleriGeri = 0.0f;

        SilahMontaj.speed = 0.0f;
        SilahMontajKamera = false;
        SilahveMontaj.SetActive(false);
        KameraX = 9;
        KameraZ = -25.25f;

        ip1.SetActive(true);
        ip2.SetActive(true);
        asansor.SetActive(true);
        HelikopterTasiyicisi.SetActive(true);

        GeriSayimiGoster = false;
        BaslangicSayiSay = 3.0f;

        Time.timeScale = 1;

        oto = GetComponent<Rigidbody>();
        havalan = GetComponent<Rigidbody>();

        HizlanmaGeriSayiminaBasla = false;

        AyarlarMenu.MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");
    }

    void FixedUpdate()
    {
        if (AyarlarMenu.MuteHeliSFX == 0)
        {
            HeliPervSesi.SetActive(true);
        }
        else
        {
            HeliPervSesi.SetActive(false);
        }

        if (transform.position.x > -80.0f)
        {
            if (BaslangicSayiSay <= 3.0f && BaslangicSayiSay >= 0.6f)
            {
                GeriSayimiGoster = true;
                BaslangicSayiSay -= Time.deltaTime;
            }
            else if (BaslangicSayiSay < 0.6f)
            {
                GeriSayimiGoster = false;
            }
        }

        if (transform.position.x > -71.0f)
        {
            ip1.SetActive(false);
            ip2.SetActive(false);
            asansor.SetActive(false);
        }
        if (transform.position.x > -40.15f)
        {
            TraileBasla = true;
            HelikopterTasiyicisi.SetActive(false);
        }
        if (transform.position.x > 0.0f)
        {
            Destroy(BaslangicParkuru);
        }


        if (OyuncuAyar.Skor >= 0 && OyuncuAyar.Skor < 10)
        {
            if (transform.position.x > -44.5f)
            {
                // HeliAnim.Stop();
                HeliAnim.enabled = false;
                // KameraAnim.Stop();
                KameraAnim.enabled = false;
                
                EtkilesimdeHiz = 20.0f;
                EtkilesimsizHiz = 15.0f;
                PervaneGucu = 30.0f;
                PervaneAzalma = -30.0f;
            }     
            else
            {
                EtkilesimdeHiz = 0;
                EtkilesimsizHiz = 0;
                PervaneGucu = 0;
                PervaneAzalma = 0;
            }
        }
        else if (OyuncuAyar.Skor >= 10)
        {
            EtkilesimdeHiz = 20.0f;
            EtkilesimsizHiz = 15.0f;
            PervaneGucu = 30.0f;
            PervaneAzalma = -30.0f;
        }

        if (OyuncuAyar.Skor >= 39)
        {
            Engel_Karsilikli.EngelKarsilikliBitisi = true;
        }

        if (transform.position.x >= 3000)
        {
            Engel_DonenSilindir.EngelDonenSilindirBitisi = true;
        }   

        // Ikinci ENGEL Geliyor true ise helikopteri ORTALA
        if (OyuncuAyar.IkinciEngelGeliyor)
        {
            EtkilesimdeHiz = 15.0f;
            EtkilesimsizHiz = 15.0f;
            PervaneGucu = 0.0f;
            PervaneAzalma = 0.0f;

            if (transform.position.x < 1750) { 
                if (transform.position.y < 7.0f)
                {
                    transform.position = transform.position + new Vector3(0, 0.1f, 0);
                }
                else if (transform.position.y >= 7.5f)
                {
                    transform.position = transform.position + new Vector3(0, -0.1f, 0);
                }
            }
            else if (transform.position.x >= 1750 && transform.position.x < 2400)
            {
                if (transform.position.y < 31.25f)
                {
                    transform.position = transform.position + new Vector3(0, 0.1f, 0);
                }
                else if (transform.position.y >= 31.75f)
                {
                    transform.position = transform.position + new Vector3(0, -0.1f, 0);
                }
            }
            else if (transform.position.x >= 2400 )
            {
                if (transform.position.y < 7.0f)
                {
                    transform.position = transform.position + new Vector3(0, 0.1f, 0);
                }
                else if (transform.position.y >= 7.5f)
                {
                    transform.position = transform.position + new Vector3(0, -0.1f, 0);
                }
            }
        }


        // DALGA AYARI ---------------------------------------------------------

        if (transform.position.x >= 900 && transform.position.x <= 980)
        {
            if (transform.position.x >= 930)
            {
                OyuncuAyar.YeniDalga = true;
                if (GeriSayim >= 0)
                {
                    GeriSayim -= Time.deltaTime;
                }
                else if (GeriSayim < 1.0f)
                {
                    OyuncuAyar.YeniDalga = false;        
                }
            }
            OyuncuAyar.IkinciEngelGeliyor = true;
           if (OyuncuAyar.IkinciEngelGeliyor)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
          }
        }
        else if (transform.position.x > 980 && transform.position.x < 1780)
        {
            if (EtkilesimdeHiz > 0.0f)
            {
                EtkilesimdeHiz -= 0.1f;
            }
            if (EtkilesimsizHiz > 0.0f)
            {
                EtkilesimsizHiz -= 0.1f;
            }
            OyuncuAyar.IkinciEngelGeliyor = false;
            if (OyuncuAyar.IkinciEngelGeliyor == false)
            {
                transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
            }
        }

        if (transform.position.x >= 980 && transform.position.x <= 1780)
        {
            OyuncuAyar.IkinciDalgaGucu = true;
        }
        else if (transform.position.x > 1780)
        {
            OyuncuAyar.IkinciDalgaGucu = false;
        }


        if (OyuncuAyar.DurdurmaMenusu || OyuncuAyar.OyunBitti) {

        }
        else { 
        if (OyuncuAyar.IkinciDalgaGucu)
        {
            // ANIM BASLANGIC
            if (SadeceIleriGeriAnimSuresi >= 0.0f)
            {
                SadeceIleriGeriAnimSuresi -= Time.deltaTime * 2.0f;
            }
            if (SadeceIleriGeriAnimSuresiRotate >= 0.0f)
            {
                SadeceIleriGeriAnimSuresiRotate -= Time.deltaTime * 2.0f;
            }
            //
            if (SadeceIleriGeriAnimSuresi <= 0.0f)
            {
                SadeceIleriGeriAnimSuresi = 6.0f;
            }
            if (SadeceIleriGeriAnimSuresiRotate <= 0.0f)
            {
                SadeceIleriGeriAnimSuresiRotate = 10.0f;
            }
            //

            if (SadeceIleriGeriAnimSuresi <= 6.0f && SadeceIleriGeriAnimSuresi > 3.0f)
            {
                transform.position = transform.position + new Vector3(0, 0.004f, 0);
            }
            else if (SadeceIleriGeriAnimSuresi <= 3.0f && SadeceIleriGeriAnimSuresi >= 0.0f)
            {
                transform.position = transform.position + new Vector3(0, -0.004f, 0);
            }

            if (SadeceIleriGeriAnimSuresiRotate <= 10.0f && SadeceIleriGeriAnimSuresiRotate > 8.0f)
            {
                transform.Rotate(0, 0, +0.075f);
            }
            else if (SadeceIleriGeriAnimSuresiRotate <= 8.0f && SadeceIleriGeriAnimSuresiRotate > 6.0f)
            {
                transform.Rotate(0, 0, -0.15f);
            }
            else if (SadeceIleriGeriAnimSuresiRotate <= 6.0f && SadeceIleriGeriAnimSuresiRotate > 4.0f)
            {
                transform.Rotate(0, 0, +0.15f);
            }
            else if (SadeceIleriGeriAnimSuresiRotate <= 4.0f && SadeceIleriGeriAnimSuresiRotate >= 2.0f)
            {
                transform.Rotate(0, 0, -0.15f);
            }
            else if (SadeceIleriGeriAnimSuresiRotate <= 2.0f && SadeceIleriGeriAnimSuresiRotate >= 0.0f)
            {
                transform.Rotate(0, 0, +0.075f);
            }
                // ANIM BITIS

                EtkilesimdeHiz = 0;
                EtkilesimsizHiz = 0;
                PervaneGucu = 0;
                PervaneAzalma = 0;
         }
        }

        // DALGA 3

        if (transform.position.x >= 1780 && transform.position.x <= 1850)
        {
             if (transform.position.x <= 1785)
            {
                GeriSayim = 3;
            }

            if (transform.position.x >= 1800)
            {
                OyuncuAyar.YeniDalga = true;
                if (GeriSayim >= 0)
                {
                    GeriSayim -= Time.deltaTime;
                }
                else if (GeriSayim < 1.0f)
                {
                    OyuncuAyar.YeniDalga = false;

                }
            }

            OyuncuAyar.IkinciEngelGeliyor = true;
            if (OyuncuAyar.IkinciEngelGeliyor)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }

        else if (transform.position.x > 1850 && transform.position.x < 2490)
        {
            GeriSayim = 3;
            OyuncuAyar.IkinciEngelGeliyor = false;
            if (OyuncuAyar.IkinciEngelGeliyor == false)
            {
                transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
            }
            Fonksiyonlar.Hiz1();
        }


        // DALGA 4 

        if (transform.position.x >= 2490 && transform.position.x <= 2580)
        {
            if (transform.position.x < 2505)
            {
                GeriSayim = 3;
            }

            if (transform.position.x >= 2530)
            {
                OyuncuAyar.YeniDalga = true;
                if (GeriSayim >= 0)
                {
                    GeriSayim -= Time.deltaTime;
                }
                else if (GeriSayim < 1.0f)
                {
                    OyuncuAyar.YeniDalga = false;

                }
            }

            OyuncuAyar.IkinciEngelGeliyor = true;
            if (OyuncuAyar.IkinciEngelGeliyor)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }

        else if (transform.position.x > 2580 && transform.position.x < 3090)
        {
            GeriSayim = 3;
            OyuncuAyar.IkinciEngelGeliyor = false;
            if (OyuncuAyar.IkinciEngelGeliyor == false)
            {
                transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
            }
            Fonksiyonlar.Hiz1();
        }
        //



        // DALGA 5

        if (transform.position.x >= 3090 && transform.position.x <= 3300)
        {
            if (transform.position.x < 3095)
            {
                GeriSayim = 3;
            }
            if (transform.position.x >= 3200 && transform.position.x < 3245)
            {
                SilahveMontaj.SetActive(true);
                SilahMontaj.speed = 1.0f;

                SilahMontajKamera = true;
                if (SilahMontajKamera) {
                if (KameraAyar.z <= -12.5f)
                {
                        KameraAyar.z += 0.1f;
                }
                if (KameraAyar.x >= 4.0f)
                   {
                        KameraAyar.x -= 0.1f;
                   }
                }
            }
            else if (transform.position.x >= 3245)
            {
                if (KameraAyar.x <= 9.0f)
                {
                    KameraAyar.x += 0.05f;
                }
                if (KameraAyar.z >= -25.25f)
                {
                    KameraAyar.z -= 0.1f;
                }      
            }
            if (transform.position.x >= 3270)
            {
                SilahTasiyicisi.SetActive(false);
            }

            if (transform.position.x >= 3250)
            {
                OyuncuAyar.YeniDalga = true;
                if (GeriSayim >= 0)
                {
                    GeriSayim -= Time.deltaTime;
                }
                else if (GeriSayim < 1.0f)
                {
                    OyuncuAyar.YeniDalga = false;
                }
            }
            OyuncuAyar.IkinciEngelGeliyor = true;
            if (OyuncuAyar.IkinciEngelGeliyor)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }
        else if (transform.position.x > 3300)
        {
            GeriSayim = 3;     
            OyuncuAyar.BesinciDalgaGucu = true;
            OyuncuAyar.IkinciEngelGeliyor = false;
            if (OyuncuAyar.IkinciEngelGeliyor == false)
            {
                transform.position = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
            }
            Fonksiyonlar.Hiz1();
        }


        if (OyuncuAyar.BesinciDalgaGucu)
        {
            PervaneGucu = 0;
            PervaneAzalma = 0;
            EtkilesimdeHiz = 15;
            EtkilesimsizHiz = 15;
        }


        // DALGA AYARI BİTİŞ ---------------------------------------------------------------------

        if (Input.GetKeyDown(KeyCode.Escape) && !OyuncuAyar.HelikopterYanma)
        {
            OyuncuAyar.DurdurulmaHareket = true;
            OyuncuAyar.DurdurulmaPervane = true;
            OyuncuAyar.DurdurmayaBasincaSayacDur = true;
            OyuncuAyar.DurdurmaMenusu = true;

            OyuncuAyar.OyunDevamSesArttir = false;
            OyuncuAyar.OyunDalgaDevamSesArttir = false;
        }

        if (transform.position.x > -88.8f && transform.position.x < -44.5f)
        {
            if (HelikopterPervaneSesi.pitch < 0.85f)
            {
                HelikopterPervaneSesi.pitch += 0.005f;
            }
            if (HelikopterPervaneSesi.volume < 0.8f)
            {
                HelikopterPervaneSesi.volume += 0.005f;
            }
        }

        // EKRANA TIKLANINCA
        if (Input.GetMouseButton(0))
        {           
            // PAUSE BASILMADIGINDA HELİKOPTER HAREKETİ *-*-*-*-*-*-*-*
            if (OyuncuAyar.DurdurulmaPervane == false)
            {
                if (transform.eulerAngles.x > 345 && transform.position.x > -44.5f)
                {
                    if (OyuncuAyar.IkinciEngelGeliyor || OyuncuAyar.OyunBitti || OyuncuAyar.BesinciDalgaGucu)
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

                //  HELI SADECE ILERI - HIZLANMA | BASLANGIC
                if (OyuncuAyar.IkinciDalgaGucu)
                {
                   if (SadeceIleriGeri < 0.5f)
                    {
                     SadeceIleriGeri += 0.0075f; 
                    }
                    if (transform.position.x >= 1750 && transform.position.x <= 1800)
                    {
                        if (transform.position.y <= 31.25f)
                        {
                            transform.position = transform.position + new Vector3(0, SadeceIleriGeri, 0);
                        }
                    }
                    transform.position = transform.position + new Vector3(SadeceIleriGeri, 0, 0);
                    }

                //  HELI SADECE ILERI - HIZLANMA | BITIS

                oto.velocity = new Vector2(EtkilesimdeHiz, oto.velocity.y);
                havalan.AddForce(new Vector3(0, PervaneGucu, 0));
                Time.timeScale = 1;
                if (havalan.constraints == RigidbodyConstraints.FreezeAll) { 
                havalan.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;           
                }
            }
            // PAUSE BASILDIĞINDA HELİKOPTER HAREKETİ *-*-*-*-*-*-*-*
            else
            {
                if (transform.eulerAngles.x > 345)
                {
                transform.Rotate(0, 0, 0);
                }

                oto.velocity = new Vector2(0, oto.velocity.y);
                havalan.AddForce(new Vector3(0, 0, 0));
                havalan.constraints = RigidbodyConstraints.FreezeAll;
                Time.timeScale = 0;
                transform.Rotate(0, 0, 0);
            }
        }

        // EKRANDAN TIKLAMA YAPILMAYINCA
        else
        {
            // PAUSE BASILMADIGINDA HELİKOPTER HAREKETİ *-*-*-*-*-*-*-*
       if (OyuncuAyar.DurdurulmaHareket == false) {

            //  HELI SADECE ILERI - YAVASLAMA | BASLANGIC
                if (OyuncuAyar.IkinciDalgaGucu)  {
                    if (transform.position.x >= 980 && transform.position.x < 990)
                    {
                        SadeceIleriGeri = 0.02f;
                    }
                    if (SadeceIleriGeri > 0.02f)
                     {
                        SadeceIleriGeri -= 0.0125f;
                    }
                    if (transform.position.x >= 1750 && transform.position.x <= 1800)
                    {
                        if (transform.position.y <= 31.25f)
                        {
                            transform.position = transform.position + new Vector3(0, SadeceIleriGeri, 0);
                        }
                    }
                    transform.position = transform.position + new Vector3(SadeceIleriGeri, 0, 0);
                    }                
                
           // HELI SADECE ILERI - YAVASLAMA | BITIS

           if (transform.eulerAngles.x < 359 && transform.position.x > -44.5f)
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
              oto.velocity = new Vector2(EtkilesimsizHiz, oto.velocity.y);
              havalan.AddForce(new Vector3(0, PervaneAzalma, 0));
                Time.timeScale = 1;
                    
           if (havalan.constraints == RigidbodyConstraints.FreezeAll) { 
                havalan.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
                }
            }

            // PAUSE BASILDIĞINDA HELİKOPTER HAREKETİ *-*-*-*-*-*-*-*
            else
            {
                if (transform.eulerAngles.x < 359 && transform.position.x > -44.5f)
                {
                    transform.Rotate(0, 0, 0);
                }
                oto.velocity = new Vector2(0, oto.velocity.y);
                havalan.AddForce(new Vector3(0, 0, 0));
                havalan.constraints = RigidbodyConstraints.FreezeAll;
                Time.timeScale = 0;
            }
        }
    }


    // Cisim belirtilen noktaya değerse bazı scriptleri true değerine döndür
    void OnCollisionEnter(Collision dokunursa)
    {
        if (dokunursa.gameObject.tag == "KarakterYandi" || dokunursa.gameObject.tag == "karakteryandi2" || dokunursa.gameObject.tag == "Duvar1" || dokunursa.gameObject.tag == "Duvar2" || dokunursa.gameObject.tag == "Duvar3" || dokunursa.gameObject.tag == "Duvar4" || dokunursa.gameObject.tag == "Duvar5" || dokunursa.gameObject.tag == "Duvar6" || dokunursa.gameObject.tag == "Duvar7" || dokunursa.gameObject.tag == "Duvar8" || dokunursa.gameObject.tag == "Duvar9" || dokunursa.gameObject.tag == "Duvar10" || dokunursa.gameObject.tag == "Duvar11" || dokunursa.gameObject.tag == "Duvar12" || dokunursa.gameObject.tag == "Duvar13" || dokunursa.gameObject.tag == "Duvar14")
        {
            HelikopterPervaneSesi.volume = 0;

            OyunMenusu.MevcutBedeldenBuyukse2 = false;
            OyunMenusu.MevcutBedeldenBuyukse3 = false;
            OyunMenusu.MevcutBedeldenBuyukse4 = false;
            OyunMenusu.MevcutBedeldenBuyukse5 = false;

            // ReklamAyar.BannerReklamGoster();
            OyunMenusu.ParayiToplamParayaAta = true;

            OyuncuAyar.HelikopterYanma = true;

            OyuncuAyar.OyunBitti = true;

            if (transform.position.x > 840) // 840
            {
              OyuncuAyar.DalgaYandi = true;             
            }
            else
            {
                OyuncuAyar.DalgaYandi = false;
            }

        }
    }

    void OnTriggerStay(Collider kalirsa)
    {
        if (kalirsa.gameObject.tag == "KameraSerbestYukariya")
        {
           KameraAyar.KameraSerbestYukari = true;
            KameraAyar.KameraKilitYukari = false;
            KameraAyar.KameraKilitAsagi = false;
        }
        else if (kalirsa.gameObject.tag == "KameraSerbestAsagiya")
        {
            KameraAyar.KameraSerbestAsagi = true;
            KameraAyar.KameraKilitYukari = false;
            KameraAyar.KameraKilitAsagi = false;
        }
    }
    void OnTriggerExit(Collider temaskesilmesi)
    {
        if (temaskesilmesi.gameObject.tag == "KameraSerbestYukariya")
        {
            KameraAyar.KameraSerbestYukari = false;
            KameraAyar.KameraKilitYukari = true;
            KameraAyar.KameraKilitAsagi = false;
        }
        else if (temaskesilmesi.gameObject.tag == "KameraSerbestAsagiya")
        {
            KameraAyar.KameraSerbestAsagi = false;
            KameraAyar.KameraKilitAsagi = true;
            KameraAyar.KameraKilitYukari = false;
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
        if (!OyunMenusu.BesinciDalgaBidahaOyna)
        {
            if (temas.gameObject.tag == "BesinciDalgaMusic")
            {
                sesAyar.SonDalgaMusic = true;
            }
            else if (temas.gameObject.tag == "BesinciDalgaSesAsagiya")
            {
                sesAyar.SonDalgaSesAsagiya = true;
            }
            else if (temas.gameObject.tag == "BesinciDalgaSesYukariya")
            {
                sesAyar.SonDalgaSesAsagiya = false;
                sesAyar.SonDalgaSesYukariya = true;
            }
        }

        if (temas.gameObject.tag == "yoluzat1" || temas.gameObject.tag == "yoluzat2" || temas.gameObject.tag == "yoluzat3")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<otoyol>().YolTemas = true;
        }       
        else if (temas.gameObject.tag == "YoluUsteTasi")
        {
            otoyol.YoluUsteTasi = true;
        }
        else if (temas.gameObject.tag == "YoluAltaTasi")
        {
            otoyol.YoluAltaTasi = true;
        }
        // KAMERA
        else if (temas.gameObject.tag == "DefaultKamera")
        {
            KameraAyar.DefaultKamera = false;
        }
        // KAMERA
        else if (temas.gameObject.tag == "engel_bir")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Bir>().TemasOlayi = true;
        }
   //ANİMASYONLU ENGELLER BASLANGIC
        //ANİMASYONLU ENGELLER BİTİŞ
        else if (temas.gameObject.tag == "engel_bosluklu")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Bosluklu>().TemasOlayi = true;
        }
        else if (temas.gameObject.tag == "engel_DonenSilindir")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_DonenSilindir>().TemasOlayi = true;
        }
        // İLK KARŞILIKLI ENGEL BAŞLANGIC
        else if (temas.gameObject.tag == "engel_karsilikli")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Karsilikli>().TemasOlayi1 = true;
        }
        else if (temas.gameObject.tag == "engel_karsilikli2")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Karsilikli>().TemasOlayi2 = true;
        }
        else if (temas.gameObject.tag == "engel_karsilikli3")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Karsilikli>().TemasOlayi3 = true;
        }
        else if (temas.gameObject.tag == "engel_karsilikli4")
        {
            temas.gameObject.transform.parent.gameObject.GetComponent<Engel_Karsilikli>().TemasOlayi4 = true;
        }
      // İLK KARŞILIKLI ENGEL BİTİŞ
       else if (temas.gameObject.tag == "goldmoney")
        {
            SesAyarSFX.ParaToplamaSesi = true;

            if (OyuncuAyar.Skor < 23)
            {
                OyuncuAyar.Para += 1;
            }
            else if (OyuncuAyar.Skor >= 23 && transform.position.x <= 975)
            {
                OyuncuAyar.Para += 2;
            }
            else if (transform.position.x > 975)
            {
                OyuncuAyar.Para += 1;
            }
            temas.gameObject.transform.parent.gameObject.GetComponent<Para_Ayarlari>().TemasOlayi = true;      
        }
        else if (temas.gameObject.tag == "goldmoney1")
        {
            SesAyarSFX.ParaToplamaSesi = true;

                OyuncuAyar.Para += 2;

            temas.gameObject.transform.parent.gameObject.GetComponent<Para_Ayarlari>().TemasOlayi = true;
        }

        else if (temas.gameObject.tag == "skorkap")
       { 
         OyuncuAyar.Skor += 1;
      }
    }
}