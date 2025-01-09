using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimator : MonoBehaviour
{
    public float delay2 = 2f;
    public Image imageUI;
    public float delay = 60f;
    public float horizontalOscillationAmplitude = 10f;
    public float verticalOscillationAmplitude = 5f;
    public float oscillationSpeed = 2f;

    private float elapsedTime;
    private Vector3 initialPosition;

    void Start()
    {
        StartCoroutine(DisappearAfterDelay());
        initialPosition = imageUI.transform.position;
        imageUI.gameObject.SetActive(false);
    }
    IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(delay2);
        gameObject.SetActive(false);
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= delay)
        {
            imageUI.gameObject.SetActive(true);
            float horizontalOscillation = Mathf.Sin(Time.time * oscillationSpeed) * horizontalOscillationAmplitude;
            float verticalOscillation = Mathf.Cos(Time.time * oscillationSpeed) * verticalOscillationAmplitude;
            imageUI.transform.position = initialPosition + new Vector3(horizontalOscillation, verticalOscillation, 0);
        }
    }
}