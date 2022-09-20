using UnityEngine;
using System.Collections;

public class Engel_DonenSilindir : MonoBehaviour {

    public GameObject Silver, Gold;

    public Material[] Kaplamalar;
    public GameObject OnYuzu;

    public bool TemasOlayi;
    public static bool EngelDonenSilindirBitisi;
    public Transform helikopter;
    public Transform EngelTumu;
    public GameObject Engel;

    float HizDegeri;
    float EngelHareketHizi;
    int BuyuklukDegeri;


    bool YukariSpawn;
    void Start () {
        YukariSpawn = false;
        TemasOlayi = false;
        EngelDonenSilindirBitisi = false;
        EngelHareketHizi = -0.05f;
        HizDegeri = 1.25f;

        int SpawnParaBaslangic = Random.Range(0, 2); // %50 ihtimal
        int GoldSilverGoldOranBaslangic = Random.Range(0, 3);
        if (SpawnParaBaslangic == 0)
        {
            if (GoldSilverGoldOranBaslangic == 0)
            {
                Gold.SetActive(true);
                Silver.SetActive(false);
            }
            else
            {
                Gold.SetActive(false);
                Silver.SetActive(true);
            }
        }
        else
        {
            Gold.SetActive(false);
            Silver.SetActive(false);
        }
    }
	
  void Update () {
        
    if (TemasOlayi) { 
        if (EngelDonenSilindirBitisi == false)
        {
            Invoke("OtoAta", 0.0f);
            TemasOlayi = false;
        }
        else
        {

        }
        }

        // 20 PUANA GELINCE DONME VE HAREKETE BASLA
        if (helikopter.transform.position.x >= 2570) { 
            if (OyuncuAyar.DurdurmaMenusu || OyuncuAyar.OyunBitti) {
                Engel.transform.Rotate(0, 0, 0);
                EngelTumu.transform.position = EngelTumu.transform.position + new Vector3(0, 0, 0);
         }
            else
            {
                Engel.transform.Rotate(0, HizDegeri, 0);
                EngelTumu.transform.position = EngelTumu.transform.position + new Vector3(EngelHareketHizi, 0, 0);
            }
        }
        else
        {
            Engel.transform.Rotate(0, 0, 0);
            EngelTumu.transform.position = EngelTumu.transform.position + new Vector3(0, 0, 0);
        }

        ////
        if (!YukariSpawn)
        {
            if (Engel.transform.localScale.x == 12 && Engel.transform.localScale.z == 12)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 5.25f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 11 && Engel.transform.localScale.z == 11)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 4.75f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 10 && Engel.transform.localScale.z == 10)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 4.25f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 9 && Engel.transform.localScale.z == 9)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 3.75f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 8 && Engel.transform.localScale.z == 8)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 3.25f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 7 && Engel.transform.localScale.z == 7)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 2.75f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 6 && Engel.transform.localScale.z == 6)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 2.25f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 5 && Engel.transform.localScale.z == 5)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 1.75f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 4 && Engel.transform.localScale.z == 4)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 1.26f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 3 && Engel.transform.localScale.z == 3)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 0.77f, Engel.transform.position.z);
            }
        }
        else
        {
            if (Engel.transform.localScale.x == 12 && Engel.transform.localScale.z == 12)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 11.98f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 11 && Engel.transform.localScale.z == 11)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 12.47f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 10 && Engel.transform.localScale.z == 10)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 12.96f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 9 && Engel.transform.localScale.z == 9)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 13.46f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 8 && Engel.transform.localScale.z == 8)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 13.96f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 7 && Engel.transform.localScale.z == 7)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 14.46f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 6 && Engel.transform.localScale.z == 6)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 14.96f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 5 && Engel.transform.localScale.z == 5)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 15.46f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 4 && Engel.transform.localScale.z == 4)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 15.96f, Engel.transform.position.z);
            }
            else if (Engel.transform.localScale.x == 3 && Engel.transform.localScale.z == 3)
            {
                Engel.transform.position = new Vector3(Engel.transform.position.x, 16.46f, Engel.transform.position.z);
            }
        }

    }
    void OtoAta()
    {
        EngelTumu.transform.position = EngelTumu.transform.position + new Vector3(120.0f, 0, 0);

           int RastgeleMateryal = Random.Range(0,5);
          OnYuzu.GetComponent<Renderer>().material = Kaplamalar[RastgeleMateryal];

        int AsagiYukariSpawn = Random.Range(0,2);
        if (AsagiYukariSpawn == 0)
        {
            YukariSpawn = true;
        }
        else
        {
            YukariSpawn = false;
        }

        BuyuklukDegeri = Random.Range(5,13);
        Engel.transform.localScale = new Vector3(BuyuklukDegeri, 3.6f, BuyuklukDegeri);

        if (BuyuklukDegeri == 5)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 8.3f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 8.3f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 6)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 8.6f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 8.6f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 7)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 9.0f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 9.0f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 8)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 9.5f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 9.5f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 9)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 10.0f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 10.0f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 10)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 11.5f ,Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 11.5f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 11)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 12.5f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 12.5f, Gold.transform.position.z);
        }
        else if (BuyuklukDegeri == 12)
        {
            Gold.transform.position = new Vector3(Gold.transform.position.x, 13.5f, Gold.transform.position.z);
            Silver.transform.position = new Vector3(Gold.transform.position.x, 13.5f, Gold.transform.position.z);
        }

        if (!YukariSpawn) {
        int SpawnPara = Random.Range(0, 3); // %50 ihtimal
        int GoldSilverGoldOran = Random.Range(0, 3);
        if (SpawnPara == 0 || SpawnPara == 1)
        {
            if (GoldSilverGoldOran == 0)
            {
                Gold.SetActive(true);
                Silver.SetActive(false);
            }
            else
            {
                Gold.SetActive(false);
                Silver.SetActive(true);
            }
        }
        else
        {
            Gold.SetActive(false);
            Silver.SetActive(false);
        }
        }
        else
        {
            Gold.SetActive(false);
            Silver.SetActive(false);
        }
    }
}
