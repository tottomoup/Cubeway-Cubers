using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMove : MonoBehaviour
{
    private float teleportDistanceLeft = 1.0f;
    private float teleportDistanceRight = -1.0f;

    public float cooldownTime = 0.5f;
    private float cooldownTimer = 0;

    public Vector3 mapBoundsMin;
    public Vector3 mapBoundsMax;

    private string midJump = "n";

    public static Vector3 cubePos;


    // Update is called once per frame
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    void Update()
    {
        cubePos = transform.position;
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer <= 0)
        {

             if (Input.GetKeyDown(KeyCode.LeftArrow))
             {
            Vector3 newPosition = transform.position - new Vector3(teleportDistanceLeft, 0, 0);

                if (newPosition.x > mapBoundsMin.x && newPosition.x < mapBoundsMax.x)
                {
                    transform.position = newPosition;

                    cooldownTimer = cooldownTime;
                }
             }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {

                Vector3 newPosition = transform.position - new Vector3(teleportDistanceRight, 0, 0);

                if (newPosition.x > mapBoundsMin.x && newPosition.x < mapBoundsMax.x)
                {
                    transform.position = newPosition;
                    cooldownTimer = cooldownTime;
                }
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && midJump == "n")
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 1.5f, 3);
                midJump = "y";
                StartCoroutine(stopJump());
            }
        }
    }
    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, -1.5f, 3);
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        midJump = "n";
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "obstacle")
        {

        }
    }
}
