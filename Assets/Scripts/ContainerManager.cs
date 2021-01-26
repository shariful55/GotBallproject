using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerManager : MonoBehaviour
{
    public GameObject [] obstacles;
    public int containerTime;
    public int indexOfObstacle;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("ObstacleSpawn", 2, containerTime);
       
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.time;
       
    }

    private void  ObstacleSpawn()
    {
        indexOfObstacle = Random.Range(0, obstacles.Length);
        Debug.Log("Spawn start");
        Instantiate(obstacles[indexOfObstacle], obstacles[indexOfObstacle].transform.position,Quaternion.identity);

        containerTime = Random.Range(0, 3);

    }
        
        
    

}
