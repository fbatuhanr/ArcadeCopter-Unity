using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderKontrol : MonoBehaviour {

    public Transform helikopter;

    public Slider ilkDalgaSlider, ikinciDalgaSlider, ucuncuDalgaSlider, dorduncuDalgaSlider, besinciDalgaSlider;

    public GameObject ilkDalga, ikinciDalga, ucuncuDalga, dorduncuDalga, besinciDalga;

    void Start()
    {
        ilkDalga.SetActive(true);
        ikinciDalga.SetActive(false);
        ucuncuDalga.SetActive(false);
        dorduncuDalga.SetActive(false);
        besinciDalga.SetActive(false);
    }
	void Update () {
        if (helikopter.transform.position.x < 980) {
            ilkDalga.SetActive(true);
            ikinciDalga.SetActive(false);
            ucuncuDalga.SetActive(false);
            dorduncuDalga.SetActive(false);
            besinciDalga.SetActive(false);
            ilkDalgaSlider.value = Mathf.MoveTowards(ilkDalgaSlider.value, helikopter.position.x, 1.0f);
        }
        else if (helikopter.transform.position.x >= 980 && helikopter.transform.position.x < 1855)
        {
            ilkDalga.SetActive(false);
            ikinciDalga.SetActive(true);
            ucuncuDalga.SetActive(false);
            dorduncuDalga.SetActive(false);
            besinciDalga.SetActive(false);
            ikinciDalgaSlider.value = Mathf.MoveTowards(ikinciDalgaSlider.value, helikopter.position.x, 1.0f);
        }
        else if (helikopter.transform.position.x >= 1855 && helikopter.transform.position.x < 2575)
        {
            ilkDalga.SetActive(false);
            ikinciDalga.SetActive(false);
            ucuncuDalga.SetActive(true);
            dorduncuDalga.SetActive(false);
            besinciDalga.SetActive(false);
            ucuncuDalgaSlider.value = Mathf.MoveTowards(ucuncuDalgaSlider.value, helikopter.position.x, 1.0f);
        }
        else if (helikopter.transform.position.x >= 2575 && helikopter.transform.position.x < 3350)
        {
            ilkDalga.SetActive(false);
            ikinciDalga.SetActive(false);
            ucuncuDalga.SetActive(false);
            dorduncuDalga.SetActive(true);
            besinciDalga.SetActive(false);
            dorduncuDalgaSlider.value = Mathf.MoveTowards(dorduncuDalgaSlider.value, helikopter.position.x, 1.0f);
        }
        else if (helikopter.transform.position.x >= 3350 && helikopter.transform.position.x < 3975)
        {
            ilkDalga.SetActive(false);
            ikinciDalga.SetActive(false);
            ucuncuDalga.SetActive(false);
            dorduncuDalga.SetActive(false);
            besinciDalga.SetActive(true);
            besinciDalgaSlider.value = Mathf.MoveTowards(besinciDalgaSlider.value, helikopter.position.x, 1.0f);
        }

    }
}
