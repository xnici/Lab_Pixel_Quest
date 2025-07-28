using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource coinSFX;
    public AudioSource checkpointSFX;
    public AudioSource deathSFX;
    public AudioSource heartSFX;

    // Start is called before the first frame update
    public void PlayAudio(string audioName)
    {
        switch (audioName.ToLower())
        {
            case "coin":
                {
                    coinSFX.Play();
                    break;



                }
            case "checkpoint":
                {
                    checkpointSFX.Play();
                    break;
                }
            case "death":
                {
                    deathSFX.Play();
                    break;
                }
            case "heart":
                {
                    heartSFX.Play();
                    break;


                }







        }
    }
    }   
