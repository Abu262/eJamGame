using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowItem :ItemClass
{

    // Start is called before the first frame update
    void Start()
    {
        name = "flow";    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override IEnumerator Interact()
    {
        //make flowchart do shit


        //event handler idk


        Fungus.Flowchart.BroadcastFungusMessage("text");
        yield return null;
    }
}
