using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGoals : MonoBehaviour
{
    public string nextLevel = "hey";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {


            case "Finish":
                {


                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
} 

