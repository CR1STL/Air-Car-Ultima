using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons_Scr : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Main_Menu_0()
    {
        SceneManager.LoadScene(0);
    }
    public void Controls_1()
    {
        SceneManager.LoadScene(1);
    }
    public void About_Game_2()
    {
        SceneManager.LoadScene(2);
    }
    public void Authors_3()
    {
        SceneManager.LoadScene(3);
    }
    public void Game_Settings_4()
    {
        SceneManager.LoadScene(4);
    }
    public void Easy_Difficulty_5()
    {
        SceneManager.LoadScene(5);
    }
    public void Medium_Difficulty_6()
    {
        SceneManager.LoadScene(6);
    }
    public void Hard_Difficulty_7()
    {
        SceneManager.LoadScene(7);
    }
    public void Quit()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}