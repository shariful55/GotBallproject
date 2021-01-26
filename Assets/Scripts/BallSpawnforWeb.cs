using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnforWeb : MonoBehaviour
{
    public GameObject[] player;
    private int ballSerial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        touchPosition.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            ballSerial = Random.Range(0, player.Length);
            touchPosition = new Vector3(touchPosition.x, 5.5f, 0);
            StartCoroutine(Ball1Spawn(player, touchPosition, Quaternion.identity));
        }


    }

    IEnumerator Ball1Spawn(GameObject[] player1, Vector3 pos, Quaternion rot)
    {
        Instantiate(player1[ballSerial], pos, rot);

        yield return new WaitForFixedUpdate();

    }
}
