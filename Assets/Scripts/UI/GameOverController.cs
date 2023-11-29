using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private HealthPoints playerHealth;
    [SerializeField] private GameOverLogic screen;
    [SerializeField] private AudioSource gameMusic;

    private void Update()
    {
        if (playerHealth.health <= 0)
        {
            gameMusic.Stop();
            screen.SetGameOverScreen();
        }
    }
}
