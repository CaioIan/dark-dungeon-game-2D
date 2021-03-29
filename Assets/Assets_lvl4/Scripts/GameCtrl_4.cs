using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCtrl_4 : MonoBehaviour
{
    public static GameCtrl_4 ins;



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
        ins = this;

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void RestartGameBarraJogar(string lvlName)
    {
        SceneManager.LoadScene(lvlName);


    }

    public void RestartLevel4(string lvlName3)
    {
        SceneManager.LoadScene("level_4");


    }


    public void ShowComoJogar()
    {
        ComoJogar.SetActive(true);
    }

    public void ShowComoJogarFalse()
    {
        ComoJogar.SetActive(false);

    }

    public void MenuFalse4()
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
        if (totalscore == 35)
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
        SceneManager.LoadScene("level_5");
        Time.timeScale = 1;
    }

    public void ReiniciarButton()
    {
        SceneManager.LoadScene("level_4");
        GameCtrl_4.ins.MenuFalse4();
    }

}