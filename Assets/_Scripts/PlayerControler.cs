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
        gm = GameManager.GetInstance();
        shield = transform.Find("Shield").gameObject;
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        life.text = health.ToString();

        if (health <=0){
            
            // gm.changeState(GameManager.GameState.MENU);
            gameOver.SetActive(true);
            Destroy(gameObject);
            

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
