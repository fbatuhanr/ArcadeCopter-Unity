using UnityEngine;
using System.Collections;

public class SonsuzModRandomObje : MonoBehaviour
{
    public GameObject BoslukluGold1, BoslukluSilver1;
    public GameObject BoslukluGold2, BoslukluSilver2;
    public GameObject BoslukluGold3, BoslukluSilver3;

    public GameObject Bosluklu1_Alt, Bosluklu1_Ust;
    public GameObject Bosluklu2_Alt, Bosluklu2_Ust;
    public GameObject Bosluklu3_Alt, Bosluklu3_Ust;

    public GameObject DuzGold1, DuzSilver1;
    public GameObject DuzGold2, DuzSilver2;
    public GameObject DuzGold3, DuzSilver3;
    public GameObject DuzGold4, DuzSilver4;
    public GameObject DuzGold5, DuzSilver5;
    public GameObject DuzGold6, DuzSilver6;
    public GameObject DuzGold7, DuzSilver7;
    public GameObject DuzGold8, DuzSilver8;

    public GameObject KareGold1, KareSilver1;
    public GameObject KareGold2, KareSilver2;
    public GameObject KareGold3, KareSilver3;
    public GameObject KareGold4, KareSilver4;
    public GameObject KareGold5, KareSilver5;
    public GameObject KareGold6, KareSilver6;
    public GameObject KareGold7, KareSilver7;
    public GameObject KareGold8, KareSilver8;
    public GameObject KareGold9, KareSilver9;
    public GameObject KareGold10, KareSilver10;

    public GameObject DaireGold1, DaireSilver1;
    public GameObject DaireGold2, DaireSilver2;

    public GameObject Bosluklu1, Bosluklu2, Bosluklu3;
    public GameObject KarsilikEng1, KarsilikEng2, KarsilikEng3, KarsilikEng4;
    public GameObject Duz1, Duz2, Duz3, Duz4, Duz5, Duz6, Duz7, Duz8;
    public GameObject Kare1, Kare2, Kare3, Kare4, Kare5, Kare6, Kare7, Kare8, Kare9, Kare10;
    public GameObject Daire1, Daire2;

   public static bool IleriyeAta;

    void Start () {
        IleriyeAta = false;

        int RandomEngelBaslangic = Random.Range(0, 27);
        if (RandomEngelBaslangic == 0)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(true);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 1)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(true);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 2)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(true);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 3)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(true);
            int Duz1RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Duz1RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawnBaslangic == 0)
                {
                    DuzGold1.SetActive(true);
                    DuzSilver1.SetActive(false);
                }
                else
                {
                    DuzGold1.SetActive(false);
                    DuzSilver1.SetActive(true);
                }
            }
            else
            {
                DuzGold1.SetActive(false);
                DuzSilver1.SetActive(false);
            }


            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 4)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);

            Duz2.SetActive(true);
            int Duz2RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn2Baslangic = Random.Range(0, 3);
            if (Duz2RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn2Baslangic == 0)
                {
                    DuzGold2.SetActive(true);
                    DuzSilver2.SetActive(false);
                }
                else
                {
                    DuzGold2.SetActive(false);
                    DuzSilver2.SetActive(true);
                }
            }
            else
            {
                DuzGold2.SetActive(false);
                DuzSilver2.SetActive(false);
            }

            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 5)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);

            Duz3.SetActive(true);
            int Duz3RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn3Baslangic = Random.Range(0, 3);
            if (Duz3RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn3Baslangic == 0)
                {
                    DuzGold2.SetActive(true);
                    DuzSilver2.SetActive(false);
                }
                else
                {
                    DuzGold3.SetActive(false);
                    DuzSilver3.SetActive(true);
                }
            }
            else
            {
                DuzGold3.SetActive(false);
                DuzSilver3.SetActive(false);
            }

            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 6)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);

            Duz4.SetActive(true);
            int Duz4RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn4Baslangic = Random.Range(0, 3);
            if (Duz4RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn4Baslangic == 0)
                {
                    DuzGold4.SetActive(true);
                    DuzSilver4.SetActive(false);
                }
                else
                {
                    DuzGold4.SetActive(false);
                    DuzSilver4.SetActive(true);
                }
            }
            else
            {
                DuzGold4.SetActive(false);
                DuzSilver4.SetActive(false);
            }

            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 7)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);

            Duz5.SetActive(true);
            int Duz5RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn5Baslangic = Random.Range(0, 3);
            if (Duz5RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn5Baslangic == 0)
                {
                    DuzGold5.SetActive(true);
                    DuzSilver5.SetActive(false);
                }
                else
                {
                    DuzGold5.SetActive(false);
                    DuzSilver5.SetActive(true);
                }
            }
            else
            {
                DuzGold5.SetActive(false);
                DuzSilver5.SetActive(false);
            }

            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 8)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);

            Duz6.SetActive(true);
            int Duz6RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn6Baslangic = Random.Range(0, 3);
            if (Duz6RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn6Baslangic == 0)
                {
                    DuzGold6.SetActive(true);
                    DuzSilver6.SetActive(false);
                }
                else
                {
                    DuzGold6.SetActive(false);
                    DuzSilver6.SetActive(true);
                }
            }
            else
            {
                DuzGold6.SetActive(false);
                DuzSilver6.SetActive(false);
            }

            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 9)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);

            Duz7.SetActive(true);
            int Duz7RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn7Baslangic = Random.Range(0, 3);
            if (Duz7RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn7Baslangic == 0)
                {
                    DuzGold7.SetActive(true);
                    DuzSilver7.SetActive(false);
                }
                else
                {
                    DuzGold7.SetActive(false);
                    DuzSilver7.SetActive(true);
                }
            }
            else
            {
                DuzGold7.SetActive(false);
                DuzSilver7.SetActive(false);
            }

            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 10)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);

            Duz8.SetActive(true);
            int Duz8RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int GoldSilverGoldSpawn8Baslangic = Random.Range(0, 3);
            if (Duz8RandomGoldSpawnBaslangic == 0)
            {
                if (GoldSilverGoldSpawn8Baslangic == 0)
                {
                    DuzGold8.SetActive(true);
                    DuzSilver8.SetActive(false);
                }
                else
                {
                    DuzGold8.SetActive(false);
                    DuzSilver8.SetActive(true);
                }
            }
            else
            {
                DuzGold8.SetActive(false);
                DuzSilver8.SetActive(false);
            }

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 11)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(true);
            int Kare1RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare1GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare1RandomGoldSpawnBaslangic == 0)
            {
                if (Kare1GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold1.SetActive(true);
                    KareSilver1.SetActive(false);
                }
                else
                {
                    KareGold1.SetActive(false);
                    KareSilver1.SetActive(true);
                }
            }
            else
            {
                KareGold1.SetActive(false);
                KareSilver1.SetActive(false);
            }

            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 12)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);

            Kare2.SetActive(true);
            int Kare2RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare2GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare2RandomGoldSpawnBaslangic == 0)
            {
                if (Kare2GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold2.SetActive(true);
                    KareSilver2.SetActive(false);
                }
                else
                {
                    KareGold2.SetActive(false);
                    KareSilver2.SetActive(true);
                }
            }
            else
            {
                KareGold2.SetActive(false);
                KareSilver2.SetActive(false);
            }

            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 13)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);

            Kare3.SetActive(true);
            int Kare3RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare3GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare3RandomGoldSpawnBaslangic == 0)
            {
                if (Kare3GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold3.SetActive(true);
                    KareSilver3.SetActive(false);
                }
                else
                {
                    KareGold3.SetActive(false);
                    KareSilver3.SetActive(true);
                }
            }
            else
            {
                KareGold3.SetActive(false);
                KareSilver3.SetActive(false);
            }

            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 14)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);

            Kare4.SetActive(true);
            int Kare4RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare4GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare4RandomGoldSpawnBaslangic == 0)
            {
                if (Kare4GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold4.SetActive(true);
                    KareSilver4.SetActive(false);
                }
                else
                {
                    KareGold4.SetActive(false);
                    KareSilver4.SetActive(true);
                }
            }
            else
            {
                KareGold4.SetActive(false);
                KareSilver4.SetActive(false);
            }

            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 15)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);

            Kare5.SetActive(true);
            int Kare5RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare5GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare5RandomGoldSpawnBaslangic == 0)
            {
                if (Kare5GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold5.SetActive(true);
                    KareSilver5.SetActive(false);
                }
                else
                {
                    KareGold5.SetActive(false);
                    KareSilver5.SetActive(true);
                }
            }
            else
            {
                KareGold5.SetActive(false);
                KareSilver5.SetActive(false);
            }

            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 16)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);

            Kare6.SetActive(true);
            int Kare6RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare6GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare6RandomGoldSpawnBaslangic == 0)
            {
                if (Kare6GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold6.SetActive(true);
                    KareSilver6.SetActive(false);
                }
                else
                {
                    KareGold6.SetActive(false);
                    KareSilver6.SetActive(true);
                }
            }
            else
            {
                KareGold6.SetActive(false);
                KareSilver6.SetActive(false);
            }

            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 17)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);

            Kare7.SetActive(true);
            int Kare7RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare7GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare7RandomGoldSpawnBaslangic == 0)
            {
                if (Kare7GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold7.SetActive(true);
                    KareSilver7.SetActive(false);
                }
                else
                {
                    KareGold7.SetActive(false);
                    KareSilver7.SetActive(true);
                }
            }
            else
            {
                KareGold7.SetActive(false);
                KareSilver7.SetActive(false);
            }

            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 18)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);

            Kare8.SetActive(true);
            int Kare8RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare8GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare8RandomGoldSpawnBaslangic == 0)
            {
                if (Kare8GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold8.SetActive(true);
                    KareSilver8.SetActive(false);
                }
                else
                {
                    KareGold8.SetActive(false);
                    KareSilver8.SetActive(true);
                }
            }
            else
            {
                KareGold8.SetActive(false);
                KareSilver8.SetActive(false);
            }

            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 19)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);

            Kare9.SetActive(true);
            int Kare9RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare9GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare9RandomGoldSpawnBaslangic == 0)
            {
                if (Kare9GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold9.SetActive(true);
                    KareSilver9.SetActive(false);
                }
                else
                {
                    KareGold9.SetActive(false);
                    KareSilver9.SetActive(true);
                }
            }
            else
            {
                KareGold9.SetActive(false);
                KareSilver9.SetActive(false);
            }

            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 20)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);

            Kare10.SetActive(true);
            int Kare10RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Kare10GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Kare10RandomGoldSpawnBaslangic == 0)
            {
                if (Kare10GoldSilverGoldSpawnBaslangic == 0)
                {
                    KareGold10.SetActive(true);
                    KareSilver10.SetActive(false);
                }
                else
                {
                    KareGold10.SetActive(false);
                    KareSilver10.SetActive(true);
                }
            }
            else
            {
                KareGold10.SetActive(false);
                KareSilver10.SetActive(false);
            }

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 21)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(true);
            int Daire1RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Daire1GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Daire1RandomGoldSpawnBaslangic == 0)
            {
                if (Daire1GoldSilverGoldSpawnBaslangic == 0)
                {
                    DaireGold1.SetActive(true);
                    DaireSilver1.SetActive(false);
                }
                else
                {
                    DaireGold1.SetActive(false);
                    DaireSilver1.SetActive(true);
                }
            }
            else
            {
                DaireGold1.SetActive(false);
                DaireSilver1.SetActive(false);
            }

            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 22)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);

            Daire2.SetActive(true);
            int Daire2RandomGoldSpawnBaslangic = Random.Range(0, 3);
            int Daire2GoldSilverGoldSpawnBaslangic = Random.Range(0, 3);
            if (Daire2RandomGoldSpawnBaslangic == 0)
            {
                if (Daire2GoldSilverGoldSpawnBaslangic == 0)
                {
                    DaireGold2.SetActive(true);
                    DaireSilver2.SetActive(false);
                }
                else
                {
                    DaireGold2.SetActive(false);
                    DaireSilver2.SetActive(true);
                }
            }
            else
            {
                DaireGold2.SetActive(false);
                DaireSilver2.SetActive(false);
            }

        }
        else if (RandomEngelBaslangic == 23)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(true);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 24)
        {
            Bosluklu1.SetActive(true);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 25)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(true);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngelBaslangic == 26)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(true);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
    }
	
	void Update () {

        if (IleriyeAta)
        {
            Invoke("OnuneAta", 0);
            IleriyeAta = false;
        }
	
	}

    void OnuneAta()
    {
        Bosluklu1.transform.position = KarsilikEng1.transform.position + new Vector3(100, 0, 0);
        Bosluklu2.transform.position = KarsilikEng1.transform.position + new Vector3(100, 0, 0);
        Bosluklu3.transform.position = KarsilikEng1.transform.position + new Vector3(100, 0, 0);

        KarsilikEng1.transform.position = KarsilikEng1.transform.position + new Vector3(100, 0, 0);
        KarsilikEng2.transform.position = KarsilikEng2.transform.position + new Vector3(100, 0, 0);
        KarsilikEng3.transform.position = KarsilikEng3.transform.position + new Vector3(100, 0, 0);
        KarsilikEng4.transform.position = KarsilikEng4.transform.position + new Vector3(100, 0, 0);

        Duz1.transform.position = Duz1.transform.position + new Vector3(100, 0, 0);
        Duz2.transform.position = Duz2.transform.position + new Vector3(100, 0, 0);
        Duz3.transform.position = Duz3.transform.position + new Vector3(100, 0, 0);
        Duz4.transform.position = Duz4.transform.position + new Vector3(100, 0, 0);
        Duz5.transform.position = Duz5.transform.position + new Vector3(100, 0, 0);
        Duz6.transform.position = Duz6.transform.position + new Vector3(100, 0, 0);
        Duz7.transform.position = Duz7.transform.position + new Vector3(100, 0, 0);
        Duz8.transform.position = Duz8.transform.position + new Vector3(100, 0, 0);

        Kare1.transform.position = Kare1.transform.position + new Vector3(100, 0, 0);
        Kare2.transform.position = Kare2.transform.position + new Vector3(100, 0, 0);
        Kare3.transform.position = Kare3.transform.position + new Vector3(100, 0, 0);
        Kare4.transform.position = Kare4.transform.position + new Vector3(100, 0, 0);
        Kare5.transform.position = Kare5.transform.position + new Vector3(100, 0, 0);
        Kare6.transform.position = Kare6.transform.position + new Vector3(100, 0, 0);
        Kare7.transform.position = Kare7.transform.position + new Vector3(100, 0, 0);
        Kare8.transform.position = Kare8.transform.position + new Vector3(100, 0, 0);
        Kare9.transform.position = Kare9.transform.position + new Vector3(100, 0, 0);
        Kare10.transform.position = Kare10.transform.position + new Vector3(100, 0, 0);

        Daire1.transform.position = Daire1.transform.position + new Vector3(100, 0, 0);
        Daire2.transform.position = Daire2.transform.position + new Vector3(100, 0, 0);

        int RandomEngel = Random.Range(0, 27);
        if (RandomEngel == 0)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(true);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 1)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(true);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 2)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(true);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 3)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(true);
            int Duz1RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Duz1RandomGoldSpawn == 0 || Duz1RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn == 0)
                {
                    DuzGold1.SetActive(true);
                    DuzSilver1.SetActive(false);
                }
                else
                {
                    DuzGold1.SetActive(false);
                    DuzSilver1.SetActive(true);
                }
            }
            else
            {
                DuzGold1.SetActive(false);
                DuzSilver1.SetActive(false);
            }


            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 4)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);

            Duz2.SetActive(true);
            int Duz2RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn2 = Random.Range(0, 3);
            if (Duz2RandomGoldSpawn == 0 || Duz2RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn2 == 0)
                {
                    DuzGold2.SetActive(true);
                    DuzSilver2.SetActive(false);
                }
                else
                {
                    DuzGold2.SetActive(false);
                    DuzSilver2.SetActive(true);
                }
            }
            else
            {
                DuzGold2.SetActive(false);
                DuzSilver2.SetActive(false);
            }

            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 5)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);

            Duz3.SetActive(true);
            int Duz3RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn3 = Random.Range(0, 3);
            if (Duz3RandomGoldSpawn == 0 || Duz3RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn3 == 0)
                {
                    DuzGold2.SetActive(true);
                    DuzSilver2.SetActive(false);
                }
                else
                {
                    DuzGold3.SetActive(false);
                    DuzSilver3.SetActive(true);
                }
            }
            else
            {
                DuzGold3.SetActive(false);
                DuzSilver3.SetActive(false);
            }

            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 6)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);

            Duz4.SetActive(true);
            int Duz4RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn4 = Random.Range(0, 3);
            if (Duz4RandomGoldSpawn == 0 || Duz4RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn4 == 0)
                {
                    DuzGold4.SetActive(true);
                    DuzSilver4.SetActive(false);
                }
                else
                {
                    DuzGold4.SetActive(false);
                    DuzSilver4.SetActive(true);
                }
            }
            else
            {
                DuzGold4.SetActive(false);
                DuzSilver4.SetActive(false);
            }

            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 7)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);

            Duz5.SetActive(true);
            int Duz5RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn5 = Random.Range(0, 3);
            if (Duz5RandomGoldSpawn == 0 || Duz5RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn5 == 0)
                {
                    DuzGold5.SetActive(true);
                    DuzSilver5.SetActive(false);
                }
                else
                {
                    DuzGold5.SetActive(false);
                    DuzSilver5.SetActive(true);
                }
            }
            else
            {
                DuzGold5.SetActive(false);
                DuzSilver5.SetActive(false);
            }

            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 8)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);

            Duz6.SetActive(true);
            int Duz6RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn6 = Random.Range(0, 3);
            if (Duz6RandomGoldSpawn == 0 || Duz6RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn6 == 0)
                {
                    DuzGold6.SetActive(true);
                    DuzSilver6.SetActive(false);
                }
                else
                {
                    DuzGold6.SetActive(false);
                    DuzSilver6.SetActive(true);
                }
            }
            else
            {
                DuzGold6.SetActive(false);
                DuzSilver6.SetActive(false);
            }

            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 9)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);

            Duz7.SetActive(true);
            int Duz7RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn7 = Random.Range(0, 3);
            if (Duz7RandomGoldSpawn == 0 || Duz7RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn7 == 0)
                {
                    DuzGold7.SetActive(true);
                    DuzSilver7.SetActive(false);
                }
                else
                {
                    DuzGold7.SetActive(false);
                    DuzSilver7.SetActive(true);
                }
            }
            else
            {
                DuzGold7.SetActive(false);
                DuzSilver7.SetActive(false);
            }

            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 10)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);

            Duz8.SetActive(true);
            int Duz8RandomGoldSpawn = Random.Range(0, 3);
            int GoldSilverGoldSpawn8 = Random.Range(0, 3);
            if (Duz8RandomGoldSpawn == 0 || Duz8RandomGoldSpawn == 1)
            {
                if (GoldSilverGoldSpawn8 == 0)
                {
                    DuzGold8.SetActive(true);
                    DuzSilver8.SetActive(false);
                }
                else
                {
                    DuzGold8.SetActive(false);
                    DuzSilver8.SetActive(true);
                }
            }
            else
            {
                DuzGold8.SetActive(false);
                DuzSilver8.SetActive(false);
            }

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 11)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(true);
            int Kare1RandomGoldSpawn = Random.Range(0, 3);
            int Kare1GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare1RandomGoldSpawn == 0 || Kare1RandomGoldSpawn == 1)
            {
                if (Kare1GoldSilverGoldSpawn == 0)
                {
                    KareGold1.SetActive(true);
                    KareSilver1.SetActive(false);
                }
                else
                {
                    KareGold1.SetActive(false);
                    KareSilver1.SetActive(true);
                }
            }
            else
            {
                KareGold1.SetActive(false);
                KareSilver1.SetActive(false);
            }

            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 12)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);

            Kare2.SetActive(true);
            int Kare2RandomGoldSpawn = Random.Range(0, 3);
            int Kare2GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare2RandomGoldSpawn == 0 || Kare2RandomGoldSpawn == 1)
            {
                if (Kare2GoldSilverGoldSpawn == 0)
                {
                    KareGold2.SetActive(true);
                    KareSilver2.SetActive(false);
                }
                else
                {
                    KareGold2.SetActive(false);
                    KareSilver2.SetActive(true);
                }
            }
            else
            {
                KareGold2.SetActive(false);
                KareSilver2.SetActive(false);
            }

            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 13)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);

            Kare3.SetActive(true);
            int Kare3RandomGoldSpawn = Random.Range(0, 3);
            int Kare3GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare3RandomGoldSpawn == 0 || Kare3RandomGoldSpawn == 1)
            {
                if (Kare3GoldSilverGoldSpawn == 0)
                {
                    KareGold3.SetActive(true);
                    KareSilver3.SetActive(false);
                }
                else
                {
                    KareGold3.SetActive(false);
                    KareSilver3.SetActive(true);
                }
            }
            else
            {
                KareGold3.SetActive(false);
                KareSilver3.SetActive(false);
            }

            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 14)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);

            Kare4.SetActive(true);
            int Kare4RandomGoldSpawn = Random.Range(0, 3);
            int Kare4GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare4RandomGoldSpawn == 0 || Kare4RandomGoldSpawn == 1)
            {
                if (Kare4GoldSilverGoldSpawn == 0)
                {
                    KareGold4.SetActive(true);
                    KareSilver4.SetActive(false);
                }
                else
                {
                    KareGold4.SetActive(false);
                    KareSilver4.SetActive(true);
                }
            }
            else
            {
                KareGold4.SetActive(false);
                KareSilver4.SetActive(false);
            }

            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 15)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);

            Kare5.SetActive(true);
            int Kare5RandomGoldSpawn = Random.Range(0, 3);
            int Kare5GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare5RandomGoldSpawn == 0 || Kare5RandomGoldSpawn == 1)
            {
                if (Kare5GoldSilverGoldSpawn == 0)
                {
                    KareGold5.SetActive(true);
                    KareSilver5.SetActive(false);
                }
                else
                {
                    KareGold5.SetActive(false);
                    KareSilver5.SetActive(true);
                }
            }
            else
            {
                KareGold5.SetActive(false);
                KareSilver5.SetActive(false);
            }

            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 16)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);

            Kare6.SetActive(true);
            int Kare6RandomGoldSpawn = Random.Range(0, 3);
            int Kare6GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare6RandomGoldSpawn == 0 || Kare6RandomGoldSpawn == 1)
            {
                if (Kare6GoldSilverGoldSpawn == 0)
                {
                    KareGold6.SetActive(true);
                    KareSilver6.SetActive(false);
                }
                else
                {
                    KareGold6.SetActive(false);
                    KareSilver6.SetActive(true);
                }
            }
            else
            {
                KareGold6.SetActive(false);
                KareSilver6.SetActive(false);
            }

            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 17)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);

            Kare7.SetActive(true);
            int Kare7RandomGoldSpawn = Random.Range(0, 3);
            int Kare7GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare7RandomGoldSpawn == 0 || Kare7RandomGoldSpawn == 1)
            {
                if (Kare7GoldSilverGoldSpawn == 0)
                {
                    KareGold7.SetActive(true);
                    KareSilver7.SetActive(false);
                }
                else
                {
                    KareGold7.SetActive(false);
                    KareSilver7.SetActive(true);
                }
            }
            else
            {
                KareGold7.SetActive(false);
                KareSilver7.SetActive(false);
            }

            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 18)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);

            Kare8.SetActive(true);
            int Kare8RandomGoldSpawn = Random.Range(0, 3);
            int Kare8GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare8RandomGoldSpawn == 0 || Kare8RandomGoldSpawn == 1)
            {
                if (Kare8GoldSilverGoldSpawn == 0)
                {
                    KareGold8.SetActive(true);
                    KareSilver8.SetActive(false);
                }
                else
                {
                    KareGold8.SetActive(false);
                    KareSilver8.SetActive(true);
                }
            }
            else
            {
                KareGold8.SetActive(false);
                KareSilver8.SetActive(false);
            }

            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 19)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);

            Kare9.SetActive(true);
            int Kare9RandomGoldSpawn = Random.Range(0, 3);
            int Kare9GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare9RandomGoldSpawn == 0 || Kare9RandomGoldSpawn == 1)
            {
                if (Kare9GoldSilverGoldSpawn == 0)
                {
                    KareGold9.SetActive(true);
                    KareSilver9.SetActive(false);
                }
                else
                {
                    KareGold9.SetActive(false);
                    KareSilver9.SetActive(true);
                }
            }
            else
            {
                KareGold9.SetActive(false);
                KareSilver9.SetActive(false);
            }

            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 20)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);

            Kare10.SetActive(true);
            int Kare10RandomGoldSpawn = Random.Range(0, 3);
            int Kare10GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Kare10RandomGoldSpawn == 0 || Kare10RandomGoldSpawn == 1)
            {
                if (Kare10GoldSilverGoldSpawn == 0)
                {
                    KareGold10.SetActive(true);
                    KareSilver10.SetActive(false);
                }
                else
                {
                    KareGold10.SetActive(false);
                    KareSilver10.SetActive(true);
                }
            }
            else
            {
                KareGold10.SetActive(false);
                KareSilver10.SetActive(false);
            }

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 21)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(true);
            int Daire1RandomGoldSpawn = Random.Range(0, 3);
            int Daire1GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Daire1RandomGoldSpawn == 0 || Daire1RandomGoldSpawn == 1)
            {
                if (Daire1GoldSilverGoldSpawn == 0)
                {
                    DaireGold1.SetActive(true);
                    DaireSilver1.SetActive(false);
                }
                else
                {
                    DaireGold1.SetActive(false);
                    DaireSilver1.SetActive(true);
                }
            }
            else
            {
                DaireGold1.SetActive(false);
                DaireSilver1.SetActive(false);
            }

            Daire2.SetActive(false);
        }
        else if (RandomEngel == 22)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);

            Daire2.SetActive(true);
            int Daire2RandomGoldSpawn = Random.Range(0, 3);
            int Daire2GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Daire2RandomGoldSpawn == 0 || Daire2RandomGoldSpawn == 1)
            {
                if (Daire2GoldSilverGoldSpawn == 0)
                {
                    DaireGold2.SetActive(true);
                    DaireSilver2.SetActive(false);
                }
                else
                {
                    DaireGold2.SetActive(false);
                    DaireSilver2.SetActive(true);
                }
            }
            else
            {
                DaireGold2.SetActive(false);
                DaireSilver2.SetActive(false);
            }

        }
        else if (RandomEngel == 23)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(true);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 24)
        {
            Bosluklu1.SetActive(true);

            int Bosluklu1RandomGoldSpawn = Random.Range(0, 3);
            int Bosluklu1GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Bosluklu1RandomGoldSpawn == 0 || Bosluklu1RandomGoldSpawn == 1)
            {
                if (Bosluklu1GoldSilverGoldSpawn == 0)
                {
                    BoslukluGold1.SetActive(true);
                    BoslukluSilver1.SetActive(false);
                }
                else
                {
                    BoslukluGold1.SetActive(false);
                    BoslukluSilver1.SetActive(true);
                }
            }
            else
            {
                BoslukluGold1.SetActive(false);
                BoslukluSilver1.SetActive(false);
            }

            float YukseklikAlcaklik = Random.Range(20.0f, 27.0f);
            Bosluklu1.transform.position = new Vector3(Bosluklu1.transform.position.x, YukseklikAlcaklik, Bosluklu1.transform.position.z);

            float RandomGenislik = Random.Range(0.7f, 7.1f);
            Bosluklu1_Alt.transform.localScale = new Vector3(RandomGenislik, Bosluklu1_Alt.transform.localScale.y, Bosluklu1_Alt.transform.localScale.z);
            Bosluklu1_Ust.transform.localScale = new Vector3(RandomGenislik, Bosluklu1_Ust.transform.localScale.y, Bosluklu1_Ust.transform.localScale.z);

            Bosluklu2.SetActive(false);
            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 25)
        {
            Bosluklu1.SetActive(false);

            Bosluklu2.SetActive(true);

            int Bosluklu2RandomGoldSpawn = Random.Range(0, 3);
            int Bosluklu2GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Bosluklu2RandomGoldSpawn == 0 || Bosluklu2RandomGoldSpawn == 1)
            {
                if (Bosluklu2GoldSilverGoldSpawn == 0)
                {
                    BoslukluGold2.SetActive(true);
                    BoslukluSilver2.SetActive(false);
                }
                else
                {
                    BoslukluGold2.SetActive(false);
                    BoslukluSilver2.SetActive(true);
                }
            }
            else
            {
                BoslukluGold2.SetActive(false);
                BoslukluSilver2.SetActive(false);
            }

            float YukseklikAlcaklik = Random.Range(20.0f, 27.0f);
            Bosluklu2.transform.position = new Vector3(Bosluklu2.transform.position.x, YukseklikAlcaklik, Bosluklu2.transform.position.z);

            float RandomGenislik = Random.Range(0.7f, 7.1f);
            Bosluklu2_Alt.transform.localScale = new Vector3(RandomGenislik, Bosluklu2_Alt.transform.localScale.y, Bosluklu2_Alt.transform.localScale.z);
            Bosluklu2_Ust.transform.localScale = new Vector3(RandomGenislik, Bosluklu2_Ust.transform.localScale.y, Bosluklu2_Ust.transform.localScale.z);

            Bosluklu3.SetActive(false);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }
        else if (RandomEngel == 26)
        {
            Bosluklu1.SetActive(false);
            Bosluklu2.SetActive(false);

            Bosluklu3.SetActive(true);

            int Bosluklu3RandomGoldSpawn = Random.Range(0, 3);
            int Bosluklu3GoldSilverGoldSpawn = Random.Range(0, 3);
            if (Bosluklu3RandomGoldSpawn == 0 || Bosluklu3RandomGoldSpawn == 1)
            {
                if (Bosluklu3GoldSilverGoldSpawn == 0)
                {
                    BoslukluGold3.SetActive(true);
                    BoslukluSilver3.SetActive(false);
                }
                else
                {
                    BoslukluGold3.SetActive(false);
                    BoslukluSilver3.SetActive(true);
                }
            }
            else
            {
                BoslukluGold3.SetActive(false);
                BoslukluSilver3.SetActive(false);
            }

            float YukseklikAlcaklik = Random.Range(20.0f, 27.0f);
            Bosluklu3.transform.position = new Vector3(Bosluklu3.transform.position.x, YukseklikAlcaklik, Bosluklu3.transform.position.z);

            float RandomGenislik = Random.Range(0.7f, 7.1f);
            Bosluklu3_Alt.transform.localScale = new Vector3(RandomGenislik, Bosluklu3_Alt.transform.localScale.y, Bosluklu3_Alt.transform.localScale.z);
            Bosluklu3_Ust.transform.localScale = new Vector3(RandomGenislik, Bosluklu3_Ust.transform.localScale.y, Bosluklu3_Ust.transform.localScale.z);

            KarsilikEng1.SetActive(false);
            KarsilikEng2.SetActive(false);
            KarsilikEng3.SetActive(false);
            KarsilikEng4.SetActive(false);

            Duz1.SetActive(false);
            Duz2.SetActive(false);
            Duz3.SetActive(false);
            Duz4.SetActive(false);
            Duz5.SetActive(false);
            Duz6.SetActive(false);
            Duz7.SetActive(false);
            Duz8.SetActive(false);

            Kare1.SetActive(false);
            Kare2.SetActive(false);
            Kare3.SetActive(false);
            Kare4.SetActive(false);
            Kare5.SetActive(false);
            Kare6.SetActive(false);
            Kare7.SetActive(false);
            Kare8.SetActive(false);
            Kare9.SetActive(false);
            Kare10.SetActive(false);

            Daire1.SetActive(false);
            Daire2.SetActive(false);
        }

    }
}
