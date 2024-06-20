using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
public GameObject player;
public float px;
public float py;
public float persegui;
public Vector3 seguir;
    void Start()
    {
        seguir = transform.position;
        player = GameObject.FindWithTag("Player");
    }

    
    void Update()
    {
        
    }
}
