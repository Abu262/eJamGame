using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereItem : ItemClass
{
    [System.NonSerialized()]
    private MonoBehaviour _owner;
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

        yield return StartCoroutine(test());
        yield return null;
    }


}
