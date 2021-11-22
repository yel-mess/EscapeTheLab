using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public GameObject playerPrefab;
    public static ItemData lastSelectedItem;
    PlayerController playerController;
    void Start(){
        #region 
        //player = Instantiate (Resources.Load ("shuffe(move)_0")) as GameObject;
        //player = GetComponent<GameObject>();
        //playerPrefab = Resources.Load("shuffe(move)_0") as GameObject;
        //var player = GameObject.Instantiate(playerPrefab, transform.position, transform.rotation);
        #endregion
        playerPrefab = GameObject.FindGameObjectWithTag("Player");
    }
    public void Click(){
        playerPrefab.GetComponent<PlayerController>().isMoving = false;
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
    }
    public void OnSelect(BaseEventData eventData){
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
    public void OnDeselect(BaseEventData eventData){
        playerPrefab.GetComponent<PlayerController>().isMoving = true;
    }
}
