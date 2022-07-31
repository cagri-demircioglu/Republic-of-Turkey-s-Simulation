using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class girisText : MonoBehaviour
{
    public Text nameText;
    public Text diyalogText;


    public Animator animator;
    public Animator kapanis;
    public Animator baslangicKontrol;
    bool butonAktif = false;
    private Queue<string> yazilar;
    void Start()
    {
        yazilar = new Queue<string>();
        if (baslangicKontrol.GetBool("baslangicKontrol") == true)
        {
            Debug.Log("Baslangic Kontrol edildi");
        }
    }

    private void FixedUpdate()
    {
        if (baslangicKontrol.GetBool("baslangicKontrol") == true)
        {
            FindObjectOfType<diyalogTrigger>().TriggerDialogue();
            baslangicKontrol.SetBool("baslangicKontrol", false);
        }

    }

    public void StartDialogue(diyalog diyalog)
    {

        animator.SetBool("IsOpen", true);
        nameText.text = diyalog.isim;
        yazilar.Clear();
        foreach (string yazi in diyalog.yazilar)
        {
            yazilar.Enqueue(yazi);
        }

        DisplayNextSentence();
    
    }

    public void DisplayNextSentence()
    {
        if(yazilar.Count == 0)
        {
            EndDialogue();
            return;
        }
       string yazi = yazilar.Dequeue();

        diyalogText.text = yazi;
        }
    

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        kapanis.SetBool("kapanisKontrol", true);
        Debug.Log("End of conversation");

    }


}
