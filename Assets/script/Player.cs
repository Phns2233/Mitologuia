using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveH;
    public float moveV;
    public int velocidade;
    public int forcePulo;
    public bool isPulo = false;
    private Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH= Input.GetAxis("Horizontal");
        moveV= Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
        transform.position -= new Vector3(moveV * velocidade * Time.deltaTime, 0, 0);

        if (Input)







         if (Input.GetKeyDown(KeyCode.Space) && !isPulo) 
            {
                rb.AddForce(transform.up * forcePulo ,ForceMode2D.Impulse);
                isPulo = true;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetLayerWeight(4,1);
            }
    }
}
