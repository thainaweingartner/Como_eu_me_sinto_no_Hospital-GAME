using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Skin : MonoBehaviour
{
    // Start is called before the first frame update
    int getSkin = Troca_Skin.skin;
    public AnimatorOverrideController skin1;
    public AnimatorOverrideController skin2;
    void Start()
    {
        if (getSkin == 1)
        {
            GetComponent<Animator>().runtimeAnimatorController = skin1 as RuntimeAnimatorController;
        }else if(getSkin == 2)
        {
            GetComponent<Animator>().runtimeAnimatorController = skin2 as RuntimeAnimatorController;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
