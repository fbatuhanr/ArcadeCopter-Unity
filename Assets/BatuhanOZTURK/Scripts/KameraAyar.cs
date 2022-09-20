using UnityEngine;
using System.Collections;

public class KameraAyar : MonoBehaviour
{
    public Transform takip;
    bool Yakinlas;

    public static bool DefaultKamera;

    public static bool KameraSerbestYukari;
    public static bool KameraKilitYukari;

    public static bool KameraSerbestAsagi;
    public static bool KameraKilitAsagi;

    public static float x;
    public static float y;
    public static float z;

    float y2;

    void Start()
    {
        Yakinlas = true;
        DefaultKamera = true;

        KameraSerbestYukari = false;
        KameraKilitYukari = false;

        KameraSerbestAsagi = false;
        KameraKilitAsagi = false;

        x = 9;
        y = 10.2f;
        z = -25.25f;
        y2 = 34.45f;
    }

    void Update()
    {


        if (DefaultKamera)
        {
            transform.position = new Vector3(takip.position.x + x, y, z);
        }


        if (KameraSerbestYukari)
        {
            transform.position = new Vector3(takip.position.x + x, takip.position.y + 3.0f, z);
        }
        if (KameraSerbestAsagi)
        {
            transform.position = new Vector3(takip.position.x + x, takip.position.y, z);
        }


        if (KameraKilitYukari)
        {
            transform.position = new Vector3(takip.position.x + x, y2, z);
        }
        if (KameraKilitAsagi)
        {
            transform.position = new Vector3(takip.position.x + x, y, z);
        }


        if (OyuncuAyar.HelikopterYanma)
        {
            if (x > 1)
            {
                x -= 0.1f;
            }

            if (Yakinlas)
            {
                z += 0.025f;
            }
            else
            {
                z -= 0.025f;

                if (z < -24.0f)
                {
                    Yakinlas = true;
                }
            }

            if (z > -18.5f)
            {
                Yakinlas = false;
            }

        }

    }




}

