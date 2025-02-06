using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToBuy : MonoBehaviour
{
    public int moneyAmount = 10;  
    public Camera playerCamera;
    public GameObject shopObject;
    public GameObject CloseObject;

     public ShopManager shopManager;

    private void OnMouseDown()
    {
       
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
               
                PlayerPrefsManager playerMoney = FindObjectOfType<PlayerPrefsManager>(); 
                if (playerMoney != null)
                {
                    playerMoney.AddMoney(moneyAmount); 
                    
}
            }
        }
        if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.gameObject == shopObject)
                {
                    
                    shopManager.OpenShop();
                }
                if (hit.collider != null && hit.collider.gameObject == CloseObject)
                {
                    
                    shopManager.CloseShop();
                }
    }
    }
}