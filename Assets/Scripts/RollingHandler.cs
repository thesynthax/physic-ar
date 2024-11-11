using UnityEngine;

public class RollingHandler : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb.inertiaTensor);
    }

    // Update is called once per frame
    void Update()
    {

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

    }

    public void Reset()
    {
        
    }

}
