using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class Bobby : ItemClass
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        name = "Bobby";
        ID = 11;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override IEnumerator Interact()
    {
        flowchart.SetIntegerVariable("myInt", 11);
        flowchart.ExecuteBlock("Start");

        while (flowchart.GetIntegerVariable("myInt") == 11)
        {
            yield return null;
        }

        yield return null;
    }
}