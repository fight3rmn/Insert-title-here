using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkBy : MonoBehaviour
{
    public GameObject thisObject;
    public Rigidbody2D thisRB;
    public int index;
    int timer = 0;
    bool moved = false;

    void Start() {
        PlayerPrefs.SetInt("screamButtonPressed", 0);
    }
    void Update()
    {
        timer++;
        if(PlayerPrefs.GetInt("screamButtonPressed") != 0 && index < PlayerPrefs.GetInt("numPeople") && timer > 5000 + (2000*index)) {
            thisRB.velocity = new Vector2(100, 0);
            if(moved == false) {
            thisObject.transform.position = new Vector3(126, 239 + Random.Range(-50, 51), 0);
            moved = true;
            }
        }
    }
}
