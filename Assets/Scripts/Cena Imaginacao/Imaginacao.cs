using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Imaginacao : MonoBehaviour
{
    public void historia()
    {
        SceneManager.LoadScene(4);
    }

    public void respiracao()
    {
        SceneManager.LoadScene(6);
    }

    public void final()
    {
        SceneManager.LoadScene(7);
    }
}
