using UnityEngine;

public class wayPointScript : MonoBehaviour
{
    [SerializeField]
    public bool CanRotate = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == gameObject.CompareTag("Entity"))
        {
            Debug.Log("TRUE");
            CanRotate = true;
        }

        CanRotate = false;
    }
}