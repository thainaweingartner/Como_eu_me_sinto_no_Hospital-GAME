using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour
{
    public void imaginacao()
    {
        SceneManager.LoadScene(5);
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
