using UnityEngine;

public class CalculatorMobController : MonoBehaviour
{
    private void OnTriggerEnter(Collider2D other)
    {
        if(other.tag == "Enemy")
            GetComponent<SpawnMobController>().currentCountMobs += 1;
    }
}
