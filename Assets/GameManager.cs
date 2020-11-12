using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameObjects;
    private bool game_Started;
    private GameObject main_Panel;
    public Text scr_Txt;
    public int scr;
    void Start()
    {
        main_Panel = GameObject.Find("MainPanel");
        game_Started = false;
        scr_Txt.text = "";
    }

    private void Update()
    {
        if(!game_Started)
        {
            if(Input.GetMouseButtonDown(0))
            {
                game_Started = true;
                main_Panel.SetActive(false);
                gameObjects.SetActive(true);
                scr_Txt.text = "0";
            }
        }
    }

    public void ChangeScore()
    {
        scr_Txt.text = scr.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
