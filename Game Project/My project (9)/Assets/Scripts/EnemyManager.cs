using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float curTimer;
    public float maxTimer;
    public float maxBirdSpeed, maxSpikeSpeed;
    public float minBirdHeight, maxBirdHeight;
   
    public GameObject birdPrefab;
    public GameObject spikePrefab;

    public Transform enemySpawnpoint;
    
    public Vector3 birdSpawnHeight;

    public float obstacleSpeed;

    private List<GameObject> activeObjects = new List<GameObject>();

    private void Start()
    {
        if(birdPrefab != null && spikePrefab != null)
        {
            birdSpawnHeight = new Vector3(0, Random.Range(minBirdHeight, maxBirdHeight), 0);
        }
    }

    private void Update()
    {
        curTimer += 1 * Time.deltaTime;
        if (curTimer > maxTimer)
        {
            curTimer = 0;
            birdSpawnHeight = new Vector3(0, Random.Range(-2.7f,-3.5f), 0);
            if(PlayerScript.score >= 10f)
            {
                StartCoroutine(SpawnObstacles());
            } else
            {
                GenerateSpike();
            }
            
        }
        foreach(var obj in activeObjects)
        {
            if(obj != null)
            {
                if(obj.TryGetComponent(out Rigidbody2D rb))
                {
                    obj.transform.Translate((Vector2.left * obstacleSpeed * Time.deltaTime));
                    //rb.AddForce((Vector2.left * obstacleSpeed * Time.deltaTime), ForceMode2D.Force);
                }
            }
        }
    }

    public void GenerateBird()
    {
        GameObject BirdIns = Instantiate(birdPrefab, new Vector3(enemySpawnpoint.position.x, birdSpawnHeight.y, enemySpawnpoint.position.z), transform.rotation);
        activeObjects.Add(BirdIns);
    }

    public void GenerateSpike()
    {
        GameObject SpikeIns = Instantiate(spikePrefab, enemySpawnpoint.position, transform.rotation);
        activeObjects.Add(SpikeIns);
    }
    private IEnumerator SpawnObstacles()
    {
        GenerateBird();
        yield return new WaitForSeconds(Random.Range(1.2f, 1.8f));
        GenerateSpike();
    }
}
