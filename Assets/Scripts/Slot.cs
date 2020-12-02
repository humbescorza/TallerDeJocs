using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Item currentItem;
    public InventoryScript inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = transform.parent.GetComponent<InventoryScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
