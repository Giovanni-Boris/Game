using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CombustiblePlayer : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    private float combustible = 10f;
    public Image barraDeCombustible;
    public float getCombustible()
    {
        return combustible;
    }
    public void GameOver()
    {
        gameOverScreen.Setup(0);
    }
    void Start()
    {
    }
    void Update()
    {
        combustible = Mathf.Clamp(combustible, 0, 10f);
        barraDeCombustible.fillAmount = combustible / 10;
    }
    public bool bajarCombustible()
    {
        if (combustible == 0)
        {
            GameOver();
            return false;
        }
        combustible -= Time.deltaTime*3;
        return true;
    }
    public void aumentarCombustible()
    {
        combustible += 1;
    }
    public void resetGame()
    {
        combustible = 100;
    }
}
