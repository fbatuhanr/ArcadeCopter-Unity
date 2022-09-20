using UnityEngine;
using System.Collections;

public class HeliAnimSonsuz : MonoBehaviour {

    public Transform Helikopter;
    Animation HelikopterPervAnim;

    void Start () {
        HelikopterPervAnim = GetComponent<Animation>();
        HelikopterPervAnim.Stop();
    }


	void Update ()
    {
        if (Helikopter.transform.position.x >= -59.8)
        {
            if (Input.GetMouseButton(0))
            {
                HelikopterPervAnim["pervane"].speed = 1.3f;
                HelikopterPervAnim.Play("pervane");
            }
            else
            {
                HelikopterPervAnim["pervane"].speed = 0.65f;
                HelikopterPervAnim.Play("pervane");
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                HelikopterPervAnim["pervane"].speed = 1.3f;
                HelikopterPervAnim.Play("pervane");
            }
            else
            {
                HelikopterPervAnim["pervane"].speed = 1.3f;
                HelikopterPervAnim.Play("pervane");
            }
        }
    }
}
