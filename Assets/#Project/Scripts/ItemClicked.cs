using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClicked : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public GameObject playerPrefab;
    public static ItemData lastSelectedItem;
    PlayerController playerController;
    public static bool usingItem = false;
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
        //playerPrefab.GetComponent<PlayerController>().isMoving = false;
        Debug.Log(GetComponent<ItemView>().itemData.itemName);
        print(gameObject);
    }
    public void OnSelect(BaseEventData eventData){
        usingItem = true;
        lastSelectedItem = EventSystem.current.currentSelectedGameObject.GetComponent<ItemView>().itemData;
    }
    public void OnDeselect(BaseEventData eventData){
        usingItem = false;
        //playerPrefab.GetComponent<PlayerController>().lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //playerPrefab.GetComponent<PlayerController>().isMoving = true;
    }
}
