using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIE : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
