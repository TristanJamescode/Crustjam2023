using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads the next scene (aka the main game)
    }

    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); //loads the next scene (aka the main game)
    }

    public void Fuckitgoback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); //loads the next scene (aka the main game)
    }

    public void QuitGame()
    {
        Application.Quit(); //for the actual game
        UnityEditor.EditorApplication.isPlaying = false; //for the unity player
    }

    public void Backtothemainmenufuckboy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //loads the next scene (aka the main game)
    }

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
