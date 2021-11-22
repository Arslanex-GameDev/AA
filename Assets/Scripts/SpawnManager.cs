using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject pinPrefab;
    [SerializeField] GameObject textPrefab;

    private LevelManager levelManager;
    private Text pinCounter;
    private int pinNum = 1;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        pinCounter = textPrefab.GetComponent<Text>();
    }
    private void Update() {
        if(levelManager.gameOver != true){
            if(Input.GetMouseButtonDown(2)){
                spawnPin();
            }
        }
    }

    private void spawnPin(){
        Instantiate(pinPrefab, transform.position, Quaternion.identity);
        //pinCounter.text = pinNum.ToString();
        //Instantiate(textPrefab, transform.position, Quaternion.identity);
        //pinNum += 1;
    }
}
