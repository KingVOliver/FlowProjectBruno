using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToBuymoney : MonoBehaviour
{
    [SerializeField] public int CurrencyAmount = 10;  
    

     

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
                    playerMoney.AddMoney(CurrencyAmount); 
                    
}
            
        
    
    
}
        }
    }
}