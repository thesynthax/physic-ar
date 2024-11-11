using UnityEngine;
using TMPro;

public class RollingHandler : MonoBehaviour
{
    Rigidbody rb;
    public RollingLevel rolling;
    public Transform sourcePlatform;
    Vector3 originalPos;

    public TextMeshProUGUI velocityText;
    public Transform velocityTextRoot;
    Transform ARCamera;
    private bool playing;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        originalPos = sourcePlatform.position + (sourcePlatform.up * 0.3076f + sourcePlatform.forward * 0.6f) * 2f;

        playing = false;
        rb.isKinematic = true;
        velocityText.gameObject.SetActive(false);

        ARCamera = rolling.ARCamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing) {
            transform.position = sourcePlatform.position + (sourcePlatform.up * 0.3076f + sourcePlatform.forward * 0.6f) * 2f;
            transform.eulerAngles = sourcePlatform.eulerAngles - Vector3.up * 90f;
        }

        velocityTextRoot.LookAt(velocityTextRoot.position + ARCamera.rotation * Vector3.forward, ARCamera.rotation * Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            velocityText.gameObject.SetActive(true);
            velocityText.text = (Mathf.Round(rb.linearVelocity.magnitude*100f)/100f).ToString() + "m/s";
        }
    }

    public void Play()
    {
        playing = true;
        rb.isKinematic = false;
    }

    public void Reset()
    {
        playing = false; 
        rb.isKinematic = true;
        rb.linearVelocity = Vector3.zero;
        velocityText.gameObject.SetActive(false);
    }

}
