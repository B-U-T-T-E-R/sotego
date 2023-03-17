using UnityEngine;

public class wayPointScript : MonoBehaviour
{
    public bool CanRotate = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Entity") || other.transform.position == gameObject.transform.position)
            CanRotate = true;
        else
            CanRotate = false;
    }
}