using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respiracao : MonoBehaviour
{
    public void historia()
    {
        SceneManager.LoadScene(4);
    }

    public void imaginacao()
    {
        SceneManager.LoadScene(5);
    }

    public void final()
    {
        SceneManager.LoadScene(7);
    }
}
