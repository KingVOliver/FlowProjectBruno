using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    [SerializeField] public GameObject shopPanel; 
    [SerializeField] public Text currencyText;
    [SerializeField] public int playerCurrency = 100; 

    
    [SerializeField] public int HealthPrice = 10;
    [SerializeField] public int AtackPrice = 10;

    [SerializeField] public int SpeedPrice = 10;

    void Start()
    {
        
        shopPanel.SetActive(false);
        UpdateCurrencyDisplay();
    }

   
    public void UpdateCurrencyDisplay()
    {
        currencyText.text = "Currency: " + playerCurrency.ToString();
    }


    public void PurchaseHealth()
    {
        if (playerCurrency >= HealthPrice)
        {
            playerCurrency -= HealthPrice;
            Debug.Log("Health item purchased!");
            UpdateCurrencyDisplay();
        }
        else
        {
            Debug.Log("Not enough currency for Health!");
        }
    }

   
    public void PurchaseAtack()
    {
        if (playerCurrency >= AtackPrice)
        {
            playerCurrency -= AtackPrice;
            Debug.Log("atack purchased!");
            UpdateCurrencyDisplay();
        }
        else
        {
            Debug.Log("Not enough currency for atack!");
        }
    }
     public void PurchaseSpeed()
    {
        if (playerCurrency >= AtackPrice)
        {
            playerCurrency -= AtackPrice;
            Debug.Log("Speed purchased!");
            UpdateCurrencyDisplay();
        }
        else
        {
            Debug.Log("Not enough currency for Speed!");
        }
    }

   
    public void OpenShop()
    {
        shopPanel.SetActive(true);
    }

   
    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }
}
