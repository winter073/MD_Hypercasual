using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.WoodCollected();
            gameObject.SetActive(false);
            killTree();
        }

        IEnumerator killTree()
        {
            yield return new WaitForSeconds(2f);
            Debug.Log("yay");
            gameObject.SetActive(true);
        }
    }
}
