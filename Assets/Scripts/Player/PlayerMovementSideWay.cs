using UnityEngine;

public class PlayerMovementSideWay : MonoBehaviour
{
    [SerializeField]
    float moveX;
    [SerializeField]
    float moveY;
    [SerializeField]
    public bool isFacingLeft;
    public float movespeed;
    public float jumpForce;
    public Rigidbody2D rb;
    public Transform groundChecker;
    public LayerMask groundLayer;

   SpriteRenderer spriteRenderer;

    void Start()
    {
        // 3 tapaa referoida alustettuun spriteRendereriin:
       // spriteRenderer = rb.GetComponent<SpriteRenderer>(); // Jos flippaus 1.vaihtoehto käytössä
      rb.GetComponent<SpriteRenderer>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    bool IsOnGround()
    {
        return Physics2D.OverlapCapsule(groundChecker.position, new(1f, 1f), 
            CapsuleDirection2D.Horizontal, 0, groundLayer);
    }
    void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        // Kokeile kumpi toimii paremmin:
        rb.velocity = new(moveX * movespeed, rb.velocity.y);
        // transform.Translate(moveX * Time.deltaTime, transform.position.y, 0);

        //-----------------------------
        // Hahmon flippaus vaihtoehto 1:
        // Tähän tarvitaan Starttiin spriteRenderer = rb.GetComponent<SpriteRenderer>();
        if (moveX < 0)
        {
            spriteRenderer.flipX = false;
            isFacingLeft = true;
        }
        if (moveX > 0)
        {
            spriteRenderer.flipX = true;
            isFacingLeft = false;
        }
        // Tai sitten vain:
        //else
        //{
        //    spriteRenderer.flipX = true;
        //}
        //-----------------------------
        // Hahmon flippaus vaihtoehto 2:
        //if (rb.velocity.x < 0)
        //{
        //    // Hyväksyy myös new Vector2(x,y)
        //    transform.localScale = new(-1, transform.localScale.y);
        //}
        //else if (rb.velocity.x > 0)
        //{
        //    transform.localScale = new(1, transform.localScale.y);
        //}
        //-----------------------------
        // Hahmon flippaus vaihtoehto 3:
        //if (rb.velocity.x < 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 180f, 0);
        //}
        //else if (rb.velocity.x > 0)
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround())
        {
            // Annetaan pikku pusku ylöspäin. 3 eri tapaa:

            /*1.*/
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            /* 2.*/ // rb.velocity = new(rb.velocity.x, jumpForce);
            /* 3.*/ // transform.Translate(0, jumpForce += 1f, 0);
        }

    }
    void Update()
    {
        Debug.Log(IsOnGround());
        Move();
        Jump();
    }
}
