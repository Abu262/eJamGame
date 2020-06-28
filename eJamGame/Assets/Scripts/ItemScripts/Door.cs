using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Door : ItemClass
{
    public Flowchart flowchart;
    public Flowchart Rickyflowchart;
    public Flowchart Bobbyflowchart;
    public Flowchart Fionaflowchart;
    public Flowchart Haroldflowchart;
    public Flowchart Louisflowchart;
    public Flowchart Margaretflowchart;
    public Flowchart Paulineflowchart;
    int RickyID = 11;
    int BobbyID = 12;
    int FionaID = 13;
    int HaroldID = 14;
    int LouisID = 15;
    int MargaretID = 16;
    int PaulineID = 17;

    // Start is called before the first frame update
    void Start()
    {
        name = "Door To Bedroom";
        ID = 10;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override IEnumerator Interact()
    {
        Debug.Log("This is a door!");

        flowchart.SetIntegerVariable("myInt", ID);
        flowchart.ExecuteBlock("Start");

        while (flowchart.GetIntegerVariable("myInt") == ID)
        {
            yield return null;
        }


        if (flowchart.GetIntegerVariable("myInt") == RickyID)
        {
            Rickyflowchart.ExecuteBlock("Start");

        }
        else if (flowchart.GetIntegerVariable("myInt") == BobbyID)
        {
            Bobbyflowchart.ExecuteBlock("Start");
        }
        else if (flowchart.GetIntegerVariable("myInt") == FionaID)
        {
            Fionaflowchart.ExecuteBlock("Start");
        }
        else if (flowchart.GetIntegerVariable("myInt") == HaroldID)
        {
            Haroldflowchart.ExecuteBlock("Start");
        }
        else if (flowchart.GetIntegerVariable("myInt") == LouisID)
        {
            Louisflowchart.ExecuteBlock("Start");
        }
        else if (flowchart.GetIntegerVariable("myInt") == MargaretID)
        {
            Margaretflowchart.ExecuteBlock("Start");
        }
        else if (flowchart.GetIntegerVariable("myInt") == PaulineID)
        {
            Paulineflowchart.ExecuteBlock("Start");
        }


        while (flowchart.GetIntegerVariable("myInt") != 0)
        {
            yield return null;
        }

        yield return new WaitForSeconds(0.1f);
        flowchart.SetIntegerVariable("myInt", 0);
        yield return null;
    }
}
