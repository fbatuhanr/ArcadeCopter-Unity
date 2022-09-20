using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DaireselYukleme : MonoBehaviour {

    public Transform YuklemeBar;
    public Transform YuzdeArtisText;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
	void Update () {

        Time.timeScale = 1;

        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            YuzdeArtisText.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
        }
        else
        {
            YuzdeArtisText.GetComponent<Text>().text = "100%";

            if (YuklemeEkrani.i == 1)
            {
                YuklemeEkrani.Gecis = true;
            }else
            {
                AnaMenuyeDonus.AnaMenuyeDonScene = true;
            }
        }
        YuklemeBar.GetComponent<Image>().fillAmount = currentAmount / 100;
	
	}
}
