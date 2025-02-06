using UnityEngine;

public enum ItemType { Helmet, Armor, Weapon, Potion } 
public enum PotionEffect { Heal, RestoreAtack, SpeedBoost } 

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public ItemType itemType;
    public bool isConsumable;
    public PotionEffect potionEffect; 
    public int effectAmount;
}