using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    [HideInInspector]
    private int currentCountMobs;
    [HideInInspector]
    private int countWave;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    [SerializeField]
    private float percentageAddCountMobs;  
    private GameObject mob;

    void Start()
    {
        countWave = 1;
    }

    void Update()
    {
        
        if(currentCountMobs != maxCountMobs)
        {
            if(countWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[Random.Range(0, 3)]);
            }

            mob.transform.position = new Vector2(-268.1f, 259.4f);

            mob.SetActive(true);
            currentCountMobs++;      
        }
    }
}
