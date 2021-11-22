using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float turnSpeed = 100f;
    private LevelManager levelManager;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    void Update()
    {
        if(levelManager.gameOver == true){
            GameOver();
        }
        else{
            transform.Rotate(0f,0f,turnSpeed*Time.deltaTime);
        }
    }

    void GameOver(){
        transform.Rotate(0f,0f,0f);
    }
}
