using UnityEngine;
using System.Collections;

public class HelikopterAnimasyon : MonoBehaviour
{
    Animation anim;
    public Transform heli;
    float hizlaniyor;

    void Start()
    {
        hizlaniyor = 0.1f;
        anim = GetComponent<Animation>();
        anim.Stop();
    }

    void Update()
    {
        Debug.Log(Time.timeScale);
        if (OyuncuAyar.HelikopterYanma)
        {
            anim["pervane"].time = 0.06f;
        }

        
  if (heli.transform.position.x >= -87.5f && heli.transform.position.x <= -44.5f) {
            if (hizlaniyor <= 0.5f) { 
            hizlaniyor += 0.005f;
            }
            if (Input.GetMouseButton(0))
        {
            anim["pervane"].speed = hizlaniyor;
            anim.Play("pervane");
        }
        else
        {
            anim["pervane"].speed = hizlaniyor;  
            anim.Play("pervane");
        }
      }
  if (heli.transform.position.x > -44.5f)
        {
        if (OyuncuAyar.IkinciDalgaGucu || OyuncuAyar.BesinciDalgaGucu) {
                if (Input.GetMouseButton(0))
                {
                    anim["pervane"].speed = 1.3f;
                    anim.Play("pervane");
                }
                else
                {
                    anim["pervane"].speed = 1.3f;
                    anim.Play("pervane");
                }
            }
    else
        {
                if (OyuncuAyar.IkinciEngelGeliyor)
                {
                    if (Input.GetMouseButton(0))
                    {
                        anim["pervane"].speed = 0.9f;
                        anim.Play("pervane");
                    }
                    else
                    {
                        anim["pervane"].speed = 0.9f;
                        anim.Play("pervane");
                    }
                }
                else
                {
                    if (Input.GetMouseButton(0))
                    {
                        anim["pervane"].speed = 1.3f;
                        anim.Play("pervane");
                    }
                    else
                    {
                        anim["pervane"].speed = 0.7f;
                        anim.Play("pervane");
                    }
                }
        }
        }
    }
}
