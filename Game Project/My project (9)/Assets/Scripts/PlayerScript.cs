using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float JumpForce;
    public static float score;

    public KeyCode JumpKey = KeyCode.UpArrow;
    public KeyCode DuckKey = KeyCode.DownArrow;

    public bool isJumping;

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;
    bool isDucking = false;
    Vector3 oldScale;

    Rigidbody2D RB;

    public Text ScoreTxt;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(JumpKey))
        {
            Debug.Log("***Good***");
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
                isJumping = true;
                if(isDucking == true)
                {
                    isDucking = false;
                    this.transform.localScale = Vector3.Slerp(this.transform.localScale, Vector3.one, 0.5f); ;
                }
                Debug.Log("***Better***");
            }
        }
        if(Input.GetKey(DuckKey))
        {
            if(isGrounded)
            {
                oldScale = this.transform.localScale;
                isDucking = true;
                this.transform.localScale = Vector3.Slerp(this.transform.position, new Vector3(1f, 0.75f, 1f), 0.5f);
            }
        } else if (!Input.GetKey(DuckKey))
        {
            if (isGrounded && isDucking)
                this.transform.localScale = Vector3.Slerp(this.transform.localScale, Vector3.one, 0.5f);
            
        }
        
        if(isAlive)
        {
            Debug.Log("good");
            score += Time.deltaTime * 4;
            Debug.Log(score.ToString());
            ScoreTxt.text = "SCORE  :  " + score.ToString("F");
            Debug.Log("gooooood");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
                isJumping = false;
            }
        }
        if(collision.gameObject.CompareTag("Spike") || collision.gameObject.CompareTag("Bird"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }
    

}
