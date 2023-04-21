using System;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMobController : MonoBehaviour
{
    [SerializeField]
    private int currentCountWave;
    [SerializeField]
    private int LastWave;
    [SerializeField]
    private Vector2 positionSpawn;
    [SerializeField]
    private GameObject[] mobs;
    [SerializeField]
    private int maxCountMobs;
    private GameObject mob;
    [HideInInspector]
    public int currentCountMobsOnWave;
    public Transform[] wayPoints;
    private GameObject[] gm;
    private bool isMaxMob;
    [SerializeField]
    Text text;
    private int value;

    int time;
    int time1 = 18;

    void Start()
    {
        positionSpawn = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        time = time1;
    }

    void Update()
    {
        Spawn();
    }

    private void FixedUpdate()
    {
        gm = GameObject.FindGameObjectsWithTag("Entity");
        time--;
    }

    private void Spawn()
    {
        text.text = currentCountWave.ToString();

        if(currentCountMobsOnWave == maxCountMobs)
            isMaxMob = true;

        if (currentCountMobsOnWave == 0 && isMaxMob)
        {
            value = UnityEngine.Random.Range(0, 3);
            LastWave = currentCountWave;
            currentCountWave++;
            isMaxMob = false;
        }

        if (currentCountMobsOnWave != maxCountMobs && time <= 0 && !isMaxMob)
        {
            if (currentCountWave <= 10)
            {
                mob = Instantiate(mobs[0]);
            }
            else
            {
                mob = Instantiate(mobs[value]);
            }

            mob.transform.position = positionSpawn;

            currentCountMobsOnWave++;
            time = time1;
        }

        currentCountMobsOnWave = gm.Length;
    }

    
}
