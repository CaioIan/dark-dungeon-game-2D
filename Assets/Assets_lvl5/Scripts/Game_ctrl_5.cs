using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_ctrl_5 : MonoBehaviour
{
    public static Game_ctrl_5 instan;



    public GameObject Menu;

    public GameObject ComoJogar;

    public int totalscore;
    public Text scoretext;

    public GameObject NextLevelPainel;
    public GameObject player;
    public GameObject Redes;

    //Strings nextlevel






    // Start is called before the first frame update

    void Start()
    {
        instan = this;

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void RestartGameBarraJogar(string lvlName)
    {
        SceneManager.LoadScene(lvlName);


    }

    public void RestartLevel5(string lvlName3)
    {
        SceneManager.LoadScene("level_5");


    }


    public void ShowComoJogar()
    {
        ComoJogar.SetActive(true);
    }

    public void ShowComoJogarFalse()
    {
        ComoJogar.SetActive(false);

    }

    public void MenuFalse5()
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
        if (totalscore == 1)
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
        SceneManager.LoadScene("level_6");
        Time.timeScale = 1;
    }

    public void ReiniciarButton()
    {
        SceneManager.LoadScene("level_5");
        Game_ctrl_5.instan.MenuFalse5();
    }

    public void GitHubButton()
    {
        Application.OpenURL("https://github.com/CaioIan");
    }
    public void ShowRedes()
    {
        Redes.SetActive(true);
    }
    public void SairDoGame()
    {
        Application.Quit();
    }

}