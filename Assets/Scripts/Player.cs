using UnityEngine;
using UnityEngine.Video;

public class Player: MonoBehaviour
{
    public float moveH;
    public float moveV;
    public int velocidade;
    public int  attack;
    public int vidas = 3;
    public bool comVida = true;
    public int dano = 30;
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

    private void FixedUpdate() {
         moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime,moveV * velocidade * Time.deltaTime,0);
    }

    // Update is called once per frame
    void Update()
    {
       

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
        
        }
        public int VidasdoPlayer()
        {
            return vidas;
        }
        private void PerdeVida()
        {
            if(vida > 0)
            {
                vidas --;
                vida = 100;
            }
            else if (vida == 0)
            {
                comVida = false;
            }
        }
        public bool VerificaSeplayerVivo()
        {
            return comVida;
        }
        
        private void PerdVida()
        {
            if(vida > 0)
            {
                vidas --;
                vida = 100;
            }
            else if (vida == 0)
            {
                comVida = false;
            }
        }
        public void tomardano()
        {
        }
        
}
 

