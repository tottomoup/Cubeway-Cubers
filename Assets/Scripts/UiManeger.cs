using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManeger : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _score;
    // Start is called before the first frame update
    void Start()
    {
        _score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        _score.text = "Score: " + Score.ScoreMan;
    }
}
