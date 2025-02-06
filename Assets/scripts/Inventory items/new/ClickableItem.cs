using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableItem : MonoBehaviour
{
   [SerializeField]  public Item itemData;

    private void OnMouseDown()
    {
        EquipmentManager.instance.EquipItem(itemData);
        Destroy(gameObject);
    }
}