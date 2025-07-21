using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Player Has Died");
                    break;


                }

            case "Finish":
                {


                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}

