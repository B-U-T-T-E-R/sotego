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
    private int countWave;
    public int rnd;
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

        //if(beforeCountWave != countWave)
        //{
        //    currentCountMobs = 0;
        //}
        //beforeCountWave = countWave;
    }
}
