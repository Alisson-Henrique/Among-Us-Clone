using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject optionsMainMenu,createGameOptions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enterMainMenu()
    {
        mainMenu.SetActive(false);
        optionsMainMenu.SetActive(true);
    }
    public void exitMainMenu()
    {
        optionsMainMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void enterCreateGame()
    {
        optionsMainMenu.SetActive(false);
        createGameOptions.SetActive(true);  
    }
    public void exitCreateGame()
    {
        optionsMainMenu.SetActive(true);
        createGameOptions.SetActive(false);
    }
    public void navLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
