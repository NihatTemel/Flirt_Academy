using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextLineSize : MonoBehaviour
{

    TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        
        if (text.textInfo.lineCount > 2) 
        {
            text.fontSize--;
        }
    }
}
