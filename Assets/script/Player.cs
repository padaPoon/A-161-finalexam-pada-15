using UnityEngine;

public class Player : MonoBehaviour
{
    PowerUpBase effect;
    //public Fields
    [SerializeField]private float moveSpeed = 5f;
    private float jumpForce = 10f;
    [SerializeField]private bool isInvulnerable = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        //Movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);    
        }
    }

    public void SetMoveSpeed(float currentSpeed)
    {
        moveSpeed *= currentSpeed;
        Debug.Log($"Current Speed = {moveSpeed}");
    }

    public void SetInvulnerbility(bool Invulnerable)
    {
        isInvulnerable = Invulnerable;
        Debug.Log($"Invulnerable set to:{isInvulnerable}");
    }

    public void DebuffSpeed(float speedDown)
    {
        moveSpeed /= speedDown;
        Debug.Log($"Current Speed = {moveSpeed}");
    }

    public void OnTriggerEnter2D(Collider2D PowerUpbase)
    {
       if (effect == PowerUpbase)
        {
        }
    }
}