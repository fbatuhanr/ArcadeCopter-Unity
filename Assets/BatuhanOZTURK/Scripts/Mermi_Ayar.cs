using UnityEngine;
using System.Collections;

public class Mermi_Ayar : MonoBehaviour {

    public Transform helikopter;

    public GameObject Mermi;

    Color Duvar1;
    float G1, B1;

    Color Duvar2;
    float G2, B2;

    Color Duvar3;
    float G3, B3;

    Color Duvar4;
    float G4, B4;

    Color Duvar5;
    float G5, B5;

    Color Duvar6;
    float G6, B6;

    Color Duvar7;
    float G7, B7;

    Color Duvar8;
    float G8, B8;

    Color Duvar9;
    float G9, B9;

    Color Duvar10;
    float G10, B10;


    Color Duvar11;
    float G11, B11;

    Color Duvar12;
    float G12, B12;

    Color Duvar13;
    float G13, B13;

    Color Duvar14;
    float G14, B14;

    void Start()
    {
        G1 = -0.2f;
        B1 = -0.2f;
        Duvar1 = new Vector4(1, G1, B1, 1);

        G2 = -0.2f;
        B2 = -0.2f;
        Duvar2 = new Vector4(1, G2, B2, 1);

        G3 = -0.2f;
        B3 = -0.2f;
        Duvar3 = new Vector4(1, G3, B3, 1);

        G4 = -0.2f;
        B4 = -0.2f;
        Duvar4 = new Vector4(1, G4, B4, 1);

        G5 = -0.2f;
        B5 = -0.2f;
        Duvar5 = new Vector4(1, G5, B5, 1);

        G6 = -0.2f;
        B6 = -0.2f;
        Duvar6 = new Vector4(1, G6, B6, 1);

        G7 = -0.2f;
        B7 = -0.2f;
        Duvar7 = new Vector4(1, G7, B7, 1);

        G8 = -0.2f;
        B8 = -0.2f;
        Duvar8 = new Vector4(1, G8, B8, 1);

        G9 = -0.4f;
        B9 = -0.4f;
        Duvar9 = new Vector4(1, G9, B9, 1);

        G10 = -0.4f;
        B10 = -0.4f;
        Duvar10 = new Vector4(1, G10, B10, 1);

        G11 = -0.4f;
        B11 = -0.4f;
        Duvar11 = new Vector4(1, G11, B11, 1);

        G12 = -0.4f;
        B12 = -0.4f;
        Duvar12 = new Vector4(1, G12, B12, 1);

        G13 = -0.4f;
        B13 = -0.4f;
        Duvar13 = new Vector4(1, G13, B13, 1);

        G14 = -0.4f;
        B14 = -0.4f;
        Duvar14 = new Vector4(1, G14, B14, 1);

    }

    void OnCollisionEnter(Collision MermiIsabet)
    {
        if (helikopter.transform.position.x > 3300)
        {
            if (MermiIsabet.gameObject.tag == "Duvar1" || MermiIsabet.gameObject.tag == "Duvar2" || MermiIsabet.gameObject.tag == "Duvar3" || MermiIsabet.gameObject.tag == "Duvar4" || MermiIsabet.gameObject.tag == "Duvar5" || MermiIsabet.gameObject.tag == "Duvar6" || MermiIsabet.gameObject.tag == "Duvar7" || MermiIsabet.gameObject.tag == "Duvar8" || MermiIsabet.gameObject.tag == "Duvar9" || MermiIsabet.gameObject.tag == "Duvar10" || MermiIsabet.gameObject.tag == "Duvar11" || MermiIsabet.gameObject.tag == "Duvar12" || MermiIsabet.gameObject.tag == "Duvar13" || MermiIsabet.gameObject.tag == "Duvar14")
            {
                SesAyarSFX.DuvarHitSesiCal = true;
            }

            if (MermiIsabet.gameObject.tag == "Duvar1")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar1;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar2")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar2;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar3")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar3;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar4")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar4;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar5")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar5;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar6")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar6;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar7")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar7;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar8")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar8;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar9")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar9;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar10")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar10;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar11")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar11;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar12")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar12;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar13")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar13;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            else if (MermiIsabet.gameObject.tag == "Duvar14")
            {
                MermiIsabet.gameObject.GetComponent<Renderer>().material.color += Duvar14;

                if (MermiIsabet.gameObject.GetComponent<Renderer>().material.color.g <= 0.2f)
                {
                    MermiIsabet.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
            //
            if (OyuncuAyar.OyunBitti == true && (MermiIsabet.gameObject.tag == "karakteryandi2" || MermiIsabet.gameObject.tag == "Duvar1" || MermiIsabet.gameObject.tag == "Duvar2" || MermiIsabet.gameObject.tag == "Duvar3" || MermiIsabet.gameObject.tag == "Duvar4" || MermiIsabet.gameObject.tag == "Duvar5" || MermiIsabet.gameObject.tag == "Duvar6" || MermiIsabet.gameObject.tag == "Duvar7" || MermiIsabet.gameObject.tag == "Duvar8" || MermiIsabet.gameObject.tag == "Duvar9" || MermiIsabet.gameObject.tag == "Duvar10" || MermiIsabet.gameObject.tag == "Duvar11" || MermiIsabet.gameObject.tag == "Duvar12" || MermiIsabet.gameObject.tag == "Duvar13" || MermiIsabet.gameObject.tag == "Duvar14"))
            {

            }
            else if (MermiIsabet.gameObject.tag == "KarakterYandi")
            {
                SesAyarSFX.MermiDususSesiCal = true;
                Destroy(Mermi, 5.0f);
            }
        }
    }
  }
