using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] livesImages;
    public Image presentImage;
    public int score;
    public Text scoreText;
    public GameObject GameoverScreen;
    public void UpdateLives(int lives)
    {
        presentImage.sprite = livesImages[lives];
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
    public void ShowGameOverScreen()
    {
        //to show gameover screen
        GameoverScreen.SetActive(true);

    }
    public void HideGameOverScreen()
    {
        //to hide the GameOver screen
        GameoverScreen.SetActive(false);
    }
}
