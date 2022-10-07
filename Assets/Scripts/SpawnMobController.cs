using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    [HideInInspector]
    private int currentCountMobs;
    [HideInInspector]
    private int currentCountWave;
    [HideInInspector]
    private int beforeCountWave;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    [SerializeField]
    private float percentageAddCountMobs;  
    private GameObject mob;

    void Start()
    {
        beforeCountWave = currentCountWave = 1;
        percentageAddCountMobs = 0.2f;
    }

    void Update()
    {
        if(currentCountMobs != maxCountMobs)
        {
            if(currentCountWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[Random.Range(0, 3)]);
            }
            if(beforeCountWave != currentCountWave)
                percentageAddCountMobs += percentageAddCountMobs;

            mob.transform.position = new Vector2(-268.1f, 259.4f);

            mob.SetActive(true);
            currentCountMobs++;      
        }
    }

    public float ChangeStatsMob(float health)
    {
        health += health * percentageAddCountMobs;
        return health;
    }
}
