using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    
    private int coinCounter = 0;
    public int _health = 3;
    public float _maxHealth = 3;
    public Transform respawnPoint;
    private PlayerUIController _playerUIController;
    // Start is called before the first frame update
    private void Start()
    {
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.UpdateHealth(_health, _maxHealth);

    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    _health--;
                    if (_health <= 0) 
                    { 
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }

     

                    else
                    {

                        transform.position = respawnPoint.position;

                    }
                    _playerUIController.UpdateHealth(_health, _maxHealth); 
                    //string thisLevel = SceneManager.GetActiveScene().name;
                    //SceneManager.LoadScene(thisLevel);
                    //Debug.Log("Player Has Died");
                    break;


                }

            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position; 
                    break;
                }

                   

            case "Coin": 
                {
                coinCounter++;
                Destroy(collision.gameObject);
                    break; 
                
                
                }

            case "Health":
                {

                    if (_health < 3)
                    {

                        _health++;
                        Destroy(collision.gameObject);
                        _playerUIController.UpdateHealth(_health, _maxHealth);

                    }
                    break;

                  


                }

            case "Finish":
                {

                    string nextLevel= collision.transform.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}

