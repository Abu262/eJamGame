using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playtheme : MonoBehaviour
{
    public SFXManager SFX;
    // Start is called before the first frame update
    void Start()
    {
        SFX.Play("StageMusic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
