using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    Rigidbody rb;
    float speed;
    float angle;
    public KinematicsLevel kinematics;

    public Transform sourcePlatform;
    Vector3 originalPos;

    private bool playing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //originalPos = transform.position;
        
        originalPos = sourcePlatform.position + sourcePlatform.up * 0.662f;

        speed = kinematics.initialSpeed;
        angle = kinematics.angle;

        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            //rb.isKinematic = true;
            transform.position = sourcePlatform.position + sourcePlatform.up * 0.662f;
            //transform.eulerAngles = Vector3.zero;
            transform.eulerAngles = sourcePlatform.eulerAngles - Vector3.up * 90f;
        }
        else
        {
            //rb.isKinematic = false;
        }
    }

    public void Play()
    {
        playing = true;
        transform.position = sourcePlatform.position + sourcePlatform.up * 0.662f;
        transform.eulerAngles = sourcePlatform.eulerAngles - Vector3.up * 90f;
        float angleRad = Mathf.Deg2Rad * angle;
        float xVel = speed * Mathf.Cos(angleRad);
        float yVel = speed * Mathf.Sin(angleRad);

        Debug.Log(xVel);

        rb.linearVelocity = transform.right * xVel + transform.up * yVel;

        kinematics.ballArrow.gameObject.SetActive(false);

    }

    public void Reset()
    {
        playing = false;
        transform.position = originalPos;
        transform.localEulerAngles = Vector3.zero;
        rb.linearVelocity = Vector3.zero;

        kinematics.ballArrow.gameObject.SetActive(true);

    }

}
