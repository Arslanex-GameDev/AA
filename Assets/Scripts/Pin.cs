using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private LevelManager levelManager;
    private ScoreManager scoreManager;
    private bool isPinned = false;
    private float speed = 100f;

    void Start()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    
    void Update()
    {
            if(!isPinned){
                rb.MovePosition(rb.position + Vector2.up*speed*Time.deltaTime);
            }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Pin"){
            levelManager.gameOver = true;

        }
        else if(other.tag == "Rotator"){
            transform.SetParent(other.transform);
            isPinned = true;
            scoreManager.score += 1;
        }
    }
}
