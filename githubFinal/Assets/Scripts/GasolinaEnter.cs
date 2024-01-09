using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasolinaEnter : MonoBehaviour
{
    public CombustiblePlayer combustiblePlayer;

    private void OnTriggerEnter(Collider other)
    {
        print("Collision detectada" + other.gameObject.tag);
        combustiblePlayer.aumentarCombustible();
        desactivar();
    }
    public void activar()
    {
        gameObject.SetActive(true);
    }
    public void desactivar()
    {
        gameObject.SetActive(false);
    }
}
