using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{   
    [SerializeField] private GameObject losePanel;
    public bool gameOver = false;
    private Color color1 = Color.red;
    private Camera cam;

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if(gameOver){
            cam.backgroundColor = color1;
            losePanel.gameObject.SetActive(true);
        }
    }

    public void ReStart(){
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
