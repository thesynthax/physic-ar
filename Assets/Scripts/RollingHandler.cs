using UnityEngine;

public class RollingHandler : MonoBehaviour
{
    Rigidbody rb;
    public RollingLevel rolling;
    public Transform sourcePlatform;
    Vector3 originalPos;

    private bool playing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //originalPos = transform.position;
        
        originalPos = sourcePlatform.position + (sourcePlatform.up * 0.3076f + sourcePlatform.forward * 0.6f) * 2f;

        playing = false;
        rb.isKinematic = true;
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing) {
            transform.position = sourcePlatform.position + (sourcePlatform.up * 0.3076f + sourcePlatform.forward * 0.6f) * 2f;
            transform.eulerAngles = sourcePlatform.eulerAngles - Vector3.up * 90f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log(GetComponent<Rigidbody>().linearVelocity.magnitude);
        }
    }

    public void Play()
    {
        playing = true;
        rb.isKinematic = false;
        //transform.position = sourcePlatform.position + (sourcePlatform.up * 0.3076f + sourcePlatform.forward * 0.6f) * 2f;
        //transform.eulerAngles = sourcePlatform.eulerAngles - Vector3.up * 90f;
    }

    public void Reset()
    {
        playing = false; 
        rb.isKinematic = true;
        rb.linearVelocity = Vector3.zero;
    }

}
