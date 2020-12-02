using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TextState
{
    typing,
    paused,
    skipping,
    ended
}
public class TextManagerScript : MonoBehaviour
{
    public int position;
    public float speed;
    public Sprite newImage;
    public float currentTime;
    public string container;
    public Text text;
    public TextState state;
    public List<AudioClip> clips = new List<AudioClip>();
    public List<GameObject> toActive = new List<GameObject>();
    public List<GameObject> toUnActive = new List<GameObject>();
    public List<char> pausa = new List<char>();
    // Start is called before the first frame update
    void OnEnable()
    {
        text = GetComponent<Text>();
        Active();
        UnActive();
        SetImage();
        text.color = Gamecontroller.instance.color;
    }
    void Start()
    {
        speed = 60;
        text = GetComponent<Text>();
        text.color = Gamecontroller.instance.color;
        container = text.text;
        text.text = "";
        //pausa.Add('.');
    }

    void Update()
    {
        if (state == TextState.typing)
        {
            currentTime += Time.deltaTime * speed;
            if (currentTime >= 1)
            {
                currentTime = 0;
                text.text += container[position];
                foreach (char c in pausa)
                {
                    if (container[position] == c)
                    {
                        state = TextState.paused;
                        if ((position + 1) >= container.Length)
                        {
                            state = TextState.ended;
                        }
                    }
                }
                position++;
                if ((position) >= container.Length)
                {
                    state = TextState.ended;
                }
            }
        }
    }
    public void Skip()
    {
        bool type = true;
        while (type)
        {
            foreach (char c in pausa)
            {
                if (container[position] == c)
                {
                    state = TextState.paused;
                    if ((position + 1) >= container.Length)
                    {
                        state = TextState.ended;
                    }
                    type = false;
                }
            }
            text.text += container[position];
            position++;
            if (position >= container.Length)
            {
                state = TextState.ended;
                type = false;
            }
        }
    }
    public void SetImage()
    {
        if (newImage == null)
            return;
        transform.parent.parent.Find("Imagen de Fondo").GetComponent<Image>().sprite = newImage;
    
    }
    public void Active()
    {
        foreach (GameObject go in toActive)
        {
            if (go == null)
                return;
            go.SetActive(true);
        }
    }
    public void UnActive()
    {
        foreach (GameObject go in toUnActive)
        {
            if (go == null)
                return;
            go.SetActive(false);
        }
    }
}
