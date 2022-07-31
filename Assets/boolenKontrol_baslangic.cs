using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolenKontrol_baslangic : MonoBehaviour
{

    public Animator baslangicKontrol;


    public void animationEnded()
    {
        baslangicKontrol.SetBool("baslangicKontrol", true);
    }

}
