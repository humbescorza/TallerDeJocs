using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OptionScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject NextScene;
    public SceneScript scene;
    public SubmitScript submit;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        if (Gamecontroller.instance.currentScene == null)
        {
            print("No hay escena");
            return;
        }
        if (NextScene == null)
        {
            print("La opcion no tiene camino");
            return;
        }
        submit.sceneToLoad = NextScene;
        submit.Click();
    }
}
