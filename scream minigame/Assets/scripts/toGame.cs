using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGame : MonoBehaviour
{
    public void onClick3()
    {
        SceneManager.LoadScene(Random.Range(2, 6));
    }
}
