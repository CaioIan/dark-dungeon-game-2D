using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    
    
    public GameObject menu;

    public GameObject comoJogar;

    public int totalScore;
    public Text scoreText;

    //Strings nextlevel
   


    public GameObject nextLevelPainel;
    public GameObject player;
   
    // Start is called before the first frame update

    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void RestartGameBarraJogar(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        
        
    }

    public void RestartLevel2(string lvlName2)
    {
        SceneManager.LoadScene(lvlName2);


    }
    public void RestartLevel3(string lvlName3)
    {
        SceneManager.LoadScene(lvlName3);


    }


    public void ShowComoJogar()
    {
        comoJogar.SetActive(true);
    }

    public void ShowComoJogarFalse()
    {
        comoJogar.SetActive(false);
        
    }

    public void MenuFalse()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
    }



    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
        
    }

    public void NextLevelPainel()
    {
        if (totalScore == 10)
        {
            player.SetActive(false);
            
            
                
            nextLevelPainel.SetActive(true);
            Time.timeScale = 0;

        }
    }

    
    public void SairDoJogo()
    {
        SceneManager.LoadScene("Tela_Inicial");
    }

    public void ContinuarButton()
    {
        SceneManager.LoadScene("level_2");
        Time.timeScale = 1;
    }

    public void ReiniciarButton()
    {
        SceneManager.LoadScene("level_1");
        GameController.instance.MenuFalse();
    }

   public void Exit()
    {
        Application.Quit();
    }



}
