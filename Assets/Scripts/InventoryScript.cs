using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    public List<Slot> slots = new List<Slot>();
    public GameObject slotPrefab;
    public NPCBase character;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSlots()
    {
        character = transform.parent.GetComponent<NPCBase>();
        for (int i = 0; i < character.slotCount; i++)
        {
            slots.Add(Instantiate(slotPrefab,character.inventory.transform).GetComponent<Slot>());
        }
    }
    public void AddItem(Item item)
    {
        for (int i = 0; i < slots.Count; i++)
        {

            if (slots[i].currentItem == null)
            {
                slots[i].currentItem = item;
                item.currentSlot = slots[i];
                item.SetOwner();
                slots[i].gameObject.GetComponent<Image>().sprite = item.gameObject.GetComponent<Image>().sprite;

                return ;
            }
            else if (i+1 == slots.Count)
            {
                Debug.Log("Inventario lleno, no se puede añadir item");
            }
        }
        
    }
}
