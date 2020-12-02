using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keanu : NPCBase
{
    // Start is called before the first frame update
    void Start()
    {
        pasives.Add(Pasive.LessInv);
        pasives.Add(Pasive.Strong);
        base.Start();
        name = "Keanu";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
