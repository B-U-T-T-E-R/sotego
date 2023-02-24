using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public bool CanSpawn;
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other == gameObject.CompareTag("Entity"))
            CanSpawn = true;

        CanSpawn = false;
    }
}
