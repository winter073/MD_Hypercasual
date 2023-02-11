using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI woodText;
    private TextMeshProUGUI stoneText;
    // Start is called before the first frame update
    void Start()
    {
        woodText = GetComponent<TextMeshProUGUI>();
        stoneText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateWoodText(PlayerInventory playerInventory) // Updates numbers of wood in UI
    {
        woodText.text = playerInventory.NumberOfWood.ToString();
    }

    public void UpdateStoneText(PlayerInventory playerInventory) // Updates numbers of stone in UI
    {    
        stoneText.text = playerInventory.NumberOfStone.ToString();
        Debug.Log("it work");
    }
}
