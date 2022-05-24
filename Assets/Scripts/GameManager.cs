using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    int puntuacionJugador1 = 0;
    int puntuacionJugador2 = 0;


    public void Score(int numJugador)
    {
        AsignarPuntacionJugador(numJugador);

        ActualizarMarcadores();

        if (IsGameOver())
        {
            GameOver();
        }
        else
        {
            ResetearPosicionPelotaYLanzar();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    bool IsGameOver()
    {
        return puntuacionJugador1 == 3 || puntuacionJugador2 == 3;
    }

    void ActualizarMarcadores()
    {

        GameObject.Find("MarcadorJugador1").GetComponent<TextMeshProUGUI>().text = puntuacionJugador1.ToString();
        GameObject.Find("MarcadorJugador2").GetComponent<TextMeshProUGUI>().text = puntuacionJugador2.ToString();
    }

    void ResetearPosicionPelotaYLanzar()
    {
        GameObject.Find("Pelota").GetComponent<BallController>().ShotBall();
    }

    void AsignarPuntacionJugador(int numPorteria)
    {
        if (numPorteria == 1)
        {
            puntuacionJugador2++;
        }
        else
        {
            puntuacionJugador1++;
        }

        Debug.Log($"Jugador1 {puntuacionJugador1} Jugador2 {puntuacionJugador2}");
    }
}
