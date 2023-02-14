using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{

    public Transform tile1Obj;
    private Vector3 nextTileSpawn;
    public Transform boxObj;
    private Vector3 nextBoxSpawn;
    public Transform largerBoxObj;
    private Vector3 nextLargerBoxSpawn;
    public Transform amongusObj;
    private Vector3 nextAmongusSpawn;
    public Transform cartObj;
    private Vector3 nextCartSpawn;
    private int randX;
    private int randChoice;

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 20;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1.5f);
        randX = Random.Range(-1, 2);
        nextBoxSpawn = nextTileSpawn;
        nextBoxSpawn.y = 0.39f;
        nextBoxSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(boxObj, nextBoxSpawn, boxObj.rotation);
        nextTileSpawn.z += 5;

        randX = Random.Range(-1, 2);
        nextLargerBoxSpawn.z = nextTileSpawn.z;
        nextLargerBoxSpawn.y = 1.0f;
        nextLargerBoxSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(largerBoxObj, nextLargerBoxSpawn, largerBoxObj.rotation);

        if(randX == 0)
        {
            randX = 1;
        }
        else if(randX == 1)
            {
                randX = -1;
            }
        
        else
        {
            randX = 0;
        }
        randChoice = Random.Range(0, 2);
        if (randChoice == 0)
        {
            nextAmongusSpawn.z = nextTileSpawn.z;
            nextAmongusSpawn.y = 0.5f;
            nextAmongusSpawn.x = randX;
            Instantiate(amongusObj, nextAmongusSpawn, amongusObj.rotation);
        }
        else
        {
            nextCartSpawn.z = nextTileSpawn.z;
            nextCartSpawn.y = 0.6f;
            nextCartSpawn.x = randX;
            Instantiate(cartObj, nextCartSpawn, cartObj.rotation);
        }
            nextTileSpawn.z += 5;
            StartCoroutine(spawnTile());
    }
}
