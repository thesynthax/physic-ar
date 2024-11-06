using UnityEngine;

public class RollingHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log(GetComponent<Rigidbody>().linearVelocity);
        }
    }

    public void Play()
    {

    }

    public void Reset()
    {
        
    }

}
