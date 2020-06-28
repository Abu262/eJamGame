using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FireEscape : ItemClass
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        name = "Fire Escape";
        ID = 18;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override IEnumerator Interact()
    {
        flowchart.SetIntegerVariable("myInt", ID);
        flowchart.ExecuteBlock("Start");

        while (flowchart.GetIntegerVariable("myInt") == ID)
        {
            yield return null;
        }
        yield return null;
    }
}
