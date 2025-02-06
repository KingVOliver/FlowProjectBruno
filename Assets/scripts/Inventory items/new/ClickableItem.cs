using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    public Item itemData; // Reference to item data

    private void OnMouseDown()
    {
        EquipmentManager.instance.EquipItem(itemData);
        Destroy(gameObject); // Remove the item from the world
    }
}