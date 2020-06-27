using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeObject : ItemClass
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Fake";
        ID = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override IEnumerator Interact()
    {
        //make flowchart do shit


        //event handler idk


        return base.Interact();
    }
}
