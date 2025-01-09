using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageRandomAppear : MonoBehaviour
{
    public Image imageUI; 
    public float minDelay = 2f; 
    public float maxDelay = 10f; 
    public float displayDuration = 2f;

    private void Start()
    {
       
        imageUI.gameObject.SetActive(false);

        
        StartCoroutine(ActivateImageAfterDelay(Random.Range(minDelay, maxDelay)));
    }

    private IEnumerator ActivateImageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        imageUI.gameObject.SetActive(true);

        
        yield return new WaitForSeconds(displayDuration);
        imageUI.gameObject.SetActive(false);

        
        StartCoroutine(ActivateImageAfterDelay(Random.Range(minDelay, maxDelay)));
    }
}