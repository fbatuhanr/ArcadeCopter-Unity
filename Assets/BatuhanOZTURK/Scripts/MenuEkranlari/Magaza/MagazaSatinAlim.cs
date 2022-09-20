using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MagazaSatinAlim : MonoBehaviour {

    public GameObject Pervane, Govde, Altlik1, Altlik2, Altlik3, Altlik4, Altlik5, Altlik6, Kuyruk;

    public Material KirmiziPervane, YesilPervane, MaviPervane;
    public Material KirmiziGovde, YesilGovde, MaviGovde;
    public Material KirmiziAltlik, YesilAltlik, MaviAltlik;
    public Material KirmiziKuyruk, YesilKuyruk, MaviKuyruk;

    public static string Yetersiz_ParaMoney;
            
        // PERVANE
    // KIRMIZI PERVANE
    public GameObject KirmiziPervaneOnay, KirmiziPervaneIptal, KirmiziPervaneYetersizPara;
    public Image KirmiziPervaneSatinAlimOnayResim;
    public static bool KirmiziPervaneOnGosterim;
    float KirmiziPervaneGeriSayim;
    bool KirmiziPervaneAktiflestirveDoldur, KirmiziPervaneAktiflestirveDoldurYetersiz;
    // YESIL PERVANE
    public GameObject YesilPervaneOnay, YesilPervaneIptal, YesilPervaneYetersizPara;
    public Image YesilPervaneSatinAlimOnayResim;
    public static bool YesilPervaneOnGosterim;
    float YesilPervaneGeriSayim;
    bool YesilPervaneAktiflestirveDoldur, YesilPervaneAktiflestirveDoldurYetersiz;
    // MAVI PERVANE
    public GameObject MaviPervaneOnay, MaviPervaneIptal, MaviPervaneYetersizPara;
    public Image MaviPervaneSatinAlimOnayResim;
    public static bool MaviPervaneOnGosterim;
    float MaviPervaneGeriSayim;
    bool MaviPervaneAktiflestirveDoldur, MaviPervaneAktiflestirveDoldurYetersiz;
         // PERVANE BITIS

         // GOVDE
        // KIRMIZI GOVDE
        public GameObject KirmiziGovdeOnay, KirmiziGovdeIptal, KirmiziGovdeYetersizPara;
        public Image KirmiziGovdeSatinAlimOnayResim;
        public static bool KirmiziGovdeOnGosterim;
        float KirmiziGovdeGeriSayim;
        bool KirmiziGovdeAktiflestirveDoldur, KirmiziGovdeAktiflestirveDoldurYetersiz;
        // YESIL GOVDE
        public GameObject YesilGovdeOnay, YesilGovdeIptal, YesilGovdeYetersizPara;
        public Image YesilGovdeSatinAlimOnayResim;
        public static bool YesilGovdeOnGosterim;
        float YesilGovdeGeriSayim;
        bool YesilGovdeAktiflestirveDoldur, YesilGovdeAktiflestirveDoldurYetersiz;
        // MAVI GOVDE
        public GameObject MaviGovdeOnay, MaviGovdeIptal, MaviGovdeYetersizPara;
        public Image MaviGovdeSatinAlimOnayResim;
        public static bool MaviGovdeOnGosterim;
        float MaviGovdeGeriSayim;
        bool MaviGovdeAktiflestirveDoldur, MaviGovdeAktiflestirveDoldurYetersiz;
        // GOVDE BITIS

            // ALTLIK
     // KIRMIZI GOVDE
    public GameObject KirmiziAltlikOnay, KirmiziAltlikIptal, KirmiziAltlikYetersizPara;
    public Image KirmiziAltlikSatinAlimOnayResim;
    public static bool KirmiziAltlikOnGosterim;
    float KirmiziAltlikGeriSayim;
    bool KirmiziAltlikAktiflestirveDoldur, KirmiziAltlikAktiflestirveDoldurYetersiz;
    // YESIL GOVDE
    public GameObject YesilAltlikOnay, YesilAltlikIptal, YesilAltlikYetersizPara;
    public Image YesilAltlikSatinAlimOnayResim;
    public static bool YesilAltlikOnGosterim;
    float YesilAltlikGeriSayim;
    bool YesilAltlikAktiflestirveDoldur, YesilAltlikAktiflestirveDoldurYetersiz;
    // MAVI GOVDE
    public GameObject MaviAltlikOnay, MaviAltlikIptal, MaviAltlikYetersizPara;
    public Image MaviAltlikSatinAlimOnayResim;
    public static bool MaviAltlikOnGosterim;
    float MaviAltlikGeriSayim;
    bool MaviAltlikAktiflestirveDoldur, MaviAltlikAktiflestirveDoldurYetersiz;
    // ALTLIK BITIS

            // Kuyruk
            // KIRMIZI GOVDE
            public GameObject KirmiziKuyrukOnay, KirmiziKuyrukIptal, KirmiziKuyrukYetersizPara;
            public Image KirmiziKuyrukSatinAlimOnayResim;
            public static bool KirmiziKuyrukOnGosterim;
            float KirmiziKuyrukGeriSayim;
            bool KirmiziKuyrukAktiflestirveDoldur, KirmiziKuyrukAktiflestirveDoldurYetersiz;
            // YESIL GOVDE
            public GameObject YesilKuyrukOnay, YesilKuyrukIptal, YesilKuyrukYetersizPara;
            public Image YesilKuyrukSatinAlimOnayResim;
            public static bool YesilKuyrukOnGosterim;
            float YesilKuyrukGeriSayim;
            bool YesilKuyrukAktiflestirveDoldur, YesilKuyrukAktiflestirveDoldurYetersiz;
            // MAVI GOVDE
            public GameObject MaviKuyrukOnay, MaviKuyrukIptal, MaviKuyrukYetersizPara;
            public Image MaviKuyrukSatinAlimOnayResim;
            public static bool MaviKuyrukOnGosterim;
            float MaviKuyrukGeriSayim;
            bool MaviKuyrukAktiflestirveDoldur, MaviKuyrukAktiflestirveDoldurYetersiz;
            // Kuyruk BITIS

    void Start()
    {
        YesilPervaneStartAyarlari();
        KirmiziPervaneStartAyarlari();
        MaviPervaneStartAyarlari();

        KirmiziGovdeStartAyarlari();
        YesilGovdeStartAyarlari();
        MaviGovdeStartAyarlari();

        KirmiziAltlikStartAyarlari();
        YesilAltlikStartAyarlari();
        MaviAltlikStartAyarlari();

        KirmiziKuyrukStartAyarlari();
        YesilKuyrukStartAyarlari();
        MaviKuyrukStartAyarlari();
    }


    // PERVANE UPDATE - START BASLANGIC 
    void KirmiziPervaneUpdateAyari()
    {
        if (KirmiziPervaneAktiflestirveDoldur)
        {
            KirmiziPervaneSatinAlimOnayResim.fillAmount += 0.025f;

            if (KirmiziPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziPervaneOnay.SetActive(true);
                KirmiziPervaneIptal.SetActive(true);
            }
        }
        else
        {
            if (!KirmiziPervaneAktiflestirveDoldurYetersiz)
            {
                KirmiziPervaneSatinAlimOnayResim.fillAmount -= 0.025f;

                if (KirmiziPervaneSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    KirmiziPervaneOnay.SetActive(false);
                    KirmiziPervaneIptal.SetActive(false);
                }
                if (KirmiziPervaneSatinAlimOnayResim.fillAmount == 0)
                {
                    KirmiziPervaneGeriSayim = 5.0f;
                    
                }
            }
        }

        if (KirmiziPervaneAktiflestirveDoldurYetersiz)
        {
            KirmiziPervaneSatinAlimOnayResim.fillAmount += 0.025f;
            if (KirmiziPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziPervaneYetersizPara.SetActive(true);

                if (KirmiziPervaneGeriSayim > 0.0f)
                {
                    KirmiziPervaneGeriSayim -= Time.deltaTime;
                }
                if (KirmiziPervaneGeriSayim <= 0.2f)
                {
                    KirmiziPervaneOnGosterim = false;
                    YesilPervaneOnGosterim = false;
                    MaviPervaneOnGosterim = false;
                    KirmiziPervaneYetersizPara.SetActive(false);
                    KirmiziPervaneAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void KirmiziPervaneStartAyarlari()
    {
        KirmiziPervaneGeriSayim = 5.0f;
        KirmiziPervaneOnGosterim = false;
        KirmiziPervaneYetersizPara.SetActive(false);
        KirmiziPervaneOnay.SetActive(false);
        KirmiziPervaneIptal.SetActive(false);
        KirmiziPervaneSatinAlimOnayResim.fillAmount = 0;
        KirmiziPervaneAktiflestirveDoldur = false;
        KirmiziPervaneAktiflestirveDoldurYetersiz = false;
    }

    void YesilPervaneUpdateAyari()
    {
        if (YesilPervaneAktiflestirveDoldur)
        {
            YesilPervaneSatinAlimOnayResim.fillAmount += 0.025f;

            if (YesilPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                YesilPervaneOnay.SetActive(true);
                YesilPervaneIptal.SetActive(true);
            }
        }
        else
        {
            if (!YesilPervaneAktiflestirveDoldurYetersiz)
            {
                YesilPervaneSatinAlimOnayResim.fillAmount -= 0.025f;

                if (YesilPervaneSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    YesilPervaneOnay.SetActive(false);
                    YesilPervaneIptal.SetActive(false);
                }
                if (YesilPervaneSatinAlimOnayResim.fillAmount == 0)
                {
                    YesilPervaneGeriSayim = 5.0f;     
                }
            }
        }

        if (YesilPervaneAktiflestirveDoldurYetersiz)
        {
            YesilPervaneSatinAlimOnayResim.fillAmount += 0.025f;
            if (YesilPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                YesilPervaneYetersizPara.SetActive(true);

                if (YesilPervaneGeriSayim > 0.0f)
                {
                    YesilPervaneGeriSayim -= Time.deltaTime;
                }
                if (YesilPervaneGeriSayim <= 0.2f)
                {
                    KirmiziPervaneOnGosterim = false;
                    YesilPervaneOnGosterim = false;
                    MaviPervaneOnGosterim = false;

                    YesilPervaneYetersizPara.SetActive(false);
                    YesilPervaneAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
	void YesilPervaneStartAyarlari()
    {
        YesilPervaneGeriSayim = 5.0f;
        YesilPervaneOnGosterim = false;
        YesilPervaneYetersizPara.SetActive(false);
        YesilPervaneOnay.SetActive(false);
        YesilPervaneIptal.SetActive(false);
        YesilPervaneSatinAlimOnayResim.fillAmount = 0;
        YesilPervaneAktiflestirveDoldur = false;
        YesilPervaneAktiflestirveDoldurYetersiz = false;
    }

    void MaviPervaneUpdateAyarlari()
    {
        if (MaviPervaneAktiflestirveDoldur)
        {
            MaviPervaneSatinAlimOnayResim.fillAmount += 0.025f;

            if (MaviPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                MaviPervaneOnay.SetActive(true);
                MaviPervaneIptal.SetActive(true);
            }
        }
        else
        {
            if (!MaviPervaneAktiflestirveDoldurYetersiz)
            {
                MaviPervaneSatinAlimOnayResim.fillAmount -= 0.025f;

                if (MaviPervaneSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    MaviPervaneOnay.SetActive(false);
                    MaviPervaneIptal.SetActive(false);
                }
                if (MaviPervaneSatinAlimOnayResim.fillAmount == 0)
                {
                    MaviPervaneGeriSayim = 5.0f;    
                }
            }
        }

        if (MaviPervaneAktiflestirveDoldurYetersiz)
        {
            MaviPervaneSatinAlimOnayResim.fillAmount += 0.025f;
            if (MaviPervaneSatinAlimOnayResim.fillAmount == 1)
            {
                MaviPervaneYetersizPara.SetActive(true);

                if (MaviPervaneGeriSayim > 0.0f)
                {
                    MaviPervaneGeriSayim -= Time.deltaTime;
                }
                if (MaviPervaneGeriSayim <= 0.2f)
                {
                    KirmiziPervaneOnGosterim = false;
                    YesilPervaneOnGosterim = false;
                    MaviPervaneOnGosterim = false;

                    MaviPervaneYetersizPara.SetActive(false);
                    MaviPervaneAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void MaviPervaneStartAyarlari()
    {
        MaviPervaneGeriSayim = 5.0f;
        MaviPervaneOnGosterim = false;
        MaviPervaneYetersizPara.SetActive(false);
        MaviPervaneOnay.SetActive(false);
        MaviPervaneIptal.SetActive(false);
        MaviPervaneSatinAlimOnayResim.fillAmount = 0;
        MaviPervaneAktiflestirveDoldur = false;
        MaviPervaneAktiflestirveDoldurYetersiz = false;
    }
    // PERVANE UPDATE - START BITIS


    // GOVDE UPDATE - START BASLANGIC
    void KirmiziGovdeUpdateAyarlari()
    {
        if (KirmiziGovdeAktiflestirveDoldur)
        {
            KirmiziGovdeSatinAlimOnayResim.fillAmount += 0.025f;

            if (KirmiziGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziGovdeOnay.SetActive(true);
                KirmiziGovdeIptal.SetActive(true);
            }
        }
        else
        {
            if (!KirmiziGovdeAktiflestirveDoldurYetersiz)
            {
                KirmiziGovdeSatinAlimOnayResim.fillAmount -= 0.025f;

                if (KirmiziGovdeSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    KirmiziGovdeOnay.SetActive(false);
                    KirmiziGovdeIptal.SetActive(false);
                }
                if (KirmiziGovdeSatinAlimOnayResim.fillAmount == 0)
                {
                    KirmiziGovdeGeriSayim = 5.0f;
                }
            }
        }

        if (KirmiziGovdeAktiflestirveDoldurYetersiz)
        {
            KirmiziGovdeSatinAlimOnayResim.fillAmount += 0.025f;
            if (KirmiziGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziGovdeYetersizPara.SetActive(true);

                if (KirmiziGovdeGeriSayim > 0.0f)
                {
                    KirmiziGovdeGeriSayim -= Time.deltaTime;
                }
                if (KirmiziGovdeGeriSayim <= 0.2f)
                {
                    KirmiziGovdeOnGosterim = false;
                    YesilGovdeOnGosterim = false;
                    MaviGovdeOnGosterim = false;

                    KirmiziGovdeYetersizPara.SetActive(false);
                    KirmiziGovdeAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void KirmiziGovdeStartAyarlari()
    {
        KirmiziGovdeGeriSayim = 5.0f;
        KirmiziGovdeOnGosterim = false;
        KirmiziGovdeYetersizPara.SetActive(false);
        KirmiziGovdeOnay.SetActive(false);
        KirmiziGovdeIptal.SetActive(false);
        KirmiziGovdeSatinAlimOnayResim.fillAmount = 0;
        KirmiziGovdeAktiflestirveDoldur = false;
        KirmiziGovdeAktiflestirveDoldurYetersiz = false;
    }

    void YesilGovdeUpdateAyarlari()
    {
        if (YesilGovdeAktiflestirveDoldur)
        {
            YesilGovdeSatinAlimOnayResim.fillAmount += 0.025f;

            if (YesilGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                YesilGovdeOnay.SetActive(true);
                YesilGovdeIptal.SetActive(true);
            }
        }
        else
        {
            if (!YesilGovdeAktiflestirveDoldurYetersiz)
            {
                YesilGovdeSatinAlimOnayResim.fillAmount -= 0.025f;

                if (YesilGovdeSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    YesilGovdeOnay.SetActive(false);
                    YesilGovdeIptal.SetActive(false);
                }
                if (YesilGovdeSatinAlimOnayResim.fillAmount == 0)
                {
                    YesilGovdeGeriSayim = 5.0f;
                }
            }
        }

        if (YesilGovdeAktiflestirveDoldurYetersiz)
        {
            YesilGovdeSatinAlimOnayResim.fillAmount += 0.025f;
            if (YesilGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                YesilGovdeYetersizPara.SetActive(true);

                if (YesilGovdeGeriSayim > 0.0f)
                {
                    YesilGovdeGeriSayim -= Time.deltaTime;
                }
                if (YesilGovdeGeriSayim <= 0.2f)
                {
                    KirmiziGovdeOnGosterim = false;
                    YesilGovdeOnGosterim = false;
                    MaviGovdeOnGosterim = false;

                    YesilGovdeYetersizPara.SetActive(false);
                    YesilGovdeAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void YesilGovdeStartAyarlari()
    {
        YesilGovdeGeriSayim = 5.0f;
        YesilGovdeOnGosterim = false;
        YesilGovdeYetersizPara.SetActive(false);
        YesilGovdeOnay.SetActive(false);
        YesilGovdeIptal.SetActive(false);
        YesilGovdeSatinAlimOnayResim.fillAmount = 0;
        YesilGovdeAktiflestirveDoldur = false;
        YesilGovdeAktiflestirveDoldurYetersiz = false;
    }

    void MaviGovdeUpdateAyarlari()
    {
        if (MaviGovdeAktiflestirveDoldur)
        {
            MaviGovdeSatinAlimOnayResim.fillAmount += 0.025f;

            if (MaviGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                MaviGovdeOnay.SetActive(true);
                MaviGovdeIptal.SetActive(true);
            }
        }
        else
        {
            if (!MaviGovdeAktiflestirveDoldurYetersiz)
            {
                MaviGovdeSatinAlimOnayResim.fillAmount -= 0.025f;

                if (MaviGovdeSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    MaviGovdeOnay.SetActive(false);
                    MaviGovdeIptal.SetActive(false);
                }
                if (MaviGovdeSatinAlimOnayResim.fillAmount == 0)
                {
                    MaviGovdeGeriSayim = 5.0f;
                }
            }
        }

        if (MaviGovdeAktiflestirveDoldurYetersiz)
        {
            MaviGovdeSatinAlimOnayResim.fillAmount += 0.025f;
            if (MaviGovdeSatinAlimOnayResim.fillAmount == 1)
            {
                MaviGovdeYetersizPara.SetActive(true);

                if (MaviGovdeGeriSayim > 0.0f)
                {
                    MaviGovdeGeriSayim -= Time.deltaTime;
                }
                if (MaviGovdeGeriSayim <= 0.2f)
                {
                    KirmiziGovdeOnGosterim = false;
                    YesilGovdeOnGosterim = false;
                    MaviGovdeOnGosterim = false;

                    MaviGovdeYetersizPara.SetActive(false);
                    MaviGovdeAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void MaviGovdeStartAyarlari()
    {
        MaviGovdeGeriSayim = 5.0f;
        MaviGovdeOnGosterim = false;
        MaviGovdeYetersizPara.SetActive(false);
        MaviGovdeOnay.SetActive(false);
        MaviGovdeIptal.SetActive(false);
        MaviGovdeSatinAlimOnayResim.fillAmount = 0;
        MaviGovdeAktiflestirveDoldur = false;
        MaviGovdeAktiflestirveDoldurYetersiz = false;
    }
    // GOVDE UPDATE - START BITIS

    // ALTLIK UPDATE - START BASLANGIC
    void KirmiziAltlikUpdateAyarlari()
    {
        if (KirmiziAltlikAktiflestirveDoldur)
        {
            KirmiziAltlikSatinAlimOnayResim.fillAmount += 0.025f;

            if (KirmiziAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziAltlikOnay.SetActive(true);
                KirmiziAltlikIptal.SetActive(true);
            }
        }
        else
        {
            if (!KirmiziAltlikAktiflestirveDoldurYetersiz)
            {
                KirmiziAltlikSatinAlimOnayResim.fillAmount -= 0.025f;

                if (KirmiziAltlikSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    KirmiziAltlikOnay.SetActive(false);
                    KirmiziAltlikIptal.SetActive(false);
                }
                if (KirmiziAltlikSatinAlimOnayResim.fillAmount == 0)
                {
                    KirmiziAltlikGeriSayim = 5.0f;
                }
            }
        }

        if (KirmiziAltlikAktiflestirveDoldurYetersiz)
        {
            KirmiziAltlikSatinAlimOnayResim.fillAmount += 0.025f;
            if (KirmiziAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziAltlikYetersizPara.SetActive(true);

                if (KirmiziAltlikGeriSayim > 0.0f)
                {
                    KirmiziAltlikGeriSayim -= Time.deltaTime;
                }
                if (KirmiziAltlikGeriSayim <= 0.2f)
                {
                    KirmiziAltlikOnGosterim = false;
                    YesilAltlikOnGosterim = false;
                    MaviAltlikOnGosterim = false;

                    KirmiziAltlikYetersizPara.SetActive(false);
                    KirmiziAltlikAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void KirmiziAltlikStartAyarlari()
    {
        KirmiziAltlikGeriSayim = 5.0f;
        KirmiziAltlikOnGosterim = false;
        KirmiziAltlikYetersizPara.SetActive(false);
        KirmiziAltlikOnay.SetActive(false);
        KirmiziAltlikIptal.SetActive(false);
        KirmiziAltlikSatinAlimOnayResim.fillAmount = 0;
        KirmiziAltlikAktiflestirveDoldur = false;
        KirmiziAltlikAktiflestirveDoldurYetersiz = false;
    }

    void YesilAltlikUpdateAyarlari()
    {
        if (YesilAltlikAktiflestirveDoldur)
        {
            YesilAltlikSatinAlimOnayResim.fillAmount += 0.025f;

            if (YesilAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                YesilAltlikOnay.SetActive(true);
                YesilAltlikIptal.SetActive(true);
            }
        }
        else
        {
            if (!YesilAltlikAktiflestirveDoldurYetersiz)
            {
                YesilAltlikSatinAlimOnayResim.fillAmount -= 0.025f;

                if (YesilAltlikSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    YesilAltlikOnay.SetActive(false);
                    YesilAltlikIptal.SetActive(false);
                }
                if (YesilAltlikSatinAlimOnayResim.fillAmount == 0)
                {
                    YesilAltlikGeriSayim = 5.0f;
                }
            }
        }

        if (YesilAltlikAktiflestirveDoldurYetersiz)
        {
            YesilAltlikSatinAlimOnayResim.fillAmount += 0.025f;
            if (YesilAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                YesilAltlikYetersizPara.SetActive(true);

                if (YesilAltlikGeriSayim > 0.0f)
                {
                    YesilAltlikGeriSayim -= Time.deltaTime;
                }
                if (YesilAltlikGeriSayim <= 0.2f)
                {
                    KirmiziAltlikOnGosterim = false;
                    YesilAltlikOnGosterim = false;
                    MaviAltlikOnGosterim = false;

                    YesilAltlikYetersizPara.SetActive(false);
                    YesilAltlikAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void YesilAltlikStartAyarlari()
    {
        YesilAltlikGeriSayim = 5.0f;
        YesilAltlikOnGosterim = false;
        YesilAltlikYetersizPara.SetActive(false);
        YesilAltlikOnay.SetActive(false);
        YesilAltlikIptal.SetActive(false);
        YesilAltlikSatinAlimOnayResim.fillAmount = 0;
        YesilAltlikAktiflestirveDoldur = false;
        YesilAltlikAktiflestirveDoldurYetersiz = false;
    }

    void MaviAltlikUpdateAyarlari()
    {
        if (MaviAltlikAktiflestirveDoldur)
        {
            MaviAltlikSatinAlimOnayResim.fillAmount += 0.025f;

            if (MaviAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                MaviAltlikOnay.SetActive(true);
                MaviAltlikIptal.SetActive(true);
            }
        }
        else
        {
            if (!MaviAltlikAktiflestirveDoldurYetersiz)
            {
                MaviAltlikSatinAlimOnayResim.fillAmount -= 0.025f;

                if (MaviAltlikSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    MaviAltlikOnay.SetActive(false);
                    MaviAltlikIptal.SetActive(false);
                }
                if (MaviAltlikSatinAlimOnayResim.fillAmount == 0)
                {
                    MaviAltlikGeriSayim = 5.0f;
                }
            }
        }

        if (MaviAltlikAktiflestirveDoldurYetersiz)
        {
            MaviAltlikSatinAlimOnayResim.fillAmount += 0.025f;
            if (MaviAltlikSatinAlimOnayResim.fillAmount == 1)
            {
                MaviAltlikYetersizPara.SetActive(true);

                if (MaviAltlikGeriSayim > 0.0f)
                {
                    MaviAltlikGeriSayim -= Time.deltaTime;
                }
                if (MaviAltlikGeriSayim <= 0.2f)
                {
                    KirmiziAltlikOnGosterim = false;
                    YesilAltlikOnGosterim = false;
                    MaviAltlikOnGosterim = false;

                    MaviAltlikYetersizPara.SetActive(false);
                    MaviAltlikAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void MaviAltlikStartAyarlari()
    {
        MaviAltlikGeriSayim = 5.0f;
        MaviAltlikOnGosterim = false;
        MaviAltlikYetersizPara.SetActive(false);
        MaviAltlikOnay.SetActive(false);
        MaviAltlikIptal.SetActive(false);
        MaviAltlikSatinAlimOnayResim.fillAmount = 0;
        MaviAltlikAktiflestirveDoldur = false;
        MaviAltlikAktiflestirveDoldurYetersiz = false;
    }
    // ALTLIK UPDATE - START BITIS


    // KUYRUK UPDATE - START BITIS
    void KirmiziKuyrukUpdateAyarlari()
    {
        if (KirmiziKuyrukAktiflestirveDoldur)
        {
            KirmiziKuyrukSatinAlimOnayResim.fillAmount += 0.025f;

            if (KirmiziKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziKuyrukOnay.SetActive(true);
                KirmiziKuyrukIptal.SetActive(true);
            }
        }
        else
        {
            if (!KirmiziKuyrukAktiflestirveDoldurYetersiz)
            {
                KirmiziKuyrukSatinAlimOnayResim.fillAmount -= 0.025f;

                if (KirmiziKuyrukSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    KirmiziKuyrukOnay.SetActive(false);
                    KirmiziKuyrukIptal.SetActive(false);
                }
                if (KirmiziKuyrukSatinAlimOnayResim.fillAmount == 0)
                {
                    KirmiziKuyrukGeriSayim = 5.0f;
                }
            }
        }

        if (KirmiziKuyrukAktiflestirveDoldurYetersiz)
        {
            KirmiziKuyrukSatinAlimOnayResim.fillAmount += 0.025f;
            if (KirmiziKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                KirmiziKuyrukYetersizPara.SetActive(true);

                if (KirmiziKuyrukGeriSayim > 0.0f)
                {
                    KirmiziKuyrukGeriSayim -= Time.deltaTime;
                }
                if (KirmiziKuyrukGeriSayim <= 0.2f)
                {
                    KirmiziKuyrukOnGosterim = false;
                    YesilKuyrukOnGosterim = false;
                    MaviKuyrukOnGosterim = false;

                    KirmiziKuyrukYetersizPara.SetActive(false);
                    KirmiziKuyrukAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void KirmiziKuyrukStartAyarlari()
    {
        KirmiziKuyrukGeriSayim = 5.0f;
        KirmiziKuyrukOnGosterim = false;
        KirmiziKuyrukYetersizPara.SetActive(false);
        KirmiziKuyrukOnay.SetActive(false);
        KirmiziKuyrukIptal.SetActive(false);
        KirmiziKuyrukSatinAlimOnayResim.fillAmount = 0;
        KirmiziKuyrukAktiflestirveDoldur = false;
        KirmiziKuyrukAktiflestirveDoldurYetersiz = false;
    }

    void YesilKuyrukUpdateAyarlari()
    {
        if (YesilKuyrukAktiflestirveDoldur)
        {
            YesilKuyrukSatinAlimOnayResim.fillAmount += 0.025f;

            if (YesilKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                YesilKuyrukOnay.SetActive(true);
                YesilKuyrukIptal.SetActive(true);
            }
        }
        else
        {
            if (!YesilKuyrukAktiflestirveDoldurYetersiz)
            {
                YesilKuyrukSatinAlimOnayResim.fillAmount -= 0.025f;

                if (YesilKuyrukSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    YesilKuyrukOnay.SetActive(false);
                    YesilKuyrukIptal.SetActive(false);
                }
                if (YesilKuyrukSatinAlimOnayResim.fillAmount == 0)
                {
                    YesilKuyrukGeriSayim = 5.0f;
                }
            }
        }

        if (YesilKuyrukAktiflestirveDoldurYetersiz)
        {
            YesilKuyrukSatinAlimOnayResim.fillAmount += 0.025f;
            if (YesilKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                YesilKuyrukYetersizPara.SetActive(true);

                if (YesilKuyrukGeriSayim > 0.0f)
                {
                    YesilKuyrukGeriSayim -= Time.deltaTime;
                }
                if (YesilKuyrukGeriSayim <= 0.2f)
                {
                    KirmiziKuyrukOnGosterim = false;
                    YesilKuyrukOnGosterim = false;
                    MaviKuyrukOnGosterim = false;

                    YesilKuyrukYetersizPara.SetActive(false);
                    YesilKuyrukAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void YesilKuyrukStartAyarlari()
    {
        YesilKuyrukGeriSayim = 5.0f;
        YesilKuyrukOnGosterim = false;
        YesilKuyrukYetersizPara.SetActive(false);
        YesilKuyrukOnay.SetActive(false);
        YesilKuyrukIptal.SetActive(false);
        YesilKuyrukSatinAlimOnayResim.fillAmount = 0;
        YesilKuyrukAktiflestirveDoldur = false;
        YesilKuyrukAktiflestirveDoldurYetersiz = false;
    }

    void MaviKuyrukUpdateAyarlari()
    {
        if (MaviKuyrukAktiflestirveDoldur)
        {
            MaviKuyrukSatinAlimOnayResim.fillAmount += 0.025f;

            if (MaviKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                MaviKuyrukOnay.SetActive(true);
                MaviKuyrukIptal.SetActive(true);
            }
        }
        else
        {
            if (!MaviKuyrukAktiflestirveDoldurYetersiz)
            {
                MaviKuyrukSatinAlimOnayResim.fillAmount -= 0.025f;

                if (MaviKuyrukSatinAlimOnayResim.fillAmount < 0.75f)
                {
                    MaviKuyrukOnay.SetActive(false);
                    MaviKuyrukIptal.SetActive(false);
                }
                if (MaviKuyrukSatinAlimOnayResim.fillAmount == 0)
                {
                    MaviKuyrukGeriSayim = 5.0f;
                }
            }
        }

        if (MaviKuyrukAktiflestirveDoldurYetersiz)
        {
            MaviKuyrukSatinAlimOnayResim.fillAmount += 0.025f;
            if (MaviKuyrukSatinAlimOnayResim.fillAmount == 1)
            {
                MaviKuyrukYetersizPara.SetActive(true);

                if (MaviKuyrukGeriSayim > 0.0f)
                {
                    MaviKuyrukGeriSayim -= Time.deltaTime;
                }
                if (MaviKuyrukGeriSayim <= 0.2f)
                {
                    KirmiziKuyrukOnGosterim = false;
                    YesilKuyrukOnGosterim = false;
                    MaviKuyrukOnGosterim = false;

                    MaviKuyrukYetersizPara.SetActive(false);
                    MaviKuyrukAktiflestirveDoldurYetersiz = false;
                }
            }
        }
    }
    void MaviKuyrukStartAyarlari()
    {
        MaviKuyrukGeriSayim = 5.0f;
        MaviKuyrukOnGosterim = false;
        MaviKuyrukYetersizPara.SetActive(false);
        MaviKuyrukOnay.SetActive(false);
        MaviKuyrukIptal.SetActive(false);
        MaviKuyrukSatinAlimOnayResim.fillAmount = 0;
        MaviKuyrukAktiflestirveDoldur = false;
        MaviKuyrukAktiflestirveDoldurYetersiz = false;
    }
    // KUYRUK UPDATE - START BITIS


    void Update () {

        OyuncuAyar.ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");
        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");

        YesilPervaneYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        YesilPervaneYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
            KirmiziPervaneYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
            KirmiziPervaneYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
        MaviPervaneYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        MaviPervaneYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;

        KirmiziGovdeYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        KirmiziGovdeYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
            YesilGovdeYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
            YesilGovdeYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
        MaviGovdeYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        MaviGovdeYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;

        KirmiziAltlikYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        KirmiziAltlikYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
            YesilAltlikYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
            YesilAltlikYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
        MaviAltlikYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        MaviAltlikYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;

        KirmiziKuyrukYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        KirmiziKuyrukYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
            YesilKuyrukYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
            YesilKuyrukYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;
        MaviKuyrukYetersizPara.GetComponent<Text>().text = Yetersiz_ParaMoney;
        MaviKuyrukYetersizPara.GetComponent<Text>().fontSize = Screen.width / 25;

        KirmiziPervaneUpdateAyari();
        YesilPervaneUpdateAyari();      
        MaviPervaneUpdateAyarlari();

        KirmiziGovdeUpdateAyarlari();
        YesilGovdeUpdateAyarlari();
        MaviGovdeUpdateAyarlari();

        KirmiziAltlikUpdateAyarlari();
        YesilAltlikUpdateAyarlari();
        MaviAltlikUpdateAyarlari();

        KirmiziKuyrukUpdateAyarlari();
        YesilKuyrukUpdateAyarlari();
        MaviKuyrukUpdateAyarlari();

    }

    // PERVANE ETKILESIMLER BASLANGIC
    public void KirmiziPervaneItemTiklama()
    {
        // YESIL PERVANE BEDELI 50 GOLD
        if (OyuncuAyar.ToplamPara >= 50 || OyuncuAyar.ToplamSkor >= 50)
        {
            KirmiziPervaneAktiflestirveDoldur = true;
            YesilPervaneAktiflestirveDoldur = false;
            MaviPervaneAktiflestirveDoldur = false;
        }
        else
        {
            KirmiziPervaneAktiflestirveDoldurYetersiz = true;
        }

        KirmiziPervaneOnGosterim = true;

        Pervane.GetComponent<Renderer>().material = KirmiziPervane;
        // cakma gosterim
    }
    public void KirmiziPervaneItemOnay()
    {
        Helikopter.PervaneKaplamaDegerligi = 1;
        PlayerPrefs.SetInt("Pervane", Helikopter.PervaneKaplamaDegerligi);
    }
    public void KirmiziPervaneItemIptal()
    {
        KirmiziPervaneOnGosterim = false;
        YesilPervaneOnGosterim = false;
        MaviPervaneOnGosterim = false;

        KirmiziPervaneAktiflestirveDoldur = false;

    }

    public void YesilPervaneItemTiklama()
    {
        // YESIL PERVANE BEDELI 50 GOLD
        if (OyuncuAyar.ToplamPara >= 50 || OyuncuAyar.ToplamSkor >= 50)
        {
            KirmiziPervaneAktiflestirveDoldur = false;
            YesilPervaneAktiflestirveDoldur = true;
            MaviPervaneAktiflestirveDoldur = false;
        }
        else
        {
            YesilPervaneAktiflestirveDoldurYetersiz = true;   
        }

        YesilPervaneOnGosterim = true;

        Pervane.GetComponent<Renderer>().material = YesilPervane;
        // cakma gosterim
    }
    public void YesilPervaneItemOnay()
    {
        Helikopter.PervaneKaplamaDegerligi = 2;
        PlayerPrefs.SetInt("Pervane", Helikopter.PervaneKaplamaDegerligi);
    }
    public void YesilPervaneItemIptal()
    {
        KirmiziPervaneOnGosterim = false;
        YesilPervaneOnGosterim = false;
        MaviPervaneOnGosterim = false;

        YesilPervaneAktiflestirveDoldur = false;
    }

    public void MaviPervaneItemTiklama()
    {
        // Mavi PERVANE BEDELI 50 GOLD
        if (OyuncuAyar.ToplamPara >= 50 || OyuncuAyar.ToplamSkor >= 50)
        {
            KirmiziPervaneAktiflestirveDoldur = false;
            YesilPervaneAktiflestirveDoldur = false;
            MaviPervaneAktiflestirveDoldur = true;
        }
        else
        {
            MaviPervaneAktiflestirveDoldurYetersiz = true;
        }

        MaviPervaneOnGosterim = true;

        Pervane.GetComponent<Renderer>().material = MaviPervane;
        // cakma gosterim
    }
    public void MaviPervaneItemOnay()
    {
        Helikopter.PervaneKaplamaDegerligi = 3;
        PlayerPrefs.SetInt("Pervane", Helikopter.PervaneKaplamaDegerligi);
    }
    public void MaviPervaneItemIptal()
    {
        KirmiziPervaneOnGosterim = false;
        YesilPervaneOnGosterim = false;
        MaviPervaneOnGosterim = false;

        MaviPervaneAktiflestirveDoldur = false;
    }
    // PERVANE ETKILESIMLER BITIS




    // GOVDE ETKILESIMLER BASLANGIC
    public void KirmiziGovdeItemTiklama()
    {
        // KIRMIZI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziGovdeAktiflestirveDoldur = true;
            YesilGovdeAktiflestirveDoldur = false;
            MaviGovdeAktiflestirveDoldur = false;
        }
        else
        {
            KirmiziGovdeAktiflestirveDoldurYetersiz = true;
        }

        KirmiziGovdeOnGosterim = true;

        Govde.GetComponent<Renderer>().material = KirmiziGovde;
        // cakma gosterim
    }
    public void KirmiziGovdeItemOnay()
    {
        Helikopter.GovdeKaplamaDegerligi = 1;
        PlayerPrefs.SetInt("Govde", Helikopter.GovdeKaplamaDegerligi);
    }
    public void KirmiziGovdeItemIptal()
    {
        KirmiziGovdeOnGosterim = false;
        YesilGovdeOnGosterim = false;
        MaviGovdeOnGosterim = false;

        KirmiziGovdeAktiflestirveDoldur = false;

    }

    public void YesilGovdeItemTiklama()
    {
        // YESIL GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziGovdeAktiflestirveDoldur = false;
            YesilGovdeAktiflestirveDoldur = true;
            MaviGovdeAktiflestirveDoldur = false;
        }
        else
        {
            YesilGovdeAktiflestirveDoldurYetersiz = true;
        }

        YesilGovdeOnGosterim = true;

        Govde.GetComponent<Renderer>().material = YesilGovde;
        // cakma gosterim
    }
    public void YesilGovdeItemOnay()
    {
        Helikopter.GovdeKaplamaDegerligi = 2;
        PlayerPrefs.SetInt("Govde", Helikopter.GovdeKaplamaDegerligi);
    }
    public void YesilGovdeItemIptal()
    {
        KirmiziGovdeOnGosterim = false;
        YesilGovdeOnGosterim = false;
        MaviGovdeOnGosterim = false;

        YesilGovdeAktiflestirveDoldur = false;

    }

    public void MaviGovdeItemTiklama()
    {
        // MAVI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziGovdeAktiflestirveDoldur = false;
            YesilGovdeAktiflestirveDoldur = false;
            MaviGovdeAktiflestirveDoldur = true;
        }
        else
        {
            MaviGovdeAktiflestirveDoldurYetersiz = true;
        }

        MaviGovdeOnGosterim = true;

        Govde.GetComponent<Renderer>().material = MaviGovde;
        // cakma gosterim
    }
    public void MaviGovdeItemOnay()
    {
        Helikopter.GovdeKaplamaDegerligi = 3;
        PlayerPrefs.SetInt("Govde", Helikopter.GovdeKaplamaDegerligi);
    }
    public void MaviGovdeItemIptal()
    {
        KirmiziGovdeOnGosterim = false;
        YesilGovdeOnGosterim = false;
        MaviGovdeOnGosterim = false;

        MaviGovdeAktiflestirveDoldur = false;

    }

    // GOVDE ETKILESIMLER BITIS





    // ALTLIK ETKILESIMLER BASLANGIC
    public void KirmiziAltlikItemTiklama()
    {
        // KIRMIZI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziAltlikAktiflestirveDoldur = true;
            YesilAltlikAktiflestirveDoldur = false;
            MaviAltlikAktiflestirveDoldur = false;
        }
        else
        {
            KirmiziAltlikAktiflestirveDoldurYetersiz = true;
        }

        KirmiziAltlikOnGosterim = true;

        Altlik1.GetComponent<Renderer>().material = KirmiziAltlik;
        Altlik2.GetComponent<Renderer>().material = KirmiziAltlik;
        Altlik3.GetComponent<Renderer>().material = KirmiziAltlik;
        Altlik4.GetComponent<Renderer>().material = KirmiziAltlik;
        Altlik5.GetComponent<Renderer>().material = KirmiziAltlik;
        Altlik6.GetComponent<Renderer>().material = KirmiziAltlik;
        // cakma gosterim
    }
    public void KirmiziAltlikItemOnay()
    {
        Helikopter.AltlikKaplamaDegerligi = 1;
        PlayerPrefs.SetInt("Altlik", Helikopter.AltlikKaplamaDegerligi);
    }
    public void KirmiziAltlikItemIptal()
    {
        KirmiziAltlikOnGosterim = false;
        YesilAltlikOnGosterim = false;
        MaviAltlikOnGosterim = false;

        KirmiziAltlikAktiflestirveDoldur = false;

    }

    public void YesilAltlikItemTiklama()
    {
        // YESIL GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziAltlikAktiflestirveDoldur = false;
            YesilAltlikAktiflestirveDoldur = true;
            MaviAltlikAktiflestirveDoldur = false;
        }
        else
        {
            YesilAltlikAktiflestirveDoldurYetersiz = true;
        }

        YesilAltlikOnGosterim = true;

        Altlik1.GetComponent<Renderer>().material = YesilAltlik;
        Altlik2.GetComponent<Renderer>().material = YesilAltlik;
        Altlik3.GetComponent<Renderer>().material = YesilAltlik;
        Altlik4.GetComponent<Renderer>().material = YesilAltlik;
        Altlik5.GetComponent<Renderer>().material = YesilAltlik;
        Altlik6.GetComponent<Renderer>().material = YesilAltlik;
        // cakma gosterim
    }
    public void YesilAltlikItemOnay()
    {
        Helikopter.AltlikKaplamaDegerligi = 2;
        PlayerPrefs.SetInt("Altlik", Helikopter.AltlikKaplamaDegerligi);
    }
    public void YesilAltlikItemIptal()
    {
        KirmiziAltlikOnGosterim = false;
        YesilAltlikOnGosterim = false;
        MaviAltlikOnGosterim = false;
        YesilAltlikAktiflestirveDoldur = false;

    }

    public void MaviAltlikItemTiklama()
    {
        // MAVI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziAltlikAktiflestirveDoldur = false;
            YesilAltlikAktiflestirveDoldur = false;
            MaviAltlikAktiflestirveDoldur = true;
        }
        else
        {
            MaviAltlikAktiflestirveDoldurYetersiz = true;
        }

        MaviAltlikOnGosterim = true;

        Altlik1.GetComponent<Renderer>().material = MaviAltlik;
        Altlik2.GetComponent<Renderer>().material = MaviAltlik;
        Altlik3.GetComponent<Renderer>().material = MaviAltlik;
        Altlik4.GetComponent<Renderer>().material = MaviAltlik;
        Altlik5.GetComponent<Renderer>().material = MaviAltlik;
        Altlik6.GetComponent<Renderer>().material = MaviAltlik;
        // cakma gosterim
    }
    public void MaviAltlikItemOnay()
    {
        Helikopter.AltlikKaplamaDegerligi = 3;
        PlayerPrefs.SetInt("Altlik", Helikopter.AltlikKaplamaDegerligi);
    }
    public void MaviAltlikItemIptal()
    {
        KirmiziAltlikOnGosterim = false;
        YesilAltlikOnGosterim = false;
        MaviAltlikOnGosterim = false;
        MaviAltlikAktiflestirveDoldur = false;

    }

    // ALTLIK ETKILESIMLER BITIS



    // KUYRUK ETKILESIMLER BASLANGIC
    public void KirmiziKuyrukItemTiklama()
    {
        // KIRMIZI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziKuyrukAktiflestirveDoldur = true;
            YesilKuyrukAktiflestirveDoldur = false;
            MaviKuyrukAktiflestirveDoldur = false;
        }
        else
        {
            KirmiziKuyrukAktiflestirveDoldurYetersiz = true;
        }

        KirmiziKuyrukOnGosterim = true;

        Kuyruk.GetComponent<Renderer>().material = KirmiziKuyruk;
        // cakma gosterim
    }
    public void KirmiziKuyrukItemOnay()
    {
        Helikopter.KuyrukKaplamaDegerligi = 1;
        PlayerPrefs.SetInt("Kuyruk", Helikopter.KuyrukKaplamaDegerligi);
    }
    public void KirmiziKuyrukItemIptal()
    {
        KirmiziKuyrukOnGosterim = false;
        YesilKuyrukOnGosterim = false;
        MaviKuyrukOnGosterim = false;

        KirmiziKuyrukAktiflestirveDoldur = false;

    }

    public void YesilKuyrukItemTiklama()
    {
        // YESIL GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziKuyrukAktiflestirveDoldur = false;
            YesilKuyrukAktiflestirveDoldur = true;
            MaviKuyrukAktiflestirveDoldur = false;
        }
        else
        {
            YesilKuyrukAktiflestirveDoldurYetersiz = true;
        }

        YesilKuyrukOnGosterim = true;

        Kuyruk.GetComponent<Renderer>().material = YesilKuyruk;
        // cakma gosterim
    }
    public void YesilKuyrukItemOnay()
    {
        Helikopter.KuyrukKaplamaDegerligi = 2;
        PlayerPrefs.SetInt("Kuyruk", Helikopter.KuyrukKaplamaDegerligi);
    }
    public void YesilKuyrukItemIptal()
    {
        KirmiziKuyrukOnGosterim = false;
        YesilKuyrukOnGosterim = false;
        MaviKuyrukOnGosterim = false;
        YesilKuyrukAktiflestirveDoldur = false;

    }

    public void MaviKuyrukItemTiklama()
    {
        // MAVI GOVDE BEDELI 150 GOLD VEYA 250 PUAN
        if (OyuncuAyar.ToplamPara >= 150 || OyuncuAyar.ToplamSkor >= 250)
        {
            KirmiziKuyrukAktiflestirveDoldur = false;
            YesilKuyrukAktiflestirveDoldur = false;
            MaviKuyrukAktiflestirveDoldur = true;
        }
        else
        {
            MaviKuyrukAktiflestirveDoldurYetersiz = true;
        }

        MaviKuyrukOnGosterim = true;

        Kuyruk.GetComponent<Renderer>().material = MaviKuyruk;
        // cakma gosterim
    }
    public void MaviKuyrukItemOnay()
    {
        Helikopter.KuyrukKaplamaDegerligi = 3;
        PlayerPrefs.SetInt("Kuyruk", Helikopter.KuyrukKaplamaDegerligi);
    }
    public void MaviKuyrukItemIptal()
    {
        KirmiziKuyrukOnGosterim = false;
        YesilKuyrukOnGosterim = false;
        MaviKuyrukOnGosterim = false;
        MaviKuyrukAktiflestirveDoldur = false;

    }
    // KUYRUK ETKILESIMLER BITIS
}
