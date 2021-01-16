using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverText;

    public void GameOver()
    {
        gameOverText.SetActive(true);
    }
}
