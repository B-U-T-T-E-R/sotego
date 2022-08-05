using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float speedCamera;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.z > -180)
            transform.Translate(0, -speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.A) && transform.position.x < 625)
            transform.Translate(speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.S) && transform.position.z < 180)
            transform.Translate(0, speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.D) && transform.position.x > -625)
            transform.Translate(-speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKeyDown(KeyCode.Tab))
            transform.position = new Vector3(0, 1000, 0);
    }
}
