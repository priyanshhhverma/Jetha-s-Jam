using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;

    public float spawnRate = 1f;
    public float minHeight = -5.42f;
    public float maxHeight = -0.55f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        float randomNo = Random.Range(-5,5);

        if(randomNo > 0){
            GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
            pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        }
        
        if(randomNo < 0){
            GameObject pipes2 = Instantiate(prefab2, transform.position, Quaternion.identity);
            pipes2.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        }

    }

}