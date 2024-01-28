using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbodyPlayer;
    private Vector2 playerSpeed;
    [SerializeField] float horizontalMovement = 1f, speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementSpeed();
        Walk();
    }



    private void FixedUpdate()
    {
        rigidbodyPlayer.MovePosition(rigidbodyPlayer.position + playerSpeed * speed * Time.fixedDeltaTime);
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
}
