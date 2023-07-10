using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public static PlayerControll instance;

    public float movemenetspeed = 5f;
    public float runspeed;
    public string areatransitionName;
    public bool iswalking;
    public bool isbehind;
    public string istalktosomeone;
    public bool istalktosomeoneb;
    public bool isbattle;
    public bool isjustw;
    public bool isruning;
    public bool isgofront;

    public GameObject particle,runparticle;
    public SpriteRenderer spriteRenderer;

    private Vector2 movement;
    private Rigidbody2D rb;
    private bool isparticleon;
    public Animator anim,runparticleani;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        runparticleani = runparticle.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isbattle)
        {
            if (isjustw)
            {
                isruning = false;
                movement.x = Input.GetAxisRaw("Horizontal");
                anim.SetFloat("Horizonztal", movement.x);
                if (Input.GetAxisRaw("Vertical") == 1)
                {
                    movement.y = Input.GetAxisRaw("Vertical");

                    iswalking = true;
                    anim.SetBool("iswalking", true);
                    anim.SetFloat("Vertical", movement.y);
                }
                else
                {
                    movement.y = 0;
                    iswalking = false;
                    anim.SetBool("iswalking", false);
                    stopidle();
                }
                //anim.SetFloat("Vertical",1);
            }else
            {
                if (isgofront)
                {
                    isruning = false;
                    movement.x = 0;
                    movement.y = 1;
                }
                else
                {

                    movement.x = Input.GetAxisRaw("Horizontal");
                    movement.y = Input.GetAxisRaw("Vertical");
                }

                if (movement.x != 0 || movement.y != 0)
                {
                    anim.SetFloat("Horizonztal", movement.x);
                    anim.SetFloat("Vertical", movement.y);
                    if (!iswalking)
                    {
                        iswalking = true;
                        anim.SetBool("iswalking", true);
                    }
                }
                else
                {
                    if (iswalking)
                    {
                        iswalking = false;
                        anim.SetBool("iswalking", false);
                        stopidle();
                    }
                }

                if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    if (isruning)
                    {
                        isruning = false;
                        runparticle.SetActive(false);
                    }
                    else
                    {
                        isruning = true;
                        runparticle.SetActive(true);
                    }
                }
            }

            if (isruning)
            {
                runspeed = Mathf.MoveTowards(runspeed, 1.5f,0.01f);
                anim.speed = runspeed;
                runparticleani.SetFloat("hor",movement.x);
                runparticleani.SetFloat("ver", movement.y);

            }
            else
            {
                runspeed = Mathf.MoveTowards(runspeed, 1, 0.01f);
                anim.speed = runspeed;
                runparticleani.SetFloat("hor", 0);
                runparticleani.SetFloat("ver", 0);
            }

             if (isbehind)
             {
                 spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 0.8f);
             }
             else
             {
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
             }

        }
        else
        {
            runparticleani.SetFloat("hor", 0);
            runparticleani.SetFloat("ver", 0);
        }
        if (isparticleon)
        {
            particle.SetActive(true);
        }
    }

    public void letparticleon()
    {
        isparticleon = true;
    }
    void stopidle()
    {
        rb.velocity = Vector3.zero;
    }
    void FixedUpdate()
    {
        if (!isbattle)
        {
            rb.MovePosition(rb.position + movement * movemenetspeed *runspeed * Time.fixedDeltaTime);
        }
        else
        {
            iswalking = false;
            anim.SetBool("iswalking", false);
            rb.velocity = Vector3.zero;
        } 
    }

    public void battle()
    {
        isbattle = false;
    }

    public void Timetogo()
    {
        isgofront = true;
    }

    public void TimetoNotgo()
    {
       isgofront = false;
    }

}
