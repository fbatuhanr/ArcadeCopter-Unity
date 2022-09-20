using UnityEngine;
using System.Collections;

public class Engel_Karsilikli : MonoBehaviour
{
	public Material[] GoldSilver;
	public Material[] ParaKenarlik;

	public GameObject[] ParaOn;
	public GameObject[] ParaArka;
	public GameObject[] Kenarliklar;

    public GameObject[] HideShowGolds;

    float xYuks;

    float RastGeleYukseklikUst1;
    float RastGeleYukseklikAlt1;

    float RastGeleYukseklikUst2;
    float RastGeleYukseklikAlt2;

    float RastGeleYukseklikUst3;
    float RastGeleYukseklikAlt3;

    float RastGeleYukseklikUst4;
    float RastGeleYukseklikAlt4;

    public static bool EngelKarsilikliBitisi;
    public static bool IleriAt;

    public Transform KarsilikliEngeller;

    public Transform EngelKarsilikli;
    public Transform EngelKarsilikli2;
    public Transform EngelKarsilikli3;
    public Transform EngelKarsilikli4;


    public GameObject Alt1;
    public GameObject Ust1;
    int RastgeleAlt1;
    int RastgeleUst1;

    public GameObject Alt2;
    public GameObject Ust2;
    int RastgeleAlt2;
    int RastgeleUst2;

    public GameObject Alt3;
    public GameObject Ust3;
    int RastgeleAlt3;
    int RastgeleUst3;

    public GameObject Alt4;
    public GameObject Ust4;
    int RastgeleAlt4;
    int RastgeleUst4;

    bool CisimKareAlt1;
    bool CisimKareUst1;
    bool KareIhtimalAlt1;
    bool KareIhtimalUst1;

    bool CisimKareAlt2;
    bool CisimKareUst2;
    bool KareIhtimalAlt2;
    bool KareIhtimalUst2;

    bool CisimKareAlt3;
    bool CisimKareUst3;
    bool KareIhtimalAlt3;
    bool KareIhtimalUst3;

    bool CisimKareAlt4;
    bool CisimKareUst4;
    bool KareIhtimalAlt4;
    bool KareIhtimalUst4;

    public bool TemasOlayi1;
    public bool TemasOlayi2;
    public bool TemasOlayi3;
    public bool TemasOlayi4;

    int BaslangictaGorunurluk;
    void Start()
    {
        xYuks = -8.1f;

        BaslangictaGorunurluk = Random.Range(0,5);

        if (BaslangictaGorunurluk == 0) { 

        Alt1.SetActive(true);
        Ust1.SetActive(false);

        Alt2.SetActive(false);
        Ust2.SetActive(true);

        Alt3.SetActive(true);
        Ust3.SetActive(false);

        Alt4.SetActive(false);
        Ust4.SetActive(true);

        }
        else if (BaslangictaGorunurluk == 1)
        {
            Alt1.SetActive(false);
            Ust1.SetActive(true);

            Alt2.SetActive(true);
            Ust2.SetActive(false);

            Alt3.SetActive(false);
            Ust3.SetActive(true);

            Alt4.SetActive(true);
            Ust4.SetActive(false);
        }
        else if (BaslangictaGorunurluk == 2)
        {
            Alt1.SetActive(true);
            Ust1.SetActive(true);

            Alt2.SetActive(true);
            Ust2.SetActive(false);

            Alt3.SetActive(false);
            Ust3.SetActive(true);

            Alt4.SetActive(true);
            Ust4.SetActive(true);
        }
        else if (BaslangictaGorunurluk == 3)
        {
            Alt1.SetActive(false);
            Ust1.SetActive(true);

            Alt2.SetActive(true);
            Ust2.SetActive(true);

            Alt3.SetActive(true);
            Ust3.SetActive(false);

            Alt4.SetActive(true);
            Ust4.SetActive(false);
        }
        else if (BaslangictaGorunurluk == 4)
        {
            Alt1.SetActive(true);
            Ust1.SetActive(true);

            Alt2.SetActive(false);
            Ust2.SetActive(true);

            Alt3.SetActive(true);
            Ust3.SetActive(false);

            Alt4.SetActive(false);
            Ust4.SetActive(true);
        }


        IleriAt = false;

        CisimKareAlt1 = false;
        CisimKareUst1 = false;
        KareIhtimalAlt1 = false;
        KareIhtimalUst1 = false;

        CisimKareAlt2 = false;
        CisimKareUst2 = false;
        KareIhtimalAlt2 = false;
        KareIhtimalUst2 = false;

        CisimKareAlt3 = false;
        CisimKareUst3 = false;
        KareIhtimalAlt3 = false;
        KareIhtimalUst3 = false;

        CisimKareAlt4 = false;
        CisimKareUst4 = false;
        KareIhtimalAlt4 = false;
        KareIhtimalUst4 = false;

        EngelKarsilikliBitisi = false;
        TemasOlayi1 = false;
        TemasOlayi2 = false;
        TemasOlayi3 = false;
        TemasOlayi4 = false;
        
        // ALT 1 - UST 1 BASLANGIC
        if (Alt1.transform.rotation.z > -0.8f)
        {
            HideShowGolds[1].SetActive(false);
            HideShowGolds[9].SetActive(true);
        }
        else
        {
            HideShowGolds[1].SetActive(true);
            HideShowGolds[9].SetActive(false);
        }

        if (Ust1.transform.rotation.z > -0.8f)
        {
            HideShowGolds[0].SetActive(false);
            HideShowGolds[8].SetActive(true);
        }
        else
        {
            HideShowGolds[0].SetActive(true);
            HideShowGolds[8].SetActive(false);
        }
        // ALT 1 - UST 1 BITIS


        // ALT 2 - UST 2 BASLANGIC
        if (Alt2.transform.rotation.z > -0.8f)
        {
            HideShowGolds[3].SetActive(false);
            HideShowGolds[11].SetActive(true);
        }
        else
        {
            HideShowGolds[3].SetActive(true);
            HideShowGolds[11].SetActive(false);
        }

        if (Ust2.transform.rotation.z > -0.8f)
        {
            HideShowGolds[2].SetActive(false);
            HideShowGolds[10].SetActive(true);
        }
        else
        {
            HideShowGolds[2].SetActive(true);
            HideShowGolds[10].SetActive(false);
        }
        // ALT 2 - UST 2 BITIS


        // ALT 3 - UST 3 BASLANGIC
        if (Alt3.transform.rotation.z > -0.8f)
        {
            HideShowGolds[5].SetActive(false);
            HideShowGolds[13].SetActive(true);
        }
        else
        {
            HideShowGolds[5].SetActive(true);
            HideShowGolds[13].SetActive(false);
        }

        if (Ust3.transform.rotation.z > -0.8f)
        {
            HideShowGolds[4].SetActive(false);
            HideShowGolds[12].SetActive(true);
        }
        else
        {
            HideShowGolds[4].SetActive(true);
            HideShowGolds[12].SetActive(false);
        }
        // ALT 3 - UST 3 BITIS


        // ALT 4 - UST 4 BASLANGIC
        if (Alt4.transform.rotation.z > -0.8f)
        {
            HideShowGolds[7].SetActive(false);
            HideShowGolds[15].SetActive(true);
        }
        else
        {
            HideShowGolds[7].SetActive(true);
            HideShowGolds[15].SetActive(false);
        }

        if (Ust4.transform.rotation.z > -0.8f)
        {
            HideShowGolds[6].SetActive(false);
            HideShowGolds[14].SetActive(true);
        }
        else
        {
            HideShowGolds[6].SetActive(true);
            HideShowGolds[14].SetActive(false);
        }
        // ALT 4 - UST 4 BITIS
            ParaOn[0].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[1].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[2].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[3].GetComponent<Renderer>().material = GoldSilver[1];

            Kenarliklar[0].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[1].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[2].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[3].GetComponent<Renderer>().material = ParaKenarlik[1];

            ParaArka[0].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[1].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[2].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[3].GetComponent<Renderer>().material = GoldSilver[1];

            ParaOn[4].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[5].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[6].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[7].GetComponent<Renderer>().material = GoldSilver[1];

            Kenarliklar[4].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[5].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[6].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[7].GetComponent<Renderer>().material = ParaKenarlik[1];

            ParaArka[4].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[5].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[6].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[7].GetComponent<Renderer>().material = GoldSilver[1];

            ParaOn[8].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[9].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[10].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[11].GetComponent<Renderer>().material = GoldSilver[1];

            Kenarliklar[8].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[9].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[10].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[11].GetComponent<Renderer>().material = ParaKenarlik[1];

            ParaArka[8].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[9].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[10].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[11].GetComponent<Renderer>().material = GoldSilver[1];

            ParaOn[12].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[13].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[14].GetComponent<Renderer>().material = GoldSilver[1];
            ParaOn[15].GetComponent<Renderer>().material = GoldSilver[1];

            Kenarliklar[12].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[13].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[14].GetComponent<Renderer>().material = ParaKenarlik[1];
            Kenarliklar[15].GetComponent<Renderer>().material = ParaKenarlik[1];

            ParaArka[12].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[13].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[14].GetComponent<Renderer>().material = GoldSilver[1];
            ParaArka[15].GetComponent<Renderer>().material = GoldSilver[1];
        }
        // RANDOM COLOR APPLY :)

    void Update()
    {
        if (TemasOlayi1)
        {
            if (EngelKarsilikliBitisi == false) { 
            Invoke("OtoAta", 2.0f);
            TemasOlayi1 = false;
            }
            else
            {

            }
        }

        if (TemasOlayi2)
        {
            if (EngelKarsilikliBitisi == false)
            {
                Invoke("OtoAta2", 2.0f);
                TemasOlayi2 = false;
            }
            else
            {

            }
        }
        if (TemasOlayi3)
        {
            if (EngelKarsilikliBitisi == false)
            {
                Invoke("OtoAta3", 2.0f);
                TemasOlayi3 = false;
            }
         }
        if (TemasOlayi4)
        {
            if (EngelKarsilikliBitisi == false)
            {
                Invoke("OtoAta4", 2.0f);
                TemasOlayi4 = false;
            }
            else
            {

            }
        }
        if (Alt1.activeSelf == true && Ust1.activeSelf == true)
        {
            HideShowGolds[1].SetActive(false);
        }
        if (Alt2.activeSelf == true && Ust2.activeSelf == true)
        {
            HideShowGolds[3].SetActive(false);
        }
        if (Alt3.activeSelf == true && Ust3.activeSelf == true)
        {
            HideShowGolds[5].SetActive(false);
        }
        if (Alt4.activeSelf == true && Ust4.activeSelf == true)
        {
            HideShowGolds[7].SetActive(false);
        }
        }

    void OtoAta()
    {
        EngelKarsilikli.transform.position = EngelKarsilikli.transform.position + new Vector3(85.0f, 0, 0);

        if (((Ust4.transform.localEulerAngles.z > 40.0f && Ust4.transform.localEulerAngles.z < 50.0f) && Ust4.transform.position.y <= 20.0f) && (Ust1.transform.localEulerAngles.z > 80.0f && Ust1.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt1 = Random.Range(-8.0f, -2.4f);
            float FBRxUst1 = Random.Range(20.0f, 24.6f);
            Ust1.transform.position = new Vector3(Ust2.transform.position.x, FBRxUst1, 1.8f);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, FBRxAlt1, 1.8f);
        }


        if (((Alt4.transform.localEulerAngles.z > 40.0f && Alt4.transform.localEulerAngles.z < 50.0f) && Alt4.transform.position.y > -5.0f && Alt4.transform.position.y <= 3.0f) && (Alt1.transform.localEulerAngles.z > 80.0f && Alt1.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt1 = Random.Range(-8.0f, -2.4f);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, FBRxAlt1, 1.8f);
        }

        if (((Ust4.transform.localEulerAngles.z > 80.0f && Ust4.transform.localEulerAngles.z < 100.0f) && Ust4.transform.position.y <= 20.0f) && (Alt1.transform.localEulerAngles.z > 80.0f && Alt1.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt1 = Random.Range(-8.0f, -2.4f);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, FBRxAlt1, 1.8f);
        }
        if (((Alt2.transform.localEulerAngles.z > 80.0f && Alt2.transform.localEulerAngles.z < 100.0f) && Alt2.transform.position.y > -5.0f && Alt2.transform.position.y <= 3.0f) && (Ust1.transform.localEulerAngles.z > 80.0f && Ust1.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxUst1 = Random.Range(20.0f, 24.6f);
            Ust1.transform.position = new Vector3(Ust1.transform.position.x, FBRxUst1, 1.8f);
        }

        if (((Alt1.transform.localEulerAngles.z > 80.0f && Alt1.transform.localEulerAngles.z < 100.0f) && Alt1.transform.position.y > -5.0f && Alt1.transform.position.y <= 3.0f) && (Ust2.transform.localEulerAngles.z > 80.0f && Ust2.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt1 = Random.Range(-8.0f, -2.4f);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, FBRxAlt1, 1.8f);
        }

        ///////////////////////////////
        if (KareIhtimalAlt1)
        {
            int KareMiUcgenMiAlt1 = Random.Range(1, 3);
            if (KareMiUcgenMiAlt1 == 1)
            {
                CisimKareAlt1 = true;       
            }
            else if (KareMiUcgenMiAlt1 == 2)
            {
                CisimKareAlt1 = false;
            }
            if (CisimKareAlt1)
            {
                Alt1.transform.localScale = new Vector3(1, 0.65f, 1);
                Alt1.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {         
                Alt1.transform.localScale = new Vector3(1, 1, 1);
                Alt1.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }

        if (CisimKareAlt1)
        {
            xYuks = -7.1f;
            RastGeleYukseklikAlt1 = Random.Range(0.0f, -7.1f);
        }
        else
        {
            xYuks = -8.1f;
            RastGeleYukseklikAlt1 = Random.Range(-8.0f, -2.1f);
        }
        if (KareIhtimalUst1)
        {
            int KareMiUcgenMiUst1 = Random.Range(1, 3);
            if (KareMiUcgenMiUst1 == 1)
            {
                CisimKareUst1 = true;
            }
            else if (KareMiUcgenMiUst1 == 2)
            {
                CisimKareUst1 = false;
            }
            if (CisimKareUst1)
            {
                Ust1.transform.localScale = new Vector3(1, 0.65f, 1);
                Ust1.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Ust1.transform.localScale = new Vector3(1, 1, 1);
                Ust1.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }
        if (CisimKareUst1)
        {
            RastGeleYukseklikUst1 = Random.Range(16.5f, 23.0f);
        }
        else
        {
            RastGeleYukseklikUst1 = Random.Range(19.5f, 25.9f);
        }

        ////////////////////////
            // ALT 1 - UST 1 BASLANGIC
            if (Alt1.transform.rotation.z > -0.8f)
            {
                HideShowGolds[1].SetActive(false);
                HideShowGolds[9].SetActive(true);
            }
            else
            {
                HideShowGolds[1].SetActive(true);
                HideShowGolds[9].SetActive(false);
            }

            if (Ust1.transform.rotation.z > -0.8f)
            {
                HideShowGolds[0].SetActive(false);
                HideShowGolds[8].SetActive(true);
            }
            else
            {
                HideShowGolds[0].SetActive(true);
                HideShowGolds[8].SetActive(false);
            }
            // ALT 1 - UST 1 BITIS

            /////////////////////////


            RastgeleAlt1 = Random.Range(0, 2);
            RastgeleUst1 = Random.Range(0, 2);
            int RastgeleDbl1 = Random.Range(0, 2);

            // MONEY MONEY MONEY
            if (RastgeleAlt1 == 1 && RastgeleUst1 == 1)
            {
                HideShowGolds[1].SetActive(false);
                HideShowGolds[9].SetActive(false);
            }
            // MONEY MONEY MONEY

            // RANDOM MONEY SPAWN :)
            int RandomMoneyPoint1 = Random.Range(1, 3);
            if (RandomMoneyPoint1 == 1 || RandomMoneyPoint1 == 2)
            {
                HideShowGolds[0].SetActive(false);
                HideShowGolds[8].SetActive(false);
            }

        // RANDOM MONEY SPAWN :)

        // RANDOM COLOR APPLY :)

        if (OyuncuAyar.Skor <= 20) {
                ParaOn[0].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[1].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[2].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[3].GetComponent<Renderer>().material = GoldSilver[1];

                Kenarliklar[0].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[1].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[2].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[3].GetComponent<Renderer>().material = ParaKenarlik[1];

                ParaArka[0].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[1].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[2].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[3].GetComponent<Renderer>().material = GoldSilver[1];
        }
        else if (OyuncuAyar.Skor > 20)
        {
                ParaOn[0].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[1].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[2].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[3].GetComponent<Renderer>().material = GoldSilver[0];

                Kenarliklar[0].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[1].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[2].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[3].GetComponent<Renderer>().material = ParaKenarlik[0];

                ParaArka[0].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[1].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[2].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[3].GetComponent<Renderer>().material = GoldSilver[0];
        }

        // RANDOM COLOR APPLY :)


        if (RastgeleAlt1 == 1)
        {
            KareIhtimalAlt1 = true;
            KareIhtimalUst1 = true;
            Alt1.SetActive(true);
            Ust1.transform.position = new Vector3(Ust1.transform.position.x, 25.9f, 1.8f);
        }
        else
        {
            KareIhtimalAlt1 = true;
            KareIhtimalUst1 = true;
            Alt1.SetActive(false);
            Ust1.transform.position = new Vector3(Ust1.transform.position.x, RastGeleYukseklikUst1, 1.8f);
        }

        if (RastgeleUst1 == 1)
        {
            KareIhtimalAlt1 = true;
            KareIhtimalUst1 = true;
            Ust1.SetActive(true);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, xYuks, 1.8f);
        }
        else
        {
            KareIhtimalAlt1 = true;
            KareIhtimalUst1 = true;
            Ust1.SetActive(false);
            Alt1.transform.position = new Vector3(Alt1.transform.position.x, RastGeleYukseklikAlt1, 1.8f);
        }
        
        if (RastgeleAlt1 == 0 && RastgeleUst1 == 0)
        {        
            if (RastgeleDbl1 == 1) {

            KareIhtimalAlt1 = true;
            Alt1.SetActive(true);
            Ust1.SetActive(false);
            }
            else
            {
            KareIhtimalUst1 = true;
            Alt1.SetActive(false);
            Ust1.SetActive(true);
            }
        }   
    }
    void OtoAta2()
    {
        EngelKarsilikli2.transform.position = EngelKarsilikli2.transform.position + new Vector3(85.0f, 0, 0);

        if (((Alt1.transform.localEulerAngles.z > 40.0f && Alt1.transform.localEulerAngles.z < 50.0f) && Alt1.transform.position.y > -5.0f && Alt1.transform.position.y <= 3.0f) && (Alt2.transform.localEulerAngles.z > 80.0f && Alt2.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt2 = Random.Range(-8.0f, -2.4f);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, FBRxAlt2, 1.8f);
        }

        if (((Ust1.transform.localEulerAngles.z > 40.0f && Ust1.transform.localEulerAngles.z < 50.0f) && Ust1.transform.position.y <= 20.0f) && (Ust2.transform.localEulerAngles.z > 80.0f && Ust2.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt2 = Random.Range(-8.0f, -2.4f);
            float FBRxUst2 = Random.Range(20.0f, 24.6f);
            Ust2.transform.position = new Vector3(Ust2.transform.position.x, FBRxUst2, 1.8f);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, FBRxAlt2, 1.8f);
        }

        if (((Ust1.transform.localEulerAngles.z > 80.0f && Ust1.transform.localEulerAngles.z < 100.0f) && Ust1.transform.position.y <= 20.0f) && (Alt2.transform.localEulerAngles.z > 80.0f && Alt2.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt2 = Random.Range(-8.0f, -2.4f);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, FBRxAlt2, 1.8f);
        }

        if (((Alt3.transform.localEulerAngles.z > 80.0f && Alt3.transform.localEulerAngles.z < 100.0f) && Alt3.transform.position.y > -5.0f && Alt3.transform.position.y <= 3.0f) && (Ust2.transform.localEulerAngles.z > 80.0f && Ust2.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxUst2 = Random.Range(20.0f, 24.6f);
            Ust2.transform.position = new Vector3(Ust2.transform.position.x, FBRxUst2, 1.8f);
        }

        if (((Alt2.transform.localEulerAngles.z > 80.0f && Alt2.transform.localEulerAngles.z < 100.0f) && Alt2.transform.position.y > -5.0f && Alt2.transform.position.y <= 3.0f) && (Ust3.transform.localEulerAngles.z > 80.0f && Ust3.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt2 = Random.Range(-8.0f, -2.4f);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, FBRxAlt2, 1.8f);
        }



        ///////////////////////////////
        if (KareIhtimalAlt2) {
         int KareMiUcgenMiAlt2 = Random.Range(1, 3);
           if (KareMiUcgenMiAlt2 == 1)
            {
                CisimKareAlt2 = true;
            }
           else if (KareMiUcgenMiAlt2 == 2)
            {
                CisimKareAlt2 = false;
            }
         if (CisimKareAlt2)
            {
                Alt2.transform.localScale = new Vector3(1, 0.65f, 1);
                Alt2.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
         else
            {
                Alt2.transform.localScale = new Vector3(1, 1, 1);
                Alt2.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }

        if (CisimKareAlt2)
        {
            RastGeleYukseklikAlt2 = Random.Range(0.0f, -7.1f);
            xYuks = -7.1f;
        }
        else
        {
            xYuks = -8.1f;
            RastGeleYukseklikAlt2 = Random.Range(-8.0f, -2.1f);
        }
if (KareIhtimalUst2)
        {
            int KareMiUcgenMiUst2 = Random.Range(1, 3);
            if (KareMiUcgenMiUst2 == 1)
            {
                CisimKareUst2 = true;
            }
            else if (KareMiUcgenMiUst2 == 2)
            {
                CisimKareUst2 = false;
            }
            if (CisimKareUst2)
            {
                Ust2.transform.localScale = new Vector3(1, 0.65f, 1);
                Ust2.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Ust2.transform.localScale = new Vector3(1, 1, 1);
                Ust2.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }
        if (CisimKareUst2)
        {
            RastGeleYukseklikUst2 = Random.Range(16.5f, 23.0f);
        }
        else
        {
            RastGeleYukseklikUst2 = Random.Range(19.5f, 25.9f);
        }

	 //////////////////////////// 

		// ALT 2 - UST 2 BASLANGIC
		if (Alt2.transform.rotation.z > -0.8f)
		{
                HideShowGolds[3].SetActive(false);
                HideShowGolds[11].SetActive(true);
		}
		else
		{
                HideShowGolds[3].SetActive(true);
                HideShowGolds[11].SetActive(false);
		}

		if (Ust2.transform.rotation.z > -0.8f)
		{
                HideShowGolds[2].SetActive(false);
                HideShowGolds[10].SetActive(true);
		}
		else
		{
                HideShowGolds[2].SetActive(true);
                HideShowGolds[10].SetActive(false);
		}
		// ALT 2 - UST 2 BITIS

     //////////////////////////

        RastgeleAlt2 = Random.Range(0, 2);
        RastgeleUst2 = Random.Range(0, 2);
        int RastgeleDbl = Random.Range(0, 2);

		// MONEY MONEY MONEY
		if (RastgeleAlt2 == 1 && RastgeleUst2 == 1) {
                HideShowGolds[3].SetActive(false);
                HideShowGolds[11].SetActive(false);
		}
        // MONEY MONEY MONEY


        // RANDOM COLOR APPLY :)
        if (OyuncuAyar.Skor <= 20)
        {
                ParaOn[4].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[5].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[6].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[7].GetComponent<Renderer>().material = GoldSilver[1];

                Kenarliklar[4].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[5].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[6].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[7].GetComponent<Renderer>().material = ParaKenarlik[1];

                ParaArka[4].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[5].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[6].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[7].GetComponent<Renderer>().material = GoldSilver[1];
        }
        else if (OyuncuAyar.Skor > 20)
        {
                ParaOn[4].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[5].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[6].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[7].GetComponent<Renderer>().material = GoldSilver[0];

                Kenarliklar[4].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[5].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[6].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[7].GetComponent<Renderer>().material = ParaKenarlik[0];

                ParaArka[4].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[5].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[6].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[7].GetComponent<Renderer>().material = GoldSilver[0];
        }
        // RANDOM COLOR APPLY :)

        // RANDOM MONEY SPAWN :)
        int RandomMoneyPoint2 = Random.Range(1, 3);
        if (RandomMoneyPoint2 == 1 || RandomMoneyPoint2 == 2)
        {
                HideShowGolds[2].SetActive(false);
                HideShowGolds[10].SetActive(false);
		}
		// RANDOM MONEY SPAWN :)

        if (RastgeleAlt2 == 1)
        {
            KareIhtimalAlt2 = true;
            KareIhtimalUst2 = true;
            Alt2.SetActive(true);
            Ust2.transform.position = new Vector3(Ust2.transform.position.x, 25.9f, 1.8f);
        }
        else
        {
            KareIhtimalAlt2 = true;
            KareIhtimalUst2 = true;
            Alt2.SetActive(false);
            Ust2.transform.position = new Vector3(Ust2.transform.position.x, RastGeleYukseklikUst2, 1.8f);
        }

        if (RastgeleUst2 == 1)
        {
            KareIhtimalAlt2 = true;
            KareIhtimalUst2 = true;
            Ust2.SetActive(true);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, xYuks, 1.8f);
        }
        else
        {
            KareIhtimalAlt2 = true;
            KareIhtimalUst2 = true;  
            Ust2.SetActive(false);
            Alt2.transform.position = new Vector3(Alt2.transform.position.x, RastGeleYukseklikAlt2, 1.8f);
        }

        if (RastgeleAlt2 == 0 && RastgeleUst2 == 0)
        {
            if (RastgeleDbl == 1) {

                KareIhtimalAlt2 = true;
                Alt2.SetActive(true);
                Ust2.SetActive(false);
            }
            else {
                KareIhtimalUst2 = true;
                Alt2.SetActive(false);
                Ust2.SetActive(true);
            }
        }
       

    }
    void OtoAta3()
    {

        EngelKarsilikli3.transform.position = EngelKarsilikli3.transform.position + new Vector3(85.0f, 0, 0);

        if (((Alt2.transform.localEulerAngles.z > 40.0f && Alt2.transform.localEulerAngles.z < 50.0f) && Alt2.transform.position.y > -5.0f && Alt2.transform.position.y <= 3.0f) && (Alt3.transform.localEulerAngles.z > 80.0f && Alt3.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt3 = Random.Range(-8.0f, -2.4f);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, FBRxAlt3, 1.8f);
        }
        if (((Ust2.transform.localEulerAngles.z > 40.0f && Ust2.transform.localEulerAngles.z < 50.0f) && Ust2.transform.position.y <= 20.0f) && (Ust3.transform.localEulerAngles.z > 80.0f && Ust3.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt3 = Random.Range(-8.0f, -2.4f);
            float FBRxUst3 = Random.Range(20.0f, 24.6f);
            Ust3.transform.position = new Vector3(Ust3.transform.position.x, FBRxUst3, 1.8f);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, FBRxAlt3, 1.8f);
        }
        if (((Ust2.transform.localEulerAngles.z > 80.0f && Ust2.transform.localEulerAngles.z < 100.0f) && Ust2.transform.position.y <= 20.0f) && (Alt3.transform.localEulerAngles.z > 80.0f && Alt3.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt3 = Random.Range(-8.0f, -2.4f);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, FBRxAlt3, 1.8f);
        }
        if (((Alt4.transform.localEulerAngles.z > 80.0f && Alt4.transform.localEulerAngles.z < 100.0f) && Alt4.transform.position.y > -5.0f && Alt4.transform.position.y <= 3.0f) && (Ust3.transform.localEulerAngles.z > 80.0f && Ust3.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxUst3 = Random.Range(20.0f, 24.6f);
            Ust3.transform.position = new Vector3(Ust3.transform.position.x, FBRxUst3, 1.8f);
        }
        if (((Alt3.transform.localEulerAngles.z > 80.0f && Alt3.transform.localEulerAngles.z < 100.0f) && Alt3.transform.position.y > -5.0f && Alt3.transform.position.y <= 3.0f) && (Ust4.transform.localEulerAngles.z > 80.0f && Ust4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt3 = Random.Range(-8.0f, -2.4f);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, FBRxAlt3, 1.8f);
        }

        ///////////////////////////////
        if (KareIhtimalAlt3)
        {
            int KareMiUcgenMiAlt3 = Random.Range(1, 3);
            if (KareMiUcgenMiAlt3 == 1)
            {
                CisimKareAlt3 = true;
            }
            else if (KareMiUcgenMiAlt3 == 2)
            {
                CisimKareAlt3 = false;
            }
            if (CisimKareAlt3)
            {
                Alt3.transform.localScale = new Vector3(1, 0.65f, 1);
                Alt3.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Alt3.transform.localScale = new Vector3(1, 1, 1);
                Alt3.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }

        if (CisimKareAlt3)
        {
            xYuks = -7.1f;
            RastGeleYukseklikAlt3 = Random.Range(0.0f, -7.1f);
        }
        else
        {
            xYuks = -8.1f;
            RastGeleYukseklikAlt3 = Random.Range(-8.0f, -2.1f);
        }
        if (KareIhtimalUst3)
        {
            int KareMiUcgenMiUst3 = Random.Range(1, 3);
            if (KareMiUcgenMiUst3 == 1)
            {
                CisimKareUst3 = true;
            }
            else if (KareMiUcgenMiUst3 == 2)
            {
                CisimKareUst3 = false;
            }
            if (CisimKareUst3)
            {
                Ust3.transform.localScale = new Vector3(1, 0.65f, 1);
                Ust3.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Ust3.transform.localScale = new Vector3(1,  1, 1);
                Ust3.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }
        if (CisimKareUst3)
        {
            RastGeleYukseklikUst3 = Random.Range(16.5f, 23.0f);
        }
        else
        {
            RastGeleYukseklikUst3 = Random.Range(19.5f, 25.9f);
        }
        //////////////////////////

        // ALT 3 - UST 3 BASLANGIC
        if (Alt3.transform.rotation.z > -0.8f)
        {
                HideShowGolds[5].SetActive(false);
                HideShowGolds[13].SetActive(true);
        }
        else
        {
                HideShowGolds[5].SetActive(true);
                HideShowGolds[13].SetActive(false);
        }

		if (Ust3.transform.rotation.z > -0.8f)
		{
                HideShowGolds[4].SetActive(false);
                HideShowGolds[12].SetActive(true);
		}
		else
		{
                HideShowGolds[4].SetActive(true);
                HideShowGolds[12].SetActive(false);
		}
		// ALT 3 - UST 3 BITIS

		//////////////////////////
        RastgeleAlt3 = Random.Range(0, 2);
        RastgeleUst3 = Random.Range(0, 2);
        int RastgeleDbl3 = Random.Range(0, 2);

		// MONEY MONEY MONEY
		if (RastgeleAlt3 == 1 && RastgeleUst3 == 1) {
                HideShowGolds[5].SetActive(false);
                HideShowGolds[13].SetActive(false);
		}
        // MONEY MONEY MONEY

        // RANDOM COLOR APPLY :)

        if (OyuncuAyar.Skor <= 20)
        {
                ParaOn[8].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[9].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[10].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[11].GetComponent<Renderer>().material = GoldSilver[1];

                Kenarliklar[8].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[9].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[10].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[11].GetComponent<Renderer>().material = ParaKenarlik[1];

                ParaArka[8].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[9].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[10].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[11].GetComponent<Renderer>().material = GoldSilver[1];
            }
        else if (OyuncuAyar.Skor > 20)
        {
                ParaOn[8].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[9].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[10].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[11].GetComponent<Renderer>().material = GoldSilver[0];

                Kenarliklar[8].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[9].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[10].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[11].GetComponent<Renderer>().material = ParaKenarlik[0];

                ParaArka[8].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[9].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[10].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[11].GetComponent<Renderer>().material = GoldSilver[0];
        }
        // RANDOM COLOR APPLY :)

        // RANDOM MONEY SPAWN :)
        int RandomMoneyPoint3 = Random.Range(1, 3);
        if (RandomMoneyPoint3 == 1 || RandomMoneyPoint3 == 2)
        {
                HideShowGolds[4].SetActive(false);
                HideShowGolds[12].SetActive(false);
		}
		// RANDOM MONEY SPAWN :)

        if (RastgeleAlt3 == 1)
        {
            KareIhtimalAlt3 = true;
            KareIhtimalUst3 = true;
            Alt3.SetActive(true);
            Ust3.transform.position = new Vector3(Ust3.transform.position.x, 25.9f, 1.8f);
        }
        else
        {
            KareIhtimalAlt3 = true;
            KareIhtimalUst3 = true;
            Alt3.SetActive(false);
            Ust3.transform.position = new Vector3(Ust3.transform.position.x, RastGeleYukseklikUst3, 1.8f);
        }

        if (RastgeleUst3 == 1)
        {
            KareIhtimalAlt3 = true;
            KareIhtimalUst3 = true;
            Ust3.SetActive(true);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, xYuks, 1.8f);
        }
        else
        {
            KareIhtimalAlt3 = true;
            KareIhtimalUst3 = true;
            Ust3.SetActive(false);
            Alt3.transform.position = new Vector3(Alt3.transform.position.x, RastGeleYukseklikAlt3, 1.8f);
        }
      
        if (RastgeleAlt3 == 0 && RastgeleUst3 == 0)
        {
            if (RastgeleDbl3 == 1)
            {
                KareIhtimalAlt3 = true;
                Alt3.SetActive(true);
                Ust3.SetActive(false);
            }
            else
            {
                KareIhtimalUst3 = true;
                Alt3.SetActive(false);
                Ust3.SetActive(true);
            }
        }
       
    }
    void OtoAta4()
    {
        EngelKarsilikli4.transform.position = EngelKarsilikli4.transform.position + new Vector3(85.0f, 0, 0);

        if (((Alt3.transform.localEulerAngles.z > 40.0f && Alt3.transform.localEulerAngles.z < 50.0f) && Alt3.transform.position.y > -5.0f && Alt3.transform.position.y <= 3.0f) && (Alt4.transform.localEulerAngles.z > 80.0f && Alt4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt4 = Random.Range(-8.0f, -2.4f);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, FBRxAlt4, 1.8f);
        }
        if (((Ust3.transform.localEulerAngles.z > 40.0f && Ust3.transform.localEulerAngles.z < 50.0f) && Ust3.transform.position.y <= 20.0f) && (Ust4.transform.localEulerAngles.z > 80.0f && Ust4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt4 = Random.Range(-8.0f, -2.4f);
            float FBRxUst4 = Random.Range(20.0f, 24.6f);
            Ust4.transform.position = new Vector3(Ust4.transform.position.x, FBRxUst4, 1.8f);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, FBRxAlt4, 1.8f);
        }
        if (((Ust3.transform.localEulerAngles.z > 80.0f && Ust3.transform.localEulerAngles.z < 100.0f) && Ust3.transform.position.y <= 20.0f) && (Alt4.transform.localEulerAngles.z > 80.0f && Alt4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt4 = Random.Range(-8.0f, -2.4f);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, FBRxAlt4, 1.8f);
        }
        if (((Alt1.transform.localEulerAngles.z > 80.0f && Alt1.transform.localEulerAngles.z < 100.0f) && Alt1.transform.position.y > -5.0f && Alt1.transform.position.y <= 3.0f) && (Ust4.transform.localEulerAngles.z > 80.0f && Ust4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxUst4 = Random.Range(20.0f, 24.6f);
            Ust4.transform.position = new Vector3(Ust4.transform.position.x, FBRxUst4, 1.8f);
        }
        if (((Ust1.transform.localEulerAngles.z > 80.0f && Ust1.transform.localEulerAngles.z < 100.0f) && Ust1.transform.position.y <= 20.0f) && (Alt4.transform.localEulerAngles.z > 80.0f && Alt4.transform.localEulerAngles.z < 100.0f))
        {
            float FBRxAlt4 = Random.Range(-8.0f, -2.4f);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, FBRxAlt4, 1.8f);
        }

        ///////////////////////////////
        if (KareIhtimalAlt4)
        {
            int KareMiUcgenMiAlt4 = Random.Range(1, 3);
            if (KareMiUcgenMiAlt4 == 1)
            {
                CisimKareAlt4 = true;
            }
            else if (KareMiUcgenMiAlt4 == 2)
            {
                CisimKareAlt4 = false;
            }
            if (CisimKareAlt4)
            {
                Alt4.transform.localScale = new Vector3(1, 0.65f, 1);
                Alt4.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Alt4.transform.localScale = new Vector3(1, 1, 1);
                Alt4.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }

        if (CisimKareAlt4)
        {
            xYuks = -7.1f;
            RastGeleYukseklikAlt4 = Random.Range(0.0f, -7.1f);
        }
        else
        {
            xYuks = -8.1f;
            RastGeleYukseklikAlt4 = Random.Range(-8.0f, -2.1f);
        }
        if (KareIhtimalUst4)
        {
            int KareMiUcgenMiUst4 = Random.Range(1, 3);
            if (KareMiUcgenMiUst4 == 1)
            {
                CisimKareUst4 = true;
            }
            else if (KareMiUcgenMiUst4 == 2)
            {
                CisimKareUst4 = false;
            }
            if (CisimKareUst4)
            {
                Ust4.transform.localScale = new Vector3(1, 0.65f, 1);
                Ust4.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 90);
            }
            else
            {
                Ust4.transform.localScale = new Vector3(1, 1, 1);
                Ust4.transform.localEulerAngles = new Vector3(0.0f, 180.0f, 45.0f);
            }
        }
        if (CisimKareUst4)
        {
            RastGeleYukseklikUst4 = Random.Range(16.5f, 23.0f);
        }
        else
        {
            RastGeleYukseklikUst4 = Random.Range(19.5f, 25.9f);
        }
        //////////////////////////

		// ALT 4 - UST 4 BASLANGIC
		if (Alt4.transform.rotation.z > -0.8f)
		{
                HideShowGolds[7].SetActive(false);
                HideShowGolds[15].SetActive(true);
		}
		else
		{
                HideShowGolds[7].SetActive(true);
                HideShowGolds[15].SetActive(false);
            }

		if (Ust4.transform.rotation.z > -0.8f)
		{
                HideShowGolds[6].SetActive(false);
                HideShowGolds[14].SetActive(true);
		}
		else
		{
                HideShowGolds[6].SetActive(true);
                HideShowGolds[14].SetActive(false);
		}
		// ALT 4 - UST 4 BITIS

		//////////////////////////
        RastgeleAlt4 = Random.Range(0, 2);
        RastgeleUst4 = Random.Range(0, 2);
        int RastgeleDbl4 = Random.Range(0, 2);

		// MONEY MONEY MONEY
		if (RastgeleAlt4 == 1 && RastgeleUst4 == 1) {
                HideShowGolds[7].SetActive(false);
                HideShowGolds[15].SetActive(false);
		}
        // MONEY MONEY MONEY

        // RANDOM COLOR APPLY :)

        if (OyuncuAyar.Skor <= 20)
        {
                ParaOn[12].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[13].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[14].GetComponent<Renderer>().material = GoldSilver[1];
                ParaOn[15].GetComponent<Renderer>().material = GoldSilver[1];

                Kenarliklar[12].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[13].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[14].GetComponent<Renderer>().material = ParaKenarlik[1];
                Kenarliklar[15].GetComponent<Renderer>().material = ParaKenarlik[1];

                ParaArka[12].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[13].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[14].GetComponent<Renderer>().material = GoldSilver[1];
                ParaArka[15].GetComponent<Renderer>().material = GoldSilver[1];
        }
        else if (OyuncuAyar.Skor > 20)
        {
                ParaOn[12].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[13].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[14].GetComponent<Renderer>().material = GoldSilver[0];
                ParaOn[15].GetComponent<Renderer>().material = GoldSilver[0];

                Kenarliklar[12].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[13].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[14].GetComponent<Renderer>().material = ParaKenarlik[0];
                Kenarliklar[15].GetComponent<Renderer>().material = ParaKenarlik[0];

                ParaArka[12].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[13].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[14].GetComponent<Renderer>().material = GoldSilver[0];
                ParaArka[15].GetComponent<Renderer>().material = GoldSilver[0];
         }
        // RANDOM COLOR APPLY :)

        // RANDOM MONEY SPAWN :)
        int RandomMoneyPoint4 = Random.Range(1, 3);
        if (RandomMoneyPoint4 == 1 || RandomMoneyPoint4 == 2)
        {
                HideShowGolds[6].SetActive(false);
                HideShowGolds[14].SetActive(false);
		}
		// RANDOM MONEY SPAWN :)

        if (RastgeleAlt4 == 1)
        {
            KareIhtimalAlt4 = true;
            KareIhtimalUst4 = true;
            Alt4.SetActive(true);
            Ust4.transform.position = new Vector3(Ust4.transform.position.x, 25.9f, 1.8f);
        }
        else
        {
            KareIhtimalAlt4 = true;
            KareIhtimalUst4 = true;
            Alt4.SetActive(false);
            Ust4.transform.position = new Vector3(Ust4.transform.position.x, RastGeleYukseklikUst4, 1.8f);
        }

        if (RastgeleUst4 == 1)
        {
            KareIhtimalAlt4 = true;
            KareIhtimalUst4 = true;
            Ust4.SetActive(true);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, xYuks, 1.8f);
        }
        else
        {
            KareIhtimalAlt4 = true;
            KareIhtimalUst4 = true;
            Ust4.SetActive(false);
            Alt4.transform.position = new Vector3(Alt4.transform.position.x, RastGeleYukseklikAlt4, 1.8f);
        }

        if (RastgeleAlt4 == 0 && RastgeleUst4 == 0)
        {
            if (RastgeleDbl4 == 1)
            {
                KareIhtimalAlt4 = true;
                Alt4.SetActive(true);
                Ust4.SetActive(false);
            }
            else
            {
                KareIhtimalUst4 = true;
                Alt4.SetActive(false);
                Ust4.SetActive(true);
            }
        }
       
    }

}