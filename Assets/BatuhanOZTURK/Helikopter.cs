using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Helikopter : MonoBehaviour {
    public GameObject HeliTasiyici;
    public GameObject Govde,Pervane;
    public GameObject AltlikCubugu1, AltlikCubugu2, AltlikCubugu3, AltlikCubugu4, AltlikCubugu5, AltlikCubugu6;
    public GameObject Kuyruk;
    public GameObject Cam1, Cam2, Cam3, Cam4, Cam5;

    public GameObject YetersizParaVeyaSkorPervane1, YetersizParaVeyaSkorPervane2, YetersizParaVeyaSkorPervane3;
    public GameObject YetersizParaVeyaSkorGovde1, YetersizParaVeyaSkorGovde2, YetersizParaVeyaSkorGovde3;
    public GameObject YetersizParaVeyaSkorAltlik1, YetersizParaVeyaSkorAltlik2, YetersizParaVeyaSkorAltlik3;
    public GameObject YetersizParaVeyaSkorKuyruk1, YetersizParaVeyaSkorKuyruk2, YetersizParaVeyaSkorKuyruk3;
    public GameObject YetersizParaveyaSkorTrail1, YetersizParaveyaSkorTrail2, YetersizParaveyaSkorTrail3;

    public GameObject SatinAlimPervane1, SatinAlimPervane2, SatinAlimPervane3;
    public GameObject SatinAlimGovde1, SatinAlimGovde2, SatinAlimGovde3;
    public GameObject SatinAlimAltlik1, SatinAlimAltlik2, SatinAlimAltlik3;
    public GameObject SatinAlimKuyruk1, SatinAlimKuyruk2, SatinAlimKuyruk3;
    public GameObject SatinAlimTrail1, SatinAlimTrail2, SatinAlimTrail3;

    public Text[] SatinAlindiYazilar;
    public Text[] YetersizYazilar;

    public static string Yetersiz_ParaMoneySkorScore, SatinAlindi_ItemEsya;

    // STANDART
    public Material GovdeMat, PervaneMat, AltlikCubuguMat, KuyrukMat, CamMat;
    // PERVANE
    public Material KirmiziPervane, YesilPervane, MaviPervane;
    // GOVDE
    public Material KirmiziGovde, YesilGovde, MaviGovde;
    // ALTLIK
    public Material KirmiziAltlik, YesilAltlik, MaviAltlik;
    // ALTLIK
    public Material KirmiziKuyruk, YesilKuyruk, MaviKuyruk;

    public GameObject Trail1, Trail2, Trail3;

    public static int PervaneKaplamaDegerligi;
    public static int GovdeKaplamaDegerligi;
    public static int AltlikKaplamaDegerligi;
    public static int KuyrukKaplamaDegerligi;
    public static int TrailDegerligi;

    public bool PervaneOnGosterim, GovdeOnGosterim, KuyrukOnGosterim, AltlikOnGosterim;

    int PervaneAltinBedeli1 = 120, PervaneAltinBedeli2 = 120, PervaneAltinBedeli3 = 120;
    int PervaneSkorBedeli1 = 90, PervaneSkorBedeli2 = 90, PervaneSkorBedeli3 = 90;

    int GovdeAltinBedeli1 = 180, GovdeAltinBedeli2 = 180, GovdeAltinBedeli3 = 180;
    int GovdeSkorBedeli1 = 150, GovdeSkorBedeli2 = 150, GovdeSkorBedeli3 = 150;

    int AltlikAltinBedeli1 = 90, AltlikAltinBedeli2 = 90, AltlikAltinBedeli3 = 90;
    int AltlikSkorBedeli1 = 60, AltlikSkorBedeli2 = 60, AltlikSkorBedeli3 = 60;

    int KuyrukAltinBedeli1 = 75, KuyrukAltinBedeli2 = 75, KuyrukAltinBedeli3 = 75;
    int KuyrukSkorBedeli1 = 45, KuyrukSkorBedeli2 = 45, KuyrukSkorBedeli3 = 45;

    int TrailParaBedeli1 = 200, TrailParaBedeli2 = 325, TrailParaBedeli3 = 425;
    int TrailSkorBedeli1 = 200, TrailSkorBedeli2 = 325, TrailSkorBedeli3 = 425;

    public static int PervaneSatinAlindi1, PervaneSatinAlindi2, PervaneSatinAlindi3;
    public static int GovdeSatinAlindi1, GovdeSatinAlindi2, GovdeSatinAlindi3;
    public static int KuyrukSatinAlindi1, KuyrukSatinAlindi2, KuyrukSatinAlindi3;
    public static int AltlikSatinAlindi1, AltlikSatinAlindi2, AltlikSatinAlindi3;

   public static int TrailSatinAlindi1, TrailSatinAlindi2, TrailSatinAlindi3;

    void Start () {

        PervaneOnGosterim = false;
        GovdeOnGosterim = false;
        KuyrukOnGosterim = false;
        AltlikOnGosterim = false;

        TrailDegerligi = PlayerPrefs.GetInt("Trail");
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
           Trail1.SetActive(true);
        }
        else if (TrailDegerligi == 2)
        {
           Trail2.SetActive(true);
        }
        else if (TrailDegerligi == 3)
        {
          Trail3.SetActive(true);
        }
    }

    public void Trail1OnGosterim()
    {
        Trail1.SetActive(true);
        Trail2.SetActive(false);
        Trail3.SetActive(false);
    }
    public void Trail1Iptal()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }
    public void Trail1Onayla()
    {
        if (OyuncuAyar.ToplamPara >= TrailParaBedeli1 && OyuncuAyar.ToplamSkor >= TrailSkorBedeli1)
        {
            OyuncuAyar.ToplamPara -= TrailParaBedeli1;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= TrailSkorBedeli1;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            TrailDegerligi = 1;
            PlayerPrefs.SetInt("Trail", TrailDegerligi);

            TrailSatinAlindi1 = 1;
            PlayerPrefs.SetInt("TrailSatinAlindi1", TrailSatinAlindi1);

            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else
        {
            YetersizParaveyaSkorTrail1.SetActive(true);
            Invoke("Trail1false", 5.0f);
        }
    }
    void Trail1false()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }

    public void Trail2OnGosterim()
    {
        Trail1.SetActive(false);
        Trail2.SetActive(true);
        Trail3.SetActive(false);
    }
    public void Trail2Iptal()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }
    public void Trail2Onayla()
    {
        if (OyuncuAyar.ToplamPara >= TrailParaBedeli2 && OyuncuAyar.ToplamSkor >= TrailSkorBedeli2)
        {
            OyuncuAyar.ToplamPara -= TrailParaBedeli2;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= TrailSkorBedeli2;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            TrailDegerligi = 2;
            PlayerPrefs.SetInt("Trail", TrailDegerligi);

            TrailSatinAlindi2 = 1;
            PlayerPrefs.SetInt("TrailSatinAlindi2", TrailSatinAlindi2);

            Trail1.SetActive(false);
            Trail3.SetActive(false);
        }
        else
        {
            YetersizParaveyaSkorTrail2.SetActive(true);
            Invoke("Trail2false", 5.0f);
        }
    }
    void Trail2false()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }

    public void Trail3OnGosterim()
    {
        Trail1.SetActive(false);
        Trail2.SetActive(false);
        Trail3.SetActive(true);    
    }
    public void Trail3Iptal()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }
    public void Trail3Onayla()
    {
        if (OyuncuAyar.ToplamPara >= TrailParaBedeli3 && OyuncuAyar.ToplamSkor >= TrailSkorBedeli3)
        {
            OyuncuAyar.ToplamPara -= TrailParaBedeli3;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= TrailSkorBedeli3;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            TrailDegerligi = 3;
            PlayerPrefs.SetInt("Trail", TrailDegerligi);

            TrailSatinAlindi3 = 1;
            PlayerPrefs.SetInt("TrailSatinAlindi3", TrailSatinAlindi3);

            Trail1.SetActive(false);
            Trail2.SetActive(false);
        }
        else
        {
            YetersizParaveyaSkorTrail3.SetActive(true);
            Invoke("Trail3false", 5.0f);
        }
    }
    void Trail3false()
    {
        if (TrailDegerligi == 0)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 1)
        {
            Trail1.SetActive(true);
            Trail2.SetActive(false);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 2)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(true);
            Trail3.SetActive(false);
        }
        else if (TrailDegerligi == 3)
        {
            Trail1.SetActive(false);
            Trail2.SetActive(false);
            Trail3.SetActive(true);
        }
    }


    public void PervaneMatOnGosterim()
    {
        PervaneOnGosterim = true;
    }
    public void PervaneMatOnGosterimIptal()
    {
        PervaneOnGosterim = false;
    }

    public void KirmiziPervaneSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= PervaneAltinBedeli1 && OyuncuAyar.ToplamSkor >= PervaneSkorBedeli1)
        {
            OyuncuAyar.ToplamPara -= PervaneAltinBedeli1;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= PervaneSkorBedeli1;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            PervaneKaplamaDegerligi = 1;
            PlayerPrefs.SetInt("Pervane", PervaneKaplamaDegerligi);

            PervaneOnGosterim = false;

            PervaneSatinAlindi1 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi1", PervaneSatinAlindi1);
            SatinAlimPervane1.SetActive(true);
        }
        else
        {
            YetersizParaVeyaSkorPervane1.SetActive(true);
            Invoke("Pervane1false", 5.0f);
        }
        
    }
    void Pervane1false()
    {
        YetersizParaVeyaSkorPervane1.SetActive(false);
        PervaneOnGosterim = false;
    }

    public void YesilPervaneSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= PervaneAltinBedeli2 && OyuncuAyar.ToplamSkor >= PervaneSkorBedeli2)
        {
            OyuncuAyar.ToplamPara -= PervaneAltinBedeli2;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= PervaneSkorBedeli2;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            PervaneOnGosterim = false;

            SatinAlimPervane2.SetActive(true);

            PervaneSatinAlindi2 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi2", PervaneSatinAlindi2);

            PervaneKaplamaDegerligi = 2;
            PlayerPrefs.SetInt("Pervane", PervaneKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorPervane2.SetActive(true);
            Invoke("Pervane2false", 5.0f);
        }
    }
    void Pervane2false()
    {
        YetersizParaVeyaSkorPervane2.SetActive(false);
        PervaneOnGosterim = false;
    }
    public void MaviPervaneSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= PervaneAltinBedeli3 && OyuncuAyar.ToplamSkor >= PervaneSkorBedeli3)
        {
            OyuncuAyar.ToplamPara -= PervaneAltinBedeli3;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= PervaneSkorBedeli3;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            PervaneOnGosterim = false;

            SatinAlimPervane3.SetActive(true);

            PervaneSatinAlindi3 = 1;
            PlayerPrefs.SetInt("PervaneSatinAlindi3", PervaneSatinAlindi3);

            PervaneKaplamaDegerligi = 3;
            PlayerPrefs.SetInt("Pervane", PervaneKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorPervane3.SetActive(true);
            Invoke("Pervane3false", 5.0f);
        }
    }
    void Pervane3false()
    {
        YetersizParaVeyaSkorPervane3.SetActive(false);
        PervaneOnGosterim = false;
    }

    public void GovdeMatOnGosterim()
    {
        GovdeOnGosterim = true;
    }
    public void GovdeMatOnGosterimIptal()
    {
        GovdeOnGosterim = false;
    }

    public void KirmiziGovdeSatinAlimOnayi()
    {

        if (OyuncuAyar.ToplamPara >= GovdeAltinBedeli1 && OyuncuAyar.ToplamSkor >= GovdeSkorBedeli1)
        {
            OyuncuAyar.ToplamPara -= GovdeAltinBedeli1;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= GovdeSkorBedeli1;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            GovdeOnGosterim = false;

            SatinAlimGovde1.SetActive(true);

            GovdeSatinAlindi1 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi1", GovdeSatinAlindi1);

            GovdeKaplamaDegerligi = 1;
            PlayerPrefs.SetInt("Govde", GovdeKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorGovde1.SetActive(true);
            Invoke("Govde1false", 5.0f);
        }
    }
    void Govde1false()
    {
        YetersizParaVeyaSkorGovde1.SetActive(false);
        GovdeOnGosterim = false;
    }
    public void YesilGovdeSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= GovdeAltinBedeli2 && OyuncuAyar.ToplamSkor >= GovdeSkorBedeli2)
        {
            OyuncuAyar.ToplamPara -= GovdeAltinBedeli2;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= GovdeSkorBedeli2;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            GovdeOnGosterim = false;

            SatinAlimGovde2.SetActive(true);

            GovdeSatinAlindi2 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi2", GovdeSatinAlindi2);

            GovdeKaplamaDegerligi = 2;
            PlayerPrefs.SetInt("Govde", GovdeKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorGovde2.SetActive(true);
            Invoke("Govde2false", 5.0f);
        }
    }
    void Govde2false()
    {
        YetersizParaVeyaSkorGovde2.SetActive(false);
        GovdeOnGosterim = false;
    }

    public void MaviGovdeSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= GovdeAltinBedeli3 && OyuncuAyar.ToplamSkor >= GovdeSkorBedeli3)
        {
            OyuncuAyar.ToplamPara -= GovdeAltinBedeli3;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= GovdeSkorBedeli3;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            GovdeOnGosterim = false;

            SatinAlimGovde3.SetActive(true);

            GovdeSatinAlindi3 = 1;
            PlayerPrefs.SetInt("GovdeSatinAlindi3", GovdeSatinAlindi3);

            GovdeKaplamaDegerligi = 3;
            PlayerPrefs.SetInt("Govde", GovdeKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorGovde3.SetActive(true);
            Invoke("Govde3false", 5.0f);
        }
    }
    void Govde3false()
    {
        YetersizParaVeyaSkorGovde3.SetActive(false);
        GovdeOnGosterim = false;
    }

    public void KuyrukMatOnGosterim()
    {
        KuyrukOnGosterim = true;
    }
    public void KuyrukMatOnGosterimIptal()
    {
        KuyrukOnGosterim = false;
    }

    public void KirmiziKuyrukSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= KuyrukAltinBedeli1 && OyuncuAyar.ToplamSkor >= KuyrukSkorBedeli1)
        {
            OyuncuAyar.ToplamPara -= KuyrukAltinBedeli1;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= KuyrukSkorBedeli1;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            KuyrukOnGosterim = false;

            SatinAlimKuyruk1.SetActive(true);

            KuyrukSatinAlindi1 = 1;
            PlayerPrefs.SetInt("KuyrukSatinAlindi1", KuyrukSatinAlindi1);

            KuyrukKaplamaDegerligi = 1;
            PlayerPrefs.SetInt("Kuyruk", KuyrukKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorKuyruk1.SetActive(true);
            Invoke("Kuyruk1false", 5.0f);
        }
    }
    void Kuyruk1false()
    {
        YetersizParaVeyaSkorKuyruk1.SetActive(false);
        KuyrukOnGosterim = false;
    }
    public void YesilKuyrukSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= KuyrukAltinBedeli2 && OyuncuAyar.ToplamSkor >= KuyrukSkorBedeli2)
        {
            OyuncuAyar.ToplamPara -= KuyrukAltinBedeli2;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= KuyrukSkorBedeli2;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            KuyrukOnGosterim = false;

            SatinAlimKuyruk2.SetActive(true);

            KuyrukSatinAlindi2 = 1;
            PlayerPrefs.SetInt("KuyrukSatinAlindi2", KuyrukSatinAlindi2);

            KuyrukKaplamaDegerligi = 2;
            PlayerPrefs.SetInt("Kuyruk", KuyrukKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorKuyruk2.SetActive(true);
            Invoke("Kuyruk2false", 5.0f);
        }
    }
    void Kuyruk2false()
    {
        YetersizParaVeyaSkorKuyruk2.SetActive(false);
        KuyrukOnGosterim = false;
    }
    public void MaviKuyrukSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= KuyrukAltinBedeli3 && OyuncuAyar.ToplamSkor >= KuyrukSkorBedeli3)
        {
            OyuncuAyar.ToplamPara -= KuyrukAltinBedeli3;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= KuyrukSkorBedeli3;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            KuyrukOnGosterim = false;

            SatinAlimKuyruk3.SetActive(true);

            KuyrukSatinAlindi3 = 1;
            PlayerPrefs.SetInt("KuyrukSatinAlindi3", KuyrukSatinAlindi3);

            KuyrukKaplamaDegerligi = 3;
            PlayerPrefs.SetInt("Kuyruk", KuyrukKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorKuyruk3.SetActive(true);
            Invoke("Kuyruk3false", 5.0f);
        }
    }
    void Kuyruk3false()
    {
        YetersizParaVeyaSkorKuyruk3.SetActive(false);
        KuyrukOnGosterim = false;
    }

    public void AltlikMatOnGosterim()
    {
       AltlikOnGosterim = true;
    }
    public void AltlikMatOnGosterimIptal()
    {
        AltlikOnGosterim = false;
    }


    public void KirmiziAltlikSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= AltlikAltinBedeli1 && OyuncuAyar.ToplamSkor >= AltlikSkorBedeli1)
        {
            OyuncuAyar.ToplamPara -= AltlikAltinBedeli1;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= AltlikSkorBedeli1;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            AltlikOnGosterim = false;

            SatinAlimAltlik1.SetActive(true);

            AltlikSatinAlindi1 = 1;
            PlayerPrefs.SetInt("AltlikSatinAlindi1", AltlikSatinAlindi1);

            AltlikKaplamaDegerligi = 1;
            PlayerPrefs.SetInt("Altlik", AltlikKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorAltlik1.SetActive(true);
            Invoke("Altlik1false", 5.0f);
        }
    }
    void Altlik1false()
    {
        YetersizParaVeyaSkorAltlik1.SetActive(false);
        AltlikOnGosterim = false;
    }
    public void YesilAltlikSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= AltlikAltinBedeli2 && OyuncuAyar.ToplamSkor >= AltlikSkorBedeli2)
        {
            OyuncuAyar.ToplamPara -= AltlikAltinBedeli2;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= AltlikSkorBedeli2;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            AltlikOnGosterim = false;

            SatinAlimAltlik2.SetActive(true);

            AltlikSatinAlindi2 = 1;
            PlayerPrefs.SetInt("AltlikSatinAlindi2", AltlikSatinAlindi2);

            AltlikKaplamaDegerligi = 2;
            PlayerPrefs.SetInt("Altlik", AltlikKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorAltlik2.SetActive(true);
            Invoke("Altlik2false", 5.0f);
        }
    }
    void Altlik2false()
    {
        YetersizParaVeyaSkorAltlik2.SetActive(false);
        AltlikOnGosterim = false;
    }
    public void MaviAltlikSatinAlimOnayi()
    {
        if (OyuncuAyar.ToplamPara >= AltlikAltinBedeli3 && OyuncuAyar.ToplamSkor >= AltlikSkorBedeli3)
        {
            OyuncuAyar.ToplamPara -= AltlikAltinBedeli3;
            PlayerPrefs.SetInt("ToplamPara", OyuncuAyar.ToplamPara);
            OyuncuAyar.ToplamSkor -= AltlikSkorBedeli3;
            PlayerPrefs.SetInt("ToplamSkor", OyuncuAyar.ToplamSkor);

            AltlikOnGosterim = false;

            SatinAlimAltlik3.SetActive(true);

            AltlikSatinAlindi3 = 1;
            PlayerPrefs.SetInt("AltlikSatinAlindi3", AltlikSatinAlindi3);

            AltlikKaplamaDegerligi = 3;
            PlayerPrefs.SetInt("Altlik", AltlikKaplamaDegerligi);
        }
        else
        {
            YetersizParaVeyaSkorAltlik3.SetActive(true);
            Invoke("Altlik3false", 5.0f);
        }
    }
    void Altlik3false()
    {
        YetersizParaVeyaSkorAltlik3.SetActive(false);
        AltlikOnGosterim = false;
    }

    void Update () {

        TrailSatinAlindi1 = PlayerPrefs.GetInt("TrailSatinAlindi1");
        TrailSatinAlindi2 = PlayerPrefs.GetInt("TrailSatinAlindi2");
        TrailSatinAlindi3 = PlayerPrefs.GetInt("TrailSatinAlindi3");

        PervaneSatinAlindi1 = PlayerPrefs.GetInt("PervaneSatinAlindi1");
        PervaneSatinAlindi2 = PlayerPrefs.GetInt("PervaneSatinAlindi2");
        PervaneSatinAlindi3 = PlayerPrefs.GetInt("PervaneSatinAlindi3");

        GovdeSatinAlindi1 = PlayerPrefs.GetInt("GovdeSatinAlindi1");
        GovdeSatinAlindi2 = PlayerPrefs.GetInt("GovdeSatinAlindi2");
        GovdeSatinAlindi3 = PlayerPrefs.GetInt("GovdeSatinAlindi3");

        KuyrukSatinAlindi1 = PlayerPrefs.GetInt("KuyrukSatinAlindi1");
        KuyrukSatinAlindi2 = PlayerPrefs.GetInt("KuyrukSatinAlindi2");
        KuyrukSatinAlindi3 = PlayerPrefs.GetInt("KuyrukSatinAlindi3");

        AltlikSatinAlindi1 = PlayerPrefs.GetInt("AltlikSatinAlindi1");
        AltlikSatinAlindi2 = PlayerPrefs.GetInt("AltlikSatinAlindi2");
        AltlikSatinAlindi3 = PlayerPrefs.GetInt("AltlikSatinAlindi3");

        if (TrailSatinAlindi1 == 1)
        {
            SatinAlimTrail1.SetActive(true);
            TrailParaBedeli1 = 0;
            TrailSkorBedeli1 = 0;
        }
        if (TrailSatinAlindi2 == 1)
        {
            SatinAlimTrail2.SetActive(true);
            TrailParaBedeli2 = 0;
            TrailSkorBedeli2 = 0;
        }
        if (TrailSatinAlindi3 == 1)
        {
            SatinAlimTrail3.SetActive(true);
            TrailParaBedeli3 = 0;
            TrailSkorBedeli3 = 0;
        }

        if (PervaneSatinAlindi1 == 1)
        {
            SatinAlimPervane1.SetActive(true);
            PervaneAltinBedeli1 = 0;
            PervaneSkorBedeli1 = 0;
        }
        if (PervaneSatinAlindi2 == 1)
        {
            SatinAlimPervane2.SetActive(true);
            PervaneAltinBedeli2 = 0;
            PervaneSkorBedeli2 = 0;
        }
        if (PervaneSatinAlindi3 == 1)
        {
            SatinAlimPervane3.SetActive(true);
            PervaneAltinBedeli3 = 0;
            PervaneSkorBedeli3 = 0;
        }

        if (GovdeSatinAlindi1 == 1)
        {
            SatinAlimGovde1.SetActive(true);
            GovdeAltinBedeli1 = 0;
            GovdeSkorBedeli1 = 0;
        }
        if (GovdeSatinAlindi2 == 1)
        {
            SatinAlimGovde2.SetActive(true);
            GovdeAltinBedeli2 = 0;
            GovdeSkorBedeli2 = 0;
        }
        if (GovdeSatinAlindi3 == 1)
        {
            SatinAlimGovde3.SetActive(true);
            GovdeAltinBedeli3 = 0;
            GovdeSkorBedeli3 = 0;
        }


        if (KuyrukSatinAlindi1 == 1)
        {
            SatinAlimKuyruk1.SetActive(true);
            KuyrukAltinBedeli1 = 0;
            KuyrukSkorBedeli1 = 0;
        }
        if (KuyrukSatinAlindi2 == 1)
        {
            SatinAlimKuyruk2.SetActive(true);
            KuyrukAltinBedeli2 = 0;
            KuyrukSkorBedeli2 = 0;
        }
        if (KuyrukSatinAlindi3 == 1)
        {
            SatinAlimKuyruk3.SetActive(true);
            KuyrukAltinBedeli3 = 0;
            KuyrukSkorBedeli3 = 0;
        }


        if (AltlikSatinAlindi1 == 1)
        {
            SatinAlimAltlik1.SetActive(true);
            AltlikAltinBedeli1 = 0;
            AltlikSkorBedeli1 = 0;
        }
        if (AltlikSatinAlindi2 == 1)
        {
            SatinAlimAltlik2.SetActive(true);
            AltlikAltinBedeli2 = 0;
            AltlikSkorBedeli2 = 0;
        }
        if (AltlikSatinAlindi3 == 1)
        {
            SatinAlimAltlik3.SetActive(true);
            AltlikAltinBedeli3 = 0;
            AltlikSkorBedeli3 = 0;
        }

        PervaneKaplamaDegerligi = PlayerPrefs.GetInt("Pervane");
        GovdeKaplamaDegerligi = PlayerPrefs.GetInt("Govde");
        AltlikKaplamaDegerligi = PlayerPrefs.GetInt("Altlik");
        KuyrukKaplamaDegerligi = PlayerPrefs.GetInt("Kuyruk");
        TrailDegerligi = PlayerPrefs.GetInt("Trail");

        OyuncuAyar.ToplamPara = PlayerPrefs.GetInt("ToplamPara");
        OyuncuAyar.ToplamSkor = PlayerPrefs.GetInt("ToplamSkor");

        YetersizYazilar[0].fontSize = Screen.width / 38;
        YetersizYazilar[1].fontSize = Screen.width / 38;
        YetersizYazilar[2].fontSize = Screen.width / 38;
        YetersizYazilar[3].fontSize = Screen.width / 38;
        YetersizYazilar[4].fontSize = Screen.width / 38;
        YetersizYazilar[5].fontSize = Screen.width / 38;
        YetersizYazilar[6].fontSize = Screen.width / 38;
        YetersizYazilar[7].fontSize = Screen.width / 38;
        YetersizYazilar[8].fontSize = Screen.width / 38;
        YetersizYazilar[9].fontSize = Screen.width / 38;
        YetersizYazilar[10].fontSize = Screen.width / 38;
        YetersizYazilar[11].fontSize = Screen.width / 38;
        YetersizYazilar[12].fontSize = Screen.width / 38;
        YetersizYazilar[13].fontSize = Screen.width / 38;
        YetersizYazilar[14].fontSize = Screen.width / 38;

        YetersizYazilar[0].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[1].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[2].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[3].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[4].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[5].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[6].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[7].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[8].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[9].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[10].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[11].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[12].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[13].text = Yetersiz_ParaMoneySkorScore;
        YetersizYazilar[14].text = Yetersiz_ParaMoneySkorScore;

        SatinAlindiYazilar[0].fontSize = Screen.width / 38;
        SatinAlindiYazilar[1].fontSize = Screen.width / 38;
        SatinAlindiYazilar[2].fontSize = Screen.width / 38;
        SatinAlindiYazilar[3].fontSize = Screen.width / 38;
        SatinAlindiYazilar[4].fontSize = Screen.width / 38;
        SatinAlindiYazilar[5].fontSize = Screen.width / 38;
        SatinAlindiYazilar[6].fontSize = Screen.width / 38;
        SatinAlindiYazilar[7].fontSize = Screen.width / 38;
        SatinAlindiYazilar[8].fontSize = Screen.width / 38;
        SatinAlindiYazilar[9].fontSize = Screen.width / 38;
        SatinAlindiYazilar[10].fontSize = Screen.width / 38;
        SatinAlindiYazilar[11].fontSize = Screen.width / 38;
        SatinAlindiYazilar[12].fontSize = Screen.width / 38;
        SatinAlindiYazilar[13].fontSize = Screen.width / 38;
        SatinAlindiYazilar[14].fontSize = Screen.width / 38;

        SatinAlindiYazilar[0].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[1].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[2].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[3].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[4].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[5].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[6].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[7].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[8].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[9].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[10].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[11].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[12].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[13].text = SatinAlindi_ItemEsya;
        SatinAlindiYazilar[14].text = SatinAlindi_ItemEsya;

        if (PervaneOnGosterim)
        {

        }
        else
        {
            // PERVANE
            if (PervaneKaplamaDegerligi == 0)
            {
                Pervane.GetComponent<Renderer>().material = PervaneMat;
            }
            else if (PervaneKaplamaDegerligi == 1)
            {
                Pervane.GetComponent<Renderer>().material = KirmiziPervane;
            }
            else if (PervaneKaplamaDegerligi == 2)
            {
                Pervane.GetComponent<Renderer>().material = YesilPervane;
            }
            else if (PervaneKaplamaDegerligi == 3)
            {
                Pervane.GetComponent<Renderer>().material = MaviPervane;
            }
        }


        if (GovdeOnGosterim)
        {
        
        }
        else
        {
            // GOVDE
            if (GovdeKaplamaDegerligi == 0)
            {
                Govde.GetComponent<Renderer>().material = GovdeMat;
            }
            else if (GovdeKaplamaDegerligi == 1)
            {
                Govde.GetComponent<Renderer>().material = KirmiziGovde;
            }
            else if (GovdeKaplamaDegerligi == 2)
            {
                Govde.GetComponent<Renderer>().material = YesilGovde;
            }
            else if (GovdeKaplamaDegerligi == 3)
            {
                Govde.GetComponent<Renderer>().material = MaviGovde;
            }
        }

        if (AltlikOnGosterim)
        {

        }
        else
        {
            // ALTLIK
            if (AltlikKaplamaDegerligi == 0)
            {
                AltlikCubugu1.GetComponent<Renderer>().material = AltlikCubuguMat;
                AltlikCubugu2.GetComponent<Renderer>().material = AltlikCubuguMat;
                AltlikCubugu3.GetComponent<Renderer>().material = AltlikCubuguMat;
                AltlikCubugu4.GetComponent<Renderer>().material = AltlikCubuguMat;
                AltlikCubugu5.GetComponent<Renderer>().material = AltlikCubuguMat;
                AltlikCubugu6.GetComponent<Renderer>().material = AltlikCubuguMat;
            }
            else if (AltlikKaplamaDegerligi == 1)
            {
                AltlikCubugu1.GetComponent<Renderer>().material = KirmiziAltlik;
                AltlikCubugu2.GetComponent<Renderer>().material = KirmiziAltlik;
                AltlikCubugu3.GetComponent<Renderer>().material = KirmiziAltlik;
                AltlikCubugu4.GetComponent<Renderer>().material = KirmiziAltlik;
                AltlikCubugu5.GetComponent<Renderer>().material = KirmiziAltlik;
                AltlikCubugu6.GetComponent<Renderer>().material = KirmiziAltlik;
            }
            else if (AltlikKaplamaDegerligi == 2)
            {
                AltlikCubugu1.GetComponent<Renderer>().material = YesilAltlik;
                AltlikCubugu2.GetComponent<Renderer>().material = YesilAltlik;
                AltlikCubugu3.GetComponent<Renderer>().material = YesilAltlik;
                AltlikCubugu4.GetComponent<Renderer>().material = YesilAltlik;
                AltlikCubugu5.GetComponent<Renderer>().material = YesilAltlik;
                AltlikCubugu6.GetComponent<Renderer>().material = YesilAltlik;
            }
            else if (AltlikKaplamaDegerligi == 3)
            {
                AltlikCubugu1.GetComponent<Renderer>().material = MaviAltlik;
                AltlikCubugu2.GetComponent<Renderer>().material = MaviAltlik;
                AltlikCubugu3.GetComponent<Renderer>().material = MaviAltlik;
                AltlikCubugu4.GetComponent<Renderer>().material = MaviAltlik;
                AltlikCubugu5.GetComponent<Renderer>().material = MaviAltlik;
                AltlikCubugu6.GetComponent<Renderer>().material = MaviAltlik;
            }
        }
        
        if (KuyrukOnGosterim) {

        }
        else
        {
            // KUYRUK
            if (KuyrukKaplamaDegerligi == 0)
            {
                Kuyruk.GetComponent<Renderer>().material = KuyrukMat;         
            }
            else if (KuyrukKaplamaDegerligi == 1)
            {
                Kuyruk.GetComponent<Renderer>().material = KirmiziKuyruk;
            }
            else if (KuyrukKaplamaDegerligi == 2)
            {
                Kuyruk.GetComponent<Renderer>().material = YesilKuyruk;
            }
            else if (KuyrukKaplamaDegerligi == 3)
            {
                Kuyruk.GetComponent<Renderer>().material = MaviKuyruk;
            }
        }



    }
}
