using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image HeartImage;
    // Start is called before the first frame update
    void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
       
        
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        HeartImage.fillAmount = currentHealth/maxHealth;
    }
}
