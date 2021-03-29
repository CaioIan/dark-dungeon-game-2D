using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCtrl_3 : MonoBehaviour
{
    public static GameCtrl_3 insta;



    public GameObject Menu;

    public GameObject ComoJogar;

    public int totalscore;
    public Text scoretext;

    public GameObject NextLevelPainel;
    public GameObject player;

    //Strings nextlevel






    // Start is called before the first frame update

    void Start()
    {
        insta = this;

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void RestartGameBarraJogar(string lvlName)
    {
        SceneManager.LoadScene(lvlName);


    }

    public void RestartLevel3(string lvlName3)
    {
        SceneManager.LoadScene("level_3");


    }


    public void ShowComoJogar()
    {
        ComoJogar.SetActive(true);
    }

    public void ShowComoJogarFalse()
    {
        ComoJogar.SetActive(false);

    }

    public void MenuFalse3()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ShowMenu()
    {
        Menu.SetActive(true);
    }



    public void UpdateScoreText()
    {
        scoretext.text = totalscore.ToString();

    }


    public void NextLevel()
    {
        if (totalscore == 25)
        {
            NextLevelPainel.SetActive(true);
            player.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void SairDoJogo()
    {
        SceneManager.LoadScene("Tela_Inicial");
    }



    public void ContinuarButton()
    {
        SceneManager.LoadScene("level_4");
        Time.timeScale = 1;
    }

    public void ReiniciarButton()
    {
        SceneManager.LoadScene("level_3");
        GameCtrl_3.insta.MenuFalse3();
    }

}