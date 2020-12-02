using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public NPCBase owner;
    public Slot currentSlot;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseItem()
    {

    }

    public void SetOwner()
    {
        owner = currentSlot.inventory.character;
    }
    
}
