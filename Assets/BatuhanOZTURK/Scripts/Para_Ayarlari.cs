using UnityEngine;
using System.Collections;

public class Para_Ayarlari : MonoBehaviour {

   public GameObject AutoRotateGoldSilver;

    public bool TemasOlayi;

    void Start() {

        TemasOlayi = false;
    }

    void Update() {

        if (!OyuncuAyar.DurdurmaMenusu) { 
        AutoRotateGoldSilver.transform.Rotate(0, 2.5f, 0);
        }
        else
        {
            AutoRotateGoldSilver.transform.Rotate(0, 0, 0);
        }

        if (TemasOlayi)
        {
            Invoke("GoldSilver", 0);
            TemasOlayi = false;
        }

    }
    void GoldSilver()
    {
        gameObject.SetActive(false);
    }
   }
