using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubmitScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject sceneToLoad;
    public SceneScript sceneScript;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Click();
        }
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Click();
    }
    public void Click()
    {
        if ((sceneScript.currentText == sceneScript.texts.Count - 1) && !sceneScript.choose)
        {
            GameObject destroyed = Instantiate(Gamecontroller.instance.currentScene);
            Gamecontroller.instance.currentScene = sceneToLoad;
            Instantiate(sceneToLoad, Gamecontroller.instance.game.transform);
            Destroy(Gamecontroller.instance.game.transform.GetChild(0).gameObject);
            Destroy(destroyed);
        }
        if (sceneScript.currentText >= sceneScript.texts.Count)
        {
            print("texto fuera de rango");
            return;
        }
        if (sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().state == TextState.ended)
        {
            if (sceneScript.state == State.Chosing)
            {
                if (sceneToLoad == null)
                    return;
                GameObject destroyed = Instantiate(Gamecontroller.instance.currentScene);
                Gamecontroller.instance.currentScene = sceneToLoad;
                Instantiate(sceneToLoad, Gamecontroller.instance.game.transform);
                Destroy(Gamecontroller.instance.game.transform.GetChild(0).gameObject);
                Destroy(destroyed);
            }
            else if (sceneScript.state == State.Texting)
            {
                sceneScript.NextText();
            }
        }
        else if(sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().state == TextState.paused)
        {
            sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().state = TextState.typing;
        }
        else if (sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().state == TextState.typing)
        {
            sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().state = TextState.skipping;
            sceneScript.texts[sceneScript.currentText].gameObject.GetComponent<TextManagerScript>().Skip();
        }
    }


}
