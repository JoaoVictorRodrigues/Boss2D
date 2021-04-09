using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPosition : MonoBehaviour
{
    
    public GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shield, transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
