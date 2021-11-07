using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType type;
    public string description;
    public Sprite icon;
}

public enum ItemType {
    IDCard1,
    TinCans,
    IDCard2,
    UVLamp,
    Screwdriver,
    Batteries
}