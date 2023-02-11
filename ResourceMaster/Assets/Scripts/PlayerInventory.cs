using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfWood { get; private set; }
    public int NumberOfStone { get; private set; }

    public UnityEvent<PlayerInventory> OnWoodCollected;
    public UnityEvent<PlayerInventory> OnStoneCollected;

    public void WoodCollected()
    {
        NumberOfWood++;
        OnWoodCollected.Invoke(this);
    }

    public void StoneCollected()
    {
        NumberOfStone++;
        OnStoneCollected.Invoke(this);
    }
}
