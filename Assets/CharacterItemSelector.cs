using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CharacterItemSelector : MonoBehaviour , IPointerClickHandler
{
    public int charInt;
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Click();
    }

    public void Click()
    {
        item = transform.parent.parent.GetComponent<CharacterSelectorManager>().selectedItem;

        Gamecontroller.instance.characters[charInt].inventory.AddItem(item);
    }
}
