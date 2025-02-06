using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private Text text;
private void Start ()
{
text = GetComponent<Text>();
}

private void Update ()
{
    string[] temp = text.text.Split (":");
    text.text = temp [0] + ":" + PlayerPrefsManager.money;
}



}
