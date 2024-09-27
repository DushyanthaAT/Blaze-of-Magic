using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject QuitPopOut;
    public GameObject pauseFirstButton,QuitFirstButton,pauseClosedButton;
    public AudioSource Audio;

    void start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            pauseMenuActive();
           
        }

        
    }
    private void pauseMenuActive()
    {
        Audio.Pause();
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
    }

    public void resume()
    {
        Audio.Play();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void quit()
    {
        QuitPopOut.SetActive(true);
        quitPopOutMenu();
    }

    private void quitPopOutMenu()
    {
        
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(QuitFirstButton);
    }
    
    public void No()
    {
        QuitPopOut.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseClosedButton);
    }

    public void Yes()
    {
        SceneManager.LoadScene("BoM_Map");
    }
   
   

}
