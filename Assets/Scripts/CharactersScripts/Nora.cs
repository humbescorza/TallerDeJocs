using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nora : NPCBase
{
    // Start is called before the first frame update
    void Start()
    {
        pasives.Add(Pasive.Agile);
        pasives.Add(Pasive.Black);
        base.Start();
        name = "Nora";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
