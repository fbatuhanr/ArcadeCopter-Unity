using UnityEngine;
using System.Collections;

public class DuvarYanmaAnim_Ayar : MonoBehaviour {

    public Transform helikopter;
    void Start()
    {

    }
    void Update()
    {

    }
    void OnCollisionEnter(Collision DuvarTemas)
    {
        if (helikopter.transform.position.x > 3300)
        {
            if (DuvarTemas.gameObject.tag == "KarakterYandi")
            {
                if (helikopter.transform.position.x > transform.position.x)
                {
                    Destroy(gameObject, 5.0f);
                }    
                else
                {
                    Destroy(gameObject, 10.0f);
                }
            }
        }
    }
}
