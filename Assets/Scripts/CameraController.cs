using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float speedCamera;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(0, -speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.A))
            transform.Translate(speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.S))
            transform.Translate(0, speedCamera * Time.deltaTime, 0);
        if(Input.GetKey(KeyCode.D))
            transform.Translate(-speedCamera * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.O))
            transform.Translate(0, 0, -speedCamera * Time.deltaTime);
        if(Input.GetKey(KeyCode.I))
            transform.Translate(0, 0, speedCamera * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Tab))
            transform.position = new Vector3(0, 0, -1000);
    }
}
