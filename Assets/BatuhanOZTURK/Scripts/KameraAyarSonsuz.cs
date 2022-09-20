using UnityEngine;
using System.Collections;

public class KameraAyarSonsuz : MonoBehaviour {

    public Transform Takip;
    bool AnimBitti, Yakinlas;
    float x, y, z;

	void Start () {

        AnimBitti = true;
        Yakinlas = true;

        x = 9;
        y = 10.2f;
        z = -25.25f;
    }
	
	void Update () {
        transform.position = new Vector3(Takip.position.x + x, y, z);

        if (Takip.transform.position.x >= -59.8)
        {
            if (AnimBitti)
            {
                Invoke("AnimBitmis", 0);
                AnimBitti = false;
            }
            else
            {
                if (transform.eulerAngles.x < 7.147f)
                {
                    transform.Rotate(0.05f, 0, 0);
                }
            }
        }

        if (OyuncuAyar.HelikopterYanma) {

            if (x > 1)
            {
                x -= 0.2f;
            }

            if (Yakinlas)
            {
                z += 0.05f;
            }
            else
            {
                z -= 0.05f;

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
        else
        {
            if (x < 9)
            {
                x += 0.2f;
            }
            if (z > -25.25f) {
                z -= 0.2f;
            }
        }

            
        
    }
    void AnimBitmis()
    {
        transform.Rotate(0.3f, 0, 0);
    }
}
