using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        textMeshPro.text = score.ToString() + " POINTS";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Nivel1");
    }
}
