using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbodyPlayer;
    private Vector2 playerSpeed;
    [SerializeField] float horizontalMovement = 1f, speed = 5f;
    [SerializeField] int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementSpeed();
        Walk();
    }

    private void GetMovementSpeed()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        playerSpeed = new Vector2(horizontalMovement, 0f);
    }

    private void Walk()
    {
        rigidbodyPlayer.velocity = (new Vector2(playerSpeed.x * speed, rigidbodyPlayer.velocity.y));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ("Moon"))
        {
            Debug.Log("Moon landed!");
            score++;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == ("Chair"))
        {
            Debug.Log("You didn't watch the jacket.");
            score++;
        }
    }
}
