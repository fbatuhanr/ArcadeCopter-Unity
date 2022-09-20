using UnityEngine;
using System.Collections;

public class SesAyarSFX : MonoBehaviour {

    public AudioSource HelikopterSFX;

    public static bool SilahSesiCal;
    public static bool DuvarHitSesiCal;
    public static bool MermiDususSesiCal;
    public static bool ParaToplamaSesi;

    public AudioClip[] SilahSesleri;
    public AudioClip[] MermiDususSesleri;
    public AudioClip DuvarHit,SkorKazanmaSesi;

    void Start () {

        AyarlarMenu.MuteHeliSFX = PlayerPrefs.GetInt("MuteHeliSFX");

        if (AyarlarMenu.MuteHeliSFX == 0)
        {
            HelikopterSFX.Play();
            HelikopterSFX.volume = 1.0f;
        }
        else
        {
            HelikopterSFX.volume = 0;
            HelikopterSFX.Stop();
        }
	
	}
	
	void Update () {

        if (ParaToplamaSesi)
        {
            Invoke("ParaSesi", 0);
            ParaToplamaSesi = false;
        }

        if (SilahSesiCal)
        {
            Invoke("SilahAtesSesi", 0);
            SilahSesiCal = false;
        }

        if (DuvarHitSesiCal)
        {
            Invoke("DuvarHasarSesi", 0);
            DuvarHitSesiCal = false;
        }

        if (MermiDususSesiCal)
        {
            Invoke("MermiDusmeSesi", 0);
            MermiDususSesiCal = false;
        }
    } // Bitis

void SilahAtesSesi()
{
    int SilahSesiRandom = Random.Range(0, 4);
    if (SilahSesiRandom == 0)
    {
        HelikopterSFX.PlayOneShot(SilahSesleri[0], 1);
    }
    else if (SilahSesiRandom == 1)
    {
        HelikopterSFX.PlayOneShot(SilahSesleri[1], 1);
    }
    else if (SilahSesiRandom == 2)
    {
        HelikopterSFX.PlayOneShot(SilahSesleri[2], 1);
    }
    else if (SilahSesiRandom == 3)
    {
        HelikopterSFX.PlayOneShot(SilahSesleri[3], 1);
    }
}
void DuvarHasarSesi()
{
    HelikopterSFX.PlayOneShot(DuvarHit, 1);
}
void MermiDusmeSesi()
{
    int MermiDusmeSesiRandom = Random.Range(0, 3);
    if (MermiDusmeSesiRandom == 0)
    {
        HelikopterSFX.PlayOneShot(MermiDususSesleri[0], 1);
    }
    else if (MermiDusmeSesiRandom == 1)
    {
        HelikopterSFX.PlayOneShot(MermiDususSesleri[1], 1);
    }
    else if (MermiDusmeSesiRandom == 2)
    {
        HelikopterSFX.PlayOneShot(MermiDususSesleri[2], 1);
    }
}
void ParaSesi()
{
    HelikopterSFX.PlayOneShot(SkorKazanmaSesi, 1);
}

}
