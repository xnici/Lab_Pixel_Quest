using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startScene;

    public void LoadLevel()
    { 
        SceneManager.LoadScene(startScene);
    
    }

    public void QuitGame()
    {
        Application.Quit(); 

    }
    // Start is called before
    // the first frame update
    
}
