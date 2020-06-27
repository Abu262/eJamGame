using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class ItemClass : MonoBehaviour
{
    public string name;
    public int ID;
    public BoxCollider bc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual IEnumerator Interact()
    {
        //from here we should be able to do whatever we  want with the object
        yield return null;
       
    }
}
