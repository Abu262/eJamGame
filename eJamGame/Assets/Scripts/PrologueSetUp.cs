using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class PrologueSetUp : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        flowchart.ExecuteBlock("Start");
        flowchart.SetBooleanVariable("pDone", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("pDone") == true)
        {
            SceneManager.LoadScene(4);
        }
    }
}
