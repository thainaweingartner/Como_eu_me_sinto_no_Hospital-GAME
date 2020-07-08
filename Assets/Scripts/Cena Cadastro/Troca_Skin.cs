using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca_Skin : MonoBehaviour
{
    public static int skin = 1;
    public GameObject sprite1;
    public GameObject sprite2;

    public void skin1()
    {
        skin = 1;
        sprite1.GetComponent<RectTransform>().localScale = new Vector3(0.18f,0.18f,1);
        sprite2.GetComponent<RectTransform>().localScale = new Vector3(0.13f, 0.13f, 1);
    }
    
    public void skin2()
    {
        skin = 2;
        sprite2.GetComponent<RectTransform>().localScale = new Vector3(0.18f, 0.18f, 1);
        sprite1.GetComponent<RectTransform>().localScale = new Vector3(0.13f, 0.13f, 1);
    }
  
}
