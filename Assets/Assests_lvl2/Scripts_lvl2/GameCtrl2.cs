using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCtrl2 : MonoBehaviour
{
    public static GameCtrl2 inst;



    public GameObject menu;

    public GameObject comoJogar;

    public int TotalScore;
    public Text ScoreText;

    public GameObject nextLevelPainel;

    //Strings nextlevel
    
    




    // Start is called before the first frame update

    void Start()
    {
        inst = this;

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
        ScoreText.text = TotalScore.ToString();

    }

   
    public void NextLevel()
    {
        if (TotalScore == 15)
        {
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
        SceneManager.LoadScene("level_3");
        Time.timeScale = 1;
    }

    public void ReiniciarButton()
    {
        SceneManager.LoadScene("level_2");
        GameCtrl2.inst.MenuFalse();
    }

}


