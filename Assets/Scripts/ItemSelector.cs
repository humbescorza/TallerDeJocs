using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelector : MonoBehaviour
{
    public List<Item> itemsToChoose = new List<Item>();
    public GameObject itemButton;
    public Transform buttonContainer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnItemButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnItemButtons()
    {
        for (int i = 0; i < itemsToChoose.Count; i++)
        {
            GameObject temp = Instantiate(itemButton, buttonContainer);
            temp.GetComponent<SelectorClick>().currentItem = itemsToChoose[i];
            temp.GetComponent<Image>().sprite = itemsToChoose[i].gameObject.GetComponent<Image>().sprite;

        }
    }
}
