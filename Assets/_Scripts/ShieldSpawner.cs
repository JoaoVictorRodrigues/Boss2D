using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    public GameObject[] shieldPosition;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.9f;

    private void Update(){
        int random = Random.Range(0,shieldPosition.Length);
        if (timeBtwSpawn <= 0 ){
            
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
