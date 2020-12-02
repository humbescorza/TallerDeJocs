using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ashley : NPCBase
{
    
    // Start is called before the first frame update
    void Start()
    {
        pasives.Add(Pasive.Cocina);
        pasives.Add(Pasive.Impulsive);
        base.Start();
        name = "Ashley";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
