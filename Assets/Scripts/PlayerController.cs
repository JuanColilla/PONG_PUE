using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // string playerName;
    [SerializeField] float playerVelocity;
    [SerializeField] bool autoMode;
    GameObject pelota;

    private void Awake()
    {
        pelota = GameObject.Find("Ball");
    }

    // Update is called once per frame
    float direction = 0;

    void Update()
    {

        if (!autoMode)
        {
            if (gameObject.name == "LeftPlayer")
            {
                direction = Input.GetAxisRaw("LeftPlayer");
            }
            else
            {
                direction = Input.GetAxisRaw("RightPlayer");
            }
        }
        else
        {
            float posicionPelotaY = pelota.transform.position.y;
            float posicionJugadorY = gameObject.transform.position.y;
            float velocidadPelotaX = pelota.GetComponent<Rigidbody2D>().velocity.x;

            if (velocidadPelotaX > 0 && posicionPelotaY > posicionJugadorY)
            {
                direction = 1;
            }
            else if (velocidadPelotaX > 0 && posicionPelotaY < posicionJugadorY)
            {
                direction = -1;
            }
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction * playerVelocity);
    }
}
