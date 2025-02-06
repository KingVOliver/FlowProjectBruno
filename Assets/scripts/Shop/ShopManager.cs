using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public GameObject shopPanel; 
    public Text currencyText;
    public int playerCurrency = 100; 

    
    public int HealthPrice = 50;
    public int AtackPrice = 30;

    public int SpeedPrice = 20;

    void Start()
    {
        
        shopPanel.SetActive(false);
        UpdateCurrencyDisplay();
    }
public const string Currency = "Currency";
    public static int money = 0;
    public void AddMoney(int amount)
    {
        money += amount;
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
