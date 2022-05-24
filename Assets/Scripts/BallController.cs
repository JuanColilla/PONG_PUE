using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    // SerializeField permite acceder a una variable privada desde el editor, pero no es compatible con el { get; set; }.
    [SerializeField] float velocityBall;

    // Start is called before the first frame update
    void Start()
    {
        ShotBall();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotBall()
    {
        int x = Random.Range(0, 2) * 2 - 1; // 4 direcciones
        int y = Random.Range(0, 2) * 2 - 1;
        Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(velocityBall * x, velocityBall * y);

    }
}
