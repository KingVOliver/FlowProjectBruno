using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    [SerializeField] public const string Currency = "Currency";
    [SerializeField] public static int money = 0;
    public void AddMoney(int amount)
    {
        money += amount;
    }

    public void Start()
    {
        money = PlayerPrefs.GetInt ("Currency");
    }
    
        
    
}
