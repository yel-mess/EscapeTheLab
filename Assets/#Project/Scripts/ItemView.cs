using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

// responsible for carrying data, visual references, on click action and initial state for injecting item data.
public class ItemView : MonoBehaviour
{
    public Button button;
    public Image ItemIcon;

    private ItemData itemData;

    public void InitItem(ItemData item) {
        this.itemData = item;
        ItemIcon.sprite = itemData.icon;
        
        button.onClick.AddListener(ButtonClicked);
    }

    private void ButtonClicked()
    {
        Debug.Log(itemData.name);
    }
}
