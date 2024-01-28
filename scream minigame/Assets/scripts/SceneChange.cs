using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    float timer = 0, waitTime = 10;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > waitTime)
        {
            int index = Random.Range(2, 6);
            SceneManager.LoadScene(index);
        }
    }
}
