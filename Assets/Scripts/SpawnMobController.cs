using UnityEngine;

public class SpawnMobController : MonoBehaviour
{
    //[HideInInspector]
    public int currentCountMobs;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    [SerializeField]
    private float percentageAddCountMobs;
    [HideInInspector]
    private int countWave;
    [HideInInspector]
    private int beforeCountWave;
    private GameObject mob;
    public int rnd;

    void Start()
    {
        rnd = Random.Range(0, 3);
        currentCountMobs = 0;
        countWave = 1;
    }

    void Update()
    {
        if(countWave <= 10 && currentCountMobs != maxCountMobs)
        {
            mob = Instantiate(mobs[0]);
            mob.SetActive(true);
            mob.transform.position = new Vector3(-268.1f, 259.4f, 0);
            currentCountMobs++;
        }
        if(countWave > 10 && currentCountMobs != maxCountMobs)
        {
            mob = Instantiate(mobs[rnd]);
            mob.SetActive(true);
            mob.transform.position = new Vector3(-268.1f, 259.4f, 0);
            currentCountMobs++;
        }
        if(beforeCountWave != countWave)
        {
            currentCountMobs = 0;
            rnd = Random.Range(0, 3);
        }
        beforeCountWave = countWave;
    }
}
