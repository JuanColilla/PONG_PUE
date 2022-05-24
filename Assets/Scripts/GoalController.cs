using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    private string ballName = "Ball";
    private string gameManager = "GameManager";

    

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{

    //}

    //private void OnCollisionStay2D(Collision2D collision)
    //{

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Collision Triggered by {collision.gameObject.name}");

        if (collision.gameObject.name == ballName)
        {
            int numPorteria = int.Parse(gameObject.name.Replace("Goal", ""));
            GameObject.Find(gameManager).GetComponent<GameManager>().Score(numPorteria);
        } 
    }

   
}
