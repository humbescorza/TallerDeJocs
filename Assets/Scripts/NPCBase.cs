using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Pasive
{
    Gunner,
    Old,
    Strong,
    LessInv,
    Cocina,
    Impulsive,
    Agile,
    Black
}
public class NPCBase : MonoBehaviour
{
    public new string name;
    public int maxLifes;
    public float currentLifes;
    public InventoryScript inventory;
    public int slotCount;
    public NPCHud hud;
    public List<Pasive> pasives = new List<Pasive>();
    // Start is called before the first frame update
     public void Start()
    {
        inventory = transform.Find("Inventory").GetComponent<InventoryScript>();
        hud = GetComponent<NPCHud>();
        maxLifes = 3;
        slotCount = 3;

        if (CheckPasive(Pasive.Old))
        {
            maxLifes = 2;
        }
        if (CheckPasive(Pasive.LessInv))
        {
            slotCount = 2;
        }

        currentLifes = maxLifes;
        hud.SetHearts();
        inventory.SetSlots();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public bool CheckPasive(Pasive pasive)
    {
        foreach (Pasive pas in pasives)
        {
            if (pas == pasive)
            {
                return true;
            }
        }
        return false;
    }

    public void RecieveDmg(float dmg)
    {
        if (currentLifes <= 0 )
        {
            currentLifes = 0;
            Debug.Log("Se mamut " + name);
        }
        currentLifes -= dmg;
        hud.UpdateLife();
    }
}
