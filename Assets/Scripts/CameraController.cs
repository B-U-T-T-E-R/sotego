using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float speedCamera;

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.y > -65)
            transform.Translate(0, -speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.A) && transform.position.x < 430)
            transform.Translate(speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.S) && transform.position.y < 65)
            transform.Translate(0, speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.D) && transform.position.x > -430)
            transform.Translate(-speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.O) && transform.position.z > -1500)
            transform.Translate(0, 0, -speedCamera * Time.deltaTime);
        if(Input.GetKey(KeyCode.I) && transform.position.z < -500)
            transform.Translate(0, 0, speedCamera * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Tab))
            transform.position = new Vector3(0, 0, -1000);
    }
}
