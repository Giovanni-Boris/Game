using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public float vida;
    public Image barraDeVida;

    public void GameOver()
    {
        gameOverScreen.Setup((int)vida);
    }
    void Start()
    {
    }
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 5);
        barraDeVida.fillAmount = vida / 5;
    }
    public bool bajarVida()
    {
        if (vida == 0)
        {
            GameOver();
            return false;
        }
        vida -= 1;
        return true;
    }
    public void resetGame()
    {
        vida = 5;
    }
}
