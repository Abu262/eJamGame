using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class SphereItem : ItemClass
{
    [System.NonSerialized()]
    private MonoBehaviour _owner;
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    
    name = "Sphere";
        ID = 0;
    }


    IEnumerator test()
    {
        Debug.Log("Jeppy");
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
