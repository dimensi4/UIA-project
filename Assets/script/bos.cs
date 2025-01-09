using UnityEngine;

public class BossController : MonoBehaviour
{
    public float waitTime = 60f;
    public float initialSpeed = 10f; // Vitesse initiale du boss
    public float acceleration = 0.1f; // Accélération du boss
    private Transform player;
    private Vector3 targetPosition;
    private float timer;
    private float currentSpeed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentSpeed = initialSpeed;
        transform.position = Vector3.zero;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            targetPosition = player.position;
            timer = 0f;
        }

        // Accélération du boss
        currentSpeed += acceleration * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, currentSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
