using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image HeartImage;
    public TextMeshProUGUI CoinText;
    // Start is called before the first frame update
    void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        CoinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
       
        
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        HeartImage.fillAmount = currentHealth/maxHealth;
    }

    public void UpdateCoin(string newText) 
    {
        CoinText.text = newText;
    
    }
}
