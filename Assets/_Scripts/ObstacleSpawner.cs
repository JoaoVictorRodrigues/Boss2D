using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePositions;
    public GameObject[] shieldPosition;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.9f;

    private void Update(){
        int random = Random.Range(0,obstaclePositions.Length);
        if (timeBtwSpawn <= 0 ){
            
            Instantiate(obstaclePositions[random],transform.position,Quaternion.identity);
            Instantiate(shieldPosition[random],transform.position,Quaternion.identity);
            
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime){
                startTimeBtwSpawn -= decreaseTime;
            }
        }else{
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
