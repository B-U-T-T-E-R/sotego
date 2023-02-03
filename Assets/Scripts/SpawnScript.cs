using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public bool CanSpawn = false;
    private void OnTriggerExit2D(Collider2D other)
    {
        CanSpawn = true;
    }
}
