using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public List<Item> potions = new List<Item>();
    public Image potionSlotUI;
    public Text potionCountUI;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void AddPotion(Item potion)
    {
        potions.Add(potion);
        UpdatePotionUI();
        Debug.Log($"Picked up {potion.itemName}");
    }

    public void UsePotion()
    {
        if (potions.Count > 0)
        {
            Item potion = potions[0];

            switch (potion.potionEffect)
            {
                case PotionEffect.Heal:
                    PlayerStats.instance.Heal(potion.effectAmount);
                    break;
                case PotionEffect.RestoreAtack:
                    PlayerStats.instance.AtackBoost(potion.effectAmount);
                    break;
                case PotionEffect.SpeedBoost:
                    PlayerStats.instance.SpeedBoost(potion.effectAmount, 5f); // Speed boost for 5 seconds
                    break;
            }

            potions.RemoveAt(0);
            UpdatePotionUI();
        }
        else
        {
            Debug.Log("No potions left!");
        }
    }

    private void UpdatePotionUI()
    {
        if (potions.Count > 0)
        {
            potionSlotUI.sprite = potions[0].icon;
            potionSlotUI.enabled = true;
            potionCountUI.text = potions.Count.ToString();
        }
        else
        {
            potionSlotUI.sprite = null;
            potionSlotUI.enabled = false;
            potionCountUI.text = "";
        }
    }
    void Update()
{
    if (Input.GetMouseButtonDown(1)) // Right-click to use a potion
    {
        UsePotion();
    }
    
    if (Input.GetKeyDown(KeyCode.H)) // Press 'H' to use a potion
    {
        UsePotion();
    }
}
}