using UnityEngine;

public class BossController : MonoBehaviour
{
    public float waitTime = 5f;
    public float initialSpeed = 10f; // Vitesse initiale du boss
    public float acceleration = 0.2f; // Accélération du boss
    public bool isready = false;
    private Transform player;
    private Vector3 targetPosition;
    private float timer;
    private float currentSpeed;
    public BoxCollider2D collider2D;
    private Animator animator;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentSpeed = initialSpeed;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Speed", targetPosition.magnitude);
        if (!isready)
        {
            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.02f);

                if(timer > waitTime+6)
                { 
                    targetPosition = player.position;
                    timer = 0f;
                    collider2D.enabled = true;
                    isready = true;
                }
            }
        }
        else
        {
            
            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                targetPosition = player.position;
                timer = 0f;
            }

            
            currentSpeed += acceleration * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, currentSpeed * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
