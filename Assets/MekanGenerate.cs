using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MekanGenerate : MonoBehaviour
{
    public Sprite[] mekan_s;
    [SerializeField] int mekanno;
    void Start()
    {
        mekanno = PlayerPrefs.GetInt("mekan");
        GetComponent<SpriteRenderer>().sprite = mekan_s[PlayerPrefs.GetInt("mekan")];
    }

   

}
