using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diyalogTrigger : MonoBehaviour
{


    public diyalog diyalog; 

    public void TriggerDialogue()
    {
        FindObjectOfType<girisText>().StartDialogue(diyalog);
    }

}
