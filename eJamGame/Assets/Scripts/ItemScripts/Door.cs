using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Door : ItemClass
{
    public Flowchart flowchart;
    int RickyID = 11;
    int BobbyID = 12;
    int FionaID = 13;
    int HaroldID = 14;
    int LouisID = 15;
    int MargaretID = 16;
    int PaulineID = 17;

    public Transform Player;

    public Transform RickyWayPoint;
    public Transform BobbyWayPoint;
    public Transform FionaWayPoint;
    public Transform HaroldWayPoint;
    public Transform LouisWayPoint;
    public Transform MargaretWayPoint;
    public Transform PaulineWayPoint;
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
            Debug.Log("RICKY P BABEEEEE");
            Player.transform.position = RickyWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == BobbyID)
        {
            Player.transform.position = BobbyWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == FionaID)
        {
            Player.transform.position = FionaWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == HaroldID)
        {
            Player.transform.position = HaroldWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == LouisID)
        {
            Player.transform.position = LouisWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == MargaretID)
        {
            Player.transform.position = MargaretWayPoint.transform.position;
        }
        else if (flowchart.GetIntegerVariable("myInt") == PaulineID)
        {
            Player.transform.position = PaulineWayPoint.transform.position;
        }
        yield return new WaitForSeconds(0.1f);
        flowchart.SetIntegerVariable("myInt", 0);
        yield return null;
    }
}
