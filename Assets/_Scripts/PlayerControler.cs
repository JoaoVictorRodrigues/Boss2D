using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{

    private Vector2 pos;
    public float IncY;
    public float maxHeight;
    public float minHeight;
    public float speed;
    public int health = 3;
    public GameObject shield;

    public Text life;

    public GameObject gameOver;
    GameManager gm;

    void Start()
    {
        shield = transform.Find("Shield").gameObject;
        shield.SetActive(false);
        // Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        life.text = ("Life: " + health.ToString());

        if (health <=0){
            gameOver.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0f;
        }

        transform.position = Vector2.MoveTowards(transform.position, pos, speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
            pos = new Vector2(transform.position.x, transform.position.y + IncY);
            transform.position = pos;
        }else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
            pos = new Vector2(transform.position.x, transform.position.y - IncY);
            transform.position = pos;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Shield")){
            shield.SetActive(true);
        }
    }
}
