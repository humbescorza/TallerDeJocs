using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greyson : NPCBase
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Greyson";
        pasives.Add(Pasive.Old);
        pasives.Add(Pasive.Gunner);
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
