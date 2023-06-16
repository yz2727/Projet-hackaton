using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compteur : MonoBehaviour
{
    public float startingTime = 10f;
    private float currentTime;

    public Text timeText;
    public Text gameOverText;

    void Start()
    {
        currentTime = startingTime;
        UpdateTimeText();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimeText();
        }
        else
        {
            currentTime = 0;
            UpdateTimeText();
            GameOver();
        }
    }

    void UpdateTimeText()
    {
        timeText.text = "Time: " + currentTime.ToString("F2");

        if (currentTime <= 0)
        {
            timeText.gameObject.SetActive(false);
        }
    }

    void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over";
        // Ajoutez ici les actions que vous souhaitez effectuer lorsque le jeu est terminé
    }
}
