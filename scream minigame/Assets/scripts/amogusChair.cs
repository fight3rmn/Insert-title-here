using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class amogusChair : MonoBehaviour
{
    public GameObject newImage;
    public GameObject curImage;
    float timer = 0;
    bool timerStart = false;
    public void onClick4()
    {
        newImage.transform.position = curImage.transform.position;
        Destroy(curImage);
        timerStart = true;
    }

    void Update()
    {
        if (timerStart == true)
        {
            timer += Time.deltaTime;
        }
        if(timer > 3)
        {
            SceneManager.LoadScene(Random.Range(2, 6));
        }
    }
}
