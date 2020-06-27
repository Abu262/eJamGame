using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AnniesItem : ItemClass
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        name = "mushroom";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator test()
    {
        if (flowchart.GetFloatVariable("someInt") > 3)
        {
        }
        yield return null;
    }

    public override IEnumerator Interact()
    {
        Debug.Log("This is an override!");

        flowchart.SetIntegerVariable("myInt", 2);
        flowchart.ExecuteBlock("Start");

        while (flowchart.GetIntegerVariable("myInt") == 2)
        {
            yield return null;
        }

        yield return null;
    }
}
