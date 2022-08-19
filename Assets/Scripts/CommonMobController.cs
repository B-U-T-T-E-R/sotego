using UnityEngine;

public class CommonMobController : MonoBehaviour
{
    [SerializeField]
    private Transform spawn;

    [SerializeField]
    private GameObject mob;

    private GameObject newMob;

    void Start()
    {
        mob.transform.position = spawn.position;
    }
    void update()
    {
        mob.transform.position = spawn.position;
        newMob = Instantiate(mob);
    }
}
