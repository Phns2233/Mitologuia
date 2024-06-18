using UnityEngine;
using UnityEngine.Video;

public class move : MonoBehaviour
{
    public float moveH;
    public float moveV;
    public int velocidade;
    public int dano = 0;
    public int vida = 100;
    private Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime,moveV * velocidade * Time.deltaTime,0);

        if(Input.GetKeyDown(KeyCode.W) )
        {
            anim.SetLayerWeight(2,0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetLayerWeight(1,0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = false;
            anim.SetLayerWeight(1,0);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = true;
            anim.SetLayerWeight(1,0);
        }

      /*  if(moveH == 0)
        {
            
            anim.SetLayerWeight(0,1);
        }
        if(moveV == 0)
        {
            anim.SetLayerWeight(1,0);
            anim.SetLayerWeight(2,0);
            anim.SetLayerWeight(0,1);
        }*/
    }
 
}
