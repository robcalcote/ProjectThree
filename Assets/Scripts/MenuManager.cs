using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SinglePlayerMenu;
    public GameObject MultiPlayerMenu;
    
    public void ToggleSinglePlayerMenu()
    {
        SinglePlayerMenu.SetActive(!SinglePlayerMenu.activeSelf);
        MainMenu.SetActive(!MainMenu.activeSelf);
    }
    
    public void ToggleMultiPlayerMenu()
    {
        MultiPlayerMenu.SetActive(!MultiPlayerMenu.activeSelf);
        MainMenu.SetActive(!MainMenu.activeSelf);
    }
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
