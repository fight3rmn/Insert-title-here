using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamButtons : MonoBehaviour
{
    int timer = 0;
    public GameObject thisObject;
    public int number;
    public int xCoord;
    public int yCoord;



    public void onClick() {
        PlayerPrefs.SetInt("screamButtonPressed", 1);
        if(PlayerPrefs.GetInt("numPeople") == number) {
            print("yes");
        }
        else {
            print("no");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer > 5000) {
            thisObject.transform.position = new Vector3(xCoord, yCoord, 0);
            
        }
    }


}
