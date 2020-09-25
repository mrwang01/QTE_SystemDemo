using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTESystems : MonoBehaviour
{
    public GameObject DisplayBox;
    public GameObject PassBox;
    public int QTEGen;
    public int WaitForKey;
    public int CorrectKey;
    public int CountingDown;

   void Update()
    {

        if (WaitForKey == 0)
        {
            QTEGen = Random.Range(1, 4);
            CountingDown = 1;
            if (QTEGen == 1)
            {
                WaitForKey = 1;
                DisplayBox.GetComponent<Text>().text = "[E]";
            }
            if (QTEGen == 2)
            {
                WaitForKey = 2;
                DisplayBox.GetComponent<Text>().text = "[R]";
            }
            if (QTEGen == 3)
            {
                WaitForKey = 3;
                DisplayBox.GetComponent<Text>().text = "[T]";
            }
        }
        if (QTEGen == 1)
        {
            if (Input.anyKeyDown){
                if (Input.GetKeyDown ("EKey"))
                {
                    CorrectKey = 1 ;
                    // StartCoroutine(KeyPressing());
                }
            }            
        }
        
    }


}
