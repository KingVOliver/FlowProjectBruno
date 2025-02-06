using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentManager : MonoBehaviour
{
    public static EquipmentManager instance;
    public Image equippedItemIcon; // UI icon to display equipped item

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void EquipItem(Item item)
    {
        equippedItemIcon.sprite = item.icon;
        equippedItemIcon.enabled = true;
        Debug.Log("Equipped: " + item.itemName);
    }
void Update()
{
    if (Input.GetMouseButtonDown(1)) // Right-click to unequip
    {
        equippedItemIcon.sprite = null;
        equippedItemIcon.enabled = false;
        Debug.Log("Unequipped item.");
    }
}

}