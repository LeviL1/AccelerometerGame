using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuButtons : MonoBehaviour
{
  public void PlayGame() 
  {
    SceneManager.LoadScene(1, LoadSceneMode.Single);
  }
  public void QuitGame() 
  {
    Application.Quit();
  }
  public void loadCredits() 
  {
    SceneManager.LoadScene(2, LoadSceneMode.Single);
  }
}
