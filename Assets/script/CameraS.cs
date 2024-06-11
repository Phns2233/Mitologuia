using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float px = player.transform.position.x;
        float py = player.transform.position.y;

        if(px > -3 && py > -1)
        {
            transform.position = new Vector3(px, py, -1);
        }
    }
}
