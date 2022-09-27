using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour, IDataPersistence
{

    [SerializeField] int time;

    public static bool lightSet = true;

    public GameObject[] players;
    public Sprite walk;
    public Sprite running;
    public Sprite idle;

    float Speed;
    float walkSpeed = 3f;
    float runSpeed = 5f;
    public float jumpVelocity;

    public KeyCode jumpKey;
    public LayerMask ground;
    public Collider2D footCollider;

    private bool isGrounded;

    private Rigidbody2D rb;

    public void LoadData(GameData data){
        this.transform.position = data.PlayerPos + new Vector3(0, 0, 100);
        lightSet = data.lights;
        Quest2.mathClear = data.math;
        Quest1.ChemClear = data.chem;
        Bio.BioClear = data.bio;
    }

    public void SaveData(GameData data){
        data.chem = Quest1.ChemClear;
        data.PlayerPos = this.transform.position;
        data.lights = lightSet;
        data.math = Quest2.mathClear;
        data.bio = Bio.BioClear;
    }

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();

        DontDestroyOnLoad(gameObject);

        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {

        if(DialogueManager.isActive == true){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
            return;
        }

        if(players.Length > 1){                                             //Clear Charator When Charactor Is Moe Than 1
            Destroy(players[1]);
        }

        if(Input.GetAxis("Horizontal") < -0.1f && Input.GetKey(KeyCode.LeftShift)){                            //Movement
            Speed = runSpeed;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = running;
            transform.eulerAngles = new Vector2(0,180);
        }
        else if(Input.GetAxis("Horizontal") > 0.1f && Input.GetKey(KeyCode.LeftShift)){
            Speed = runSpeed;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = running;
            transform.eulerAngles = new Vector2(0,0);
        }
        else if(Input.GetAxis("Horizontal") < -0.1f){
            Speed = walkSpeed;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = walk;
            transform.eulerAngles = new Vector2(0,180);
        }
        else if(Input.GetAxis("Horizontal") > 0.1f){
            Speed = walkSpeed;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = walk;
            transform.eulerAngles = new Vector2(0,0);
        }
        else if(Input.GetAxis("Horizontal") == 0 || Input.GetKeyUp(KeyCode.LeftShift)){
            Speed = 0f;
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
        }
        
        isGrounded = footCollider.IsTouchingLayers(ground);                 //Ground Check

        if(Input.GetKeyDown(jumpKey)){                                     //Jump
            if(isGrounded){
                jump();
            }
        }

        void jump(){                                                       //Jump Void
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity * Time.fixedDeltaTime);
        }

    }
}
