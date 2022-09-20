using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Yukleniyor : MonoBehaviour {

    public Text YukleniyorYazisi;
    public static string Yukleniyor_Loading;

    public static int Yukle;

    public string SonsuzOyun;
    public string Bolum1;

    float GeriSayim;

    void Start()
    {
        GeriSayim = 2.0f;
    }
	void Update () {
        Time.timeScale = 1;

        YukleniyorYazisi.GetComponent<Text>().text = Yukleniyor_Loading;
        YukleniyorYazisi.GetComponent<Text>().fontSize = Screen.width / 14;

        if (GeriSayim > 0.0f)
        {
            GeriSayim -= Time.deltaTime;
        }
        if (GeriSayim <= 0.1f)
        {
            if (Yukle == 0) {
                SceneManager.LoadScene(SonsuzOyun);
            }
            else if (Yukle == 1)
            {
                SceneManager.LoadScene(Bolum1);
            }
        } 
    }
}
