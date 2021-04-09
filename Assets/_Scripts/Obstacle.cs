using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed; 
    public float screenLength = -10;

    public GameObject damageSound;
    
    void Start(){
        
    }
    
    private void Update(){
        transform.Translate(Vector2.left *speed*Time.deltaTime);
        if (transform.position.x < screenLength){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            if(other.GetComponent<PlayerControler>().shield.activeInHierarchy){
                other.GetComponent<PlayerControler>().shield.SetActive(false);
                Destroy(gameObject);
                Debug.Log("Shield");
            }else{
                // Instantiate(damageSound,transform.position,Quaternion.identity);
                other.GetComponent<PlayerControler>().health -= damage;
                Debug.Log(other.GetComponent<PlayerControler>().health);
                Destroy(gameObject);
            }
           
        }
    }
}
