using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCrashingPcNoMore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <ManMove.cubePos.z - 10)
        {
            Destroy(gameObject);
        }
    }
}
