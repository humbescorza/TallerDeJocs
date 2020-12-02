using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum State
{
    Texting,
    Chosing
}
public class SceneScript : MonoBehaviour
{
    public bool choose;
    public int currentText;
    public List<Text> texts = new List<Text>();
    public State state;
    public GameObject options;
    void Start()
    {
        state = State.Texting;
        foreach (Transform child in transform.Find("Canvas").Find("Texts"))
        {
            texts.AddRange(child.GetComponents<Text>());
        }
        texts[currentText].gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
    public void NextText()
    {
        if (currentText >= texts.Count)
        {
            print("texto fuera de rango");
            return;
        }
        texts[currentText].gameObject.SetActive(false);
        currentText++;

       
        if (currentText >= texts.Count)
        {
            print("No hay mas textos");
            return;
        }
        texts[currentText].gameObject.SetActive(true);
        if ((currentText >= texts.Count - 1) && (choose))
        {
            state = State.Chosing;
            options.SetActive(true);

        }
    }
}
