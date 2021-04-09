using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public float speed; 
    public float screenLength = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.left *speed*Time.deltaTime);
        if (transform.position.x < screenLength){
            Destroy(gameObject);
        } 
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            Destroy(gameObject);  
        }
    }
}
