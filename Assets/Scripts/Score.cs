using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int ScoreMan;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            ScoreMan = 0;
        }
    }
   
    private void FixedUpdate()
    {
        ScoreMan += 10;
    }
}
