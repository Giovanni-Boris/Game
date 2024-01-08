using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VidaPlayer : MonoBehaviour
{
    public float vida = 5;
    public Image barraDeVida;
    void Start()
    {
        barraDeVida = GameObject.Find("Vida").GetComponent<Image>();
    }
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 5);
        barraDeVida.fillAmount = vida / 5;
    }
    public void bajarVida()
    {
        vida -= 1;
    }
    public void resetGame()
    {
        vida = 5;
    }
}
