using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectorClick : MonoBehaviour , IPointerClickHandler
{
    public GameObject characterSelectorHud;
    public CharacterSelectorManager charManager;
    public Item currentItem;
    // Start is called before the first frame update
    void Start()
    {
        characterSelectorHud = transform.parent.parent.Find("CharacterSelectorHud").gameObject;
        charManager = characterSelectorHud.GetComponent<CharacterSelectorManager>();
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
        characterSelectorHud.SetActive(true);
        charManager.selectedItem = currentItem;
    }
}
