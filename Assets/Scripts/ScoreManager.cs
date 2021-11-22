using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text counter;
    public int score = 0;

    void Update()
    {
        counter.text = score.ToString();
    }
}
