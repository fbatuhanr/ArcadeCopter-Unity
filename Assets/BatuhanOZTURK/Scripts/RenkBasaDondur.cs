using UnityEngine;
using System.Collections;

public class RenkBasaDondur : MonoBehaviour {
	
  //  public Material HelikopterRengi;
  //  public Material HelikopterRengiDegisken;

    void Update () {

        if (OyuncuAyar.HelikopterYanma) {
    //        GetComponent<Renderer>().material = HelikopterRengiDegisken;
      }
        else
        {
   //   GetComponent<Renderer>().material = HelikopterRengi;
       }
    }
}
