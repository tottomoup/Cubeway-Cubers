using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
