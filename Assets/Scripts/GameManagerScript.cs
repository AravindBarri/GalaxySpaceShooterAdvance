using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    //if the game is over then press space to respawn the player
    //else the game over is in inactive

    public bool GameOver = false;
    public GameObject player;
    public UIManager Uiobject;

    void Start()
    {
        Uiobject = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //gameover screen to be inactive and player has to respawn
                Instantiate(player, Vector3.zero, Quaternion.identity);
                GameOver = false;
                Uiobject.HideGameOverScreen();
            }
        }
        else
        {
            Uiobject.ShowGameOverScreen();
        }
    }
}
