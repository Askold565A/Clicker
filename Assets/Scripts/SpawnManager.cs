using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2f;
    private float spawnInterval;
    private float bossSpawnInterval;

    [Header ("Links")]
    [SerializeField] private Transform enemyParent;


    public GameObject[] enemyFromLeftPrefabs;
    public GameObject[] enemyFromRightPrefabs;
    public GameObject bossEnemyFromLeft;
    public GameObject bossEnemyFromRight;
    private float spawnPointX = 17f;
    


    void Start()
    {
        spawnInterval = Random.Range(2f, 5f);
        bossSpawnInterval = 20f;

        InvokeRepeating ("SpawnRandomLeftEnemy", startDelay, spawnInterval);
        InvokeRepeating ("SpawnRandomRightEnemy", startDelay, spawnInterval);
        InvokeRepeating ("SpawnRandomLeftBossEnemy", startDelay * 5, bossSpawnInterval);
        InvokeRepeating ("SpawnRandomRightBossEnemy", startDelay * 10, bossSpawnInterval);
        
    }

    void Update()
    {
       
    }
    void SpawnRandomLeftEnemy ()
    {
        int enemyIndex = Random.Range(0, enemyFromLeftPrefabs.Length);
        float spawnPointZ = Random.Range(-8f, 8f);

    Transform newEnemyTransform = Instantiate (enemyFromLeftPrefabs[enemyIndex], enemyParent).transform;
        newEnemyTransform.position = new Vector3 (-spawnPointX, 1, spawnPointZ);
        newEnemyTransform.rotation = Quaternion.Euler (0, 90, 0);
    }

    void SpawnRandomRightEnemy ()
    {
        int enemyIndex = Random.Range(0, enemyFromRightPrefabs.Length);
        float spawnPointZ = Random.Range(-8f, 8f);

        Transform newEnemyTransform = Instantiate (enemyFromRightPrefabs[enemyIndex], enemyParent).transform;
        newEnemyTransform.position = new Vector3 (spawnPointX, 1, spawnPointZ);
        newEnemyTransform.rotation = Quaternion.Euler (0, 270, 0);
    }

    void SpawnRandomLeftBossEnemy ()
    {
        float spawnPointZ = Random.Range(-8f, 8f);

        Transform newEnemyTransform = Instantiate(bossEnemyFromLeft, enemyParent).transform;
        newEnemyTransform.position = new Vector3(-spawnPointX, 1, spawnPointZ);
        newEnemyTransform.rotation = Quaternion.Euler(0, 90, 0);
    }

    void SpawnRandomRightBossEnemy()
    {
        float spawnPointZ = Random.Range(-8f, 8f);

        Transform newEnemyTransform = Instantiate(bossEnemyFromRight, enemyParent).transform;
        newEnemyTransform.position = new Vector3(spawnPointX, 1, spawnPointZ);
        newEnemyTransform.rotation = Quaternion.Euler(0, 270, 0);
    }

    
}
