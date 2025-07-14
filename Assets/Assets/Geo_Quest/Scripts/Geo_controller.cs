using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Geo_controller : MonoBehaviour
{
    string x = "Hello ";
    int var = 3;
    private Rigidbody2D rb;
    public int speed = 10;
    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log("Hello World");
        //string y = "World";
        //Debug.Log(x+y);
      
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log(xInput);
        //rb.velocity = Vector2.left;
        //rb.velocity = new Vector2 (xInput, rb.velocity.y);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

        //Debug.Log(var);
        //var++;
        //transform.position += new Vector3(0.005f, 0, 0);

        //if (Input.GetKeyDown(KeyCode.W))
        

           //transform.position += new Vector3(0, 1, 0);
        

        //if (Input.GetKeyDown(KeyCode.S))
        
            //transform.position += new Vector3(0, -1, 0);
        

        //if (Input.GetKeyDown(KeyCode.D))
        
            //transform.position += new Vector3(1, 0, 0);

        

        //if (Input.GetKeyDown(KeyCode.A))
    
            //transform.position += new Vector3(-1, 0, 0);
        

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
        //Debug.Log("Hit");
    }
}


