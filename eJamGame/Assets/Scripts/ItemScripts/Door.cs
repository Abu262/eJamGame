using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
public class Door : ItemClass
{

    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        name = "Condemn a Suspect";
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


        if (flowchart.GetIntegerVariable("myInt") == 1)
        {
            SceneManager.LoadScene(2);

        }
        else if (flowchart.GetIntegerVariable("myInt") == 2)
        {
            SceneManager.LoadScene(3);
        }


        flowchart.SetIntegerVariable("myInt", 0);
        yield return null;
    }
}
