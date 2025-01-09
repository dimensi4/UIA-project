using UnityEngine;
using UnityEngine.UI;

public class ImageOscillation : MonoBehaviour
{
    public float delay = 60f; // Délai avant l'apparition (en secondes)
    public float minAlpha = 0.5f; // Transparence minimale
    public float maxAlpha = 1f; // Transparence maximale
    public float speed = 1f; // Vitesse d'oscillation

    private Image image;
    private float timer;

    void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0); // Initialement invisible
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            float alpha = Mathf.PingPong(Time.time * speed, maxAlpha - minAlpha) + minAlpha;
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
        }
    }
}
