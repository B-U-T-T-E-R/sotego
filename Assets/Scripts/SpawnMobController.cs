using UnityEngine;
using UnityEngine.UI;

public class SpawnMobController : MonoBehaviour
{
    public int currentCountMobs;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    [SerializeField]
    private float percentageAddCountMobs;
    [SerializeField]
    private Transform pointSpawn;
    [SerializeField]
    private Sprite[] modelMobs;
    //[HideInInspector]
    private int countWave;
    //[HideInInspector]
    //private int beforeCountWave;
    private GameObject mob;
    public int rnd;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

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
                mob = Instantiate(mobs[Random.Range(0, 3)], pointSpawn);
            }

            mob.SetActive(true);
            currentCountMobs++;
        }

        Instantiate(modelMobs[Random.Range(0, 3)], pointSpawn);



        //if(beforeCountWave != countWave)
        //{
        //    currentCountMobs = 0;
        //}
        //beforeCountWave = countWave;
    }
}
