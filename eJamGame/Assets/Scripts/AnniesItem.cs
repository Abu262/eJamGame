using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AnniesItem : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        flowchart.SetIntegerVariable("myInt", 2);
        flowchart.ExecuteBlock("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
