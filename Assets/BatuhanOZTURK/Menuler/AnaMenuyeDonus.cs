using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class AnaMenuyeDonus : MonoBehaviour {

    public static bool AnaMenuyeDonScene;
    public string AnaMenu;

    void Start () {
        AnaMenuyeDonScene = false;
    }
	
	void Update () {
        YuklemeEkrani.i = 0;
        if (AnaMenuyeDonScene)
        {
            SceneManager.LoadScene(AnaMenu);
        }
	}
}
