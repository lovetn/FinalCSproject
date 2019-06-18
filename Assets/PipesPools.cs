using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPools : MonoBehaviour
{

    public float spawnRate = 4f;
    public int PipesPoolsSize = 5;
    public float PipesYMin = -2f;
    public float PipesYMax = 2f;

//Keep count of time frame between pipe spawn.
    private float timeSinceLastSpawn;
    private float spawnXPos = 10f;
    private int currentPipe = 0;

//reference to pipe prefab/ call for pipe array.
    public GameObject pipesPrefab;

    private GameObject[] Pipes;
    private Vector2 objectPoolPosition = new Vector2(-15, -25f);
    
    // Start is called before the first frame update
    void Start()
    {
        Pipes = new GameObject[PipesPoolsSize];
        for(int i = 0; i < PipesPoolsSize; i++)
        {
            Pipes[i] = Instantiate(pipesPrefab, objectPoolPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if(!GameControll.Instance.isGameOver && timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0;
            float spawnYpos = Random.Range(PipesYMin, PipesYMax);
            Pipes[currentPipe].transform.position = new Vector2(spawnXPos, spawnYpos);

            currentPipe++;

            if(currentPipe >= PipesPoolsSize) {currentPipe = 0; }
        }
        
    }
}
