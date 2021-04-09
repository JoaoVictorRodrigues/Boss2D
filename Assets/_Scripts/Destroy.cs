using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{  
    public float lifetime = 10;
    // Start is called before the first frame update
    private void Start()
    {
       Destroy(gameObject,lifetime*Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
