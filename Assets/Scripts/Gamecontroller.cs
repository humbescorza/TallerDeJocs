using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public GameObject currentScene;
    public static Gamecontroller instance;
    public GameObject game;
    public Transform prefabScene;
    public Color color;
    public List<NPCBase> characters = new List<NPCBase>();

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            int ran = Random.Range(0, characters.Count);
            Debug.Log(ran);
            Debug.Log(characters[ran]);
            characters[3].RecieveDmg(Random.Range(0.0f, 1.0f));
        }
    }


}
