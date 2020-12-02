using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectorManager : MonoBehaviour
{
    public Item selectedItem;
    public List<GameObject> characters = new List<GameObject>();
    public SceneScript currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = transform.parent.parent.parent.GetComponent<SceneScript>();

        if (currentScene.greyson)
            characters[0].SetActive(true);
        else
            characters[0].SetActive(false);

        if (currentScene.ashley)
            characters[1].SetActive(true);
        else
            characters[1].SetActive(false);

        if (currentScene.keanu)
            characters[2].SetActive(true);
        else
            characters[2].SetActive(false);

        if (currentScene.nora)
            characters[3].SetActive(true);
        else
            characters[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
