using UnityEngine;
using System.Collections;

public class BaslangicArkaPlan : MonoBehaviour {

    float zaman;

	void Start () {

        zaman = 4.0f;

    }

	void Update () {

        if (zaman >= 0.0f)
        {
            zaman -= Time.deltaTime;
        }
        if (zaman < 2.8f && zaman >= 0.0f) {
            GetComponent<Renderer>().material.color += Color.white / 4.0f * Time.deltaTime;
        }

    }
}
