using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoView : MonoBehaviour
{
    public Image icon;
    public Text nameText;
    public Text typeText;
    public Text descriptionText;

    public void Init(ItemData data)
    {
        icon.sprite = data.icon;
        nameText.text = data.name;
        descriptionText.text = "Description : " + data.description;

        switch (data.type)
        {
            case ItemType.IDCard1: typeText.text    = "Type : Personnal ID Card"; break;
            case ItemType.TinCans: typeText.text = "Type : Tin Cans"; break;
            case ItemType.IDCard2: typeText.text = "Type : ID Card"; break;
            case ItemType.UVLamp: typeText.text = "Type : UV Lamp"; break;
            case ItemType.Screwdriver: typeText.text = "Type : Screwdriver"; break;
            case ItemType.Batteries: typeText.text = "Type : Batteries"; break;

        }
    }
}
