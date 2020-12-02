using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCHud : MonoBehaviour
{
    public NPCBase character;
    public Transform lifes;
    public GameObject heartPrefab;
    public List<Image> hearts = new List<Image>();
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<NPCBase>();
        lifes = transform.Find("Lifes");

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHearts()
    {
        for (int i = 0; i < character.maxLifes; i++)
        {
            hearts.Add(Instantiate(heartPrefab, lifes).GetComponent<Image>());
        }
    }
    public void UpdateLife()
    {
        float decimalLife = character.currentLifes % 1;
        int entireLifes =(int)(character.currentLifes - decimalLife);
        int heartsleft = character.maxLifes - (entireLifes+1);

        for (int i = 0; i < entireLifes; i++)
        {
            hearts[i].fillAmount = 1;           
        }

        if (entireLifes != character.maxLifes)
        {
            hearts[entireLifes].fillAmount = decimalLife;
        }

        if (heartsleft < 1)
        {
            return;
        }

        for (int i = 0; i < heartsleft; i++)
        {
            hearts[entireLifes+1+i].fillAmount = 0;
        }
    }
}
