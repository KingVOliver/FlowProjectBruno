using UnityEngine;

public enum ItemType { Helmet, Armor, Weapon, Potion } 
public enum PotionEffect { Heal, RestoreAtack, SpeedBoost } 

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
   [SerializeField]  public string itemName;
    [SerializeField] public Sprite icon;
   [SerializeField]  public ItemType itemType;
    [SerializeField] public bool isConsumable;
    [SerializeField] public PotionEffect potionEffect; 
    [SerializeField] public int effectAmount;
}