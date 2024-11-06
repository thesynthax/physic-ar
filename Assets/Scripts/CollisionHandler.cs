using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject cube1, cube2;
    Rigidbody rb1, rb2;

    Vector3 originalPos1, originalPos2;

    float u1;

    CollisionLevel collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb1 = cube1.GetComponent<Rigidbody>();
        rb2 = cube2.GetComponent<Rigidbody>();

        originalPos1 = cube1.transform.position;
        originalPos2 = cube2.transform.position;

        collision = GetComponent<CollisionLevel>();

        u1 = collision.u1;
        rb1.mass = collision.m1;
    }

    // Update is called once per frame
    void Update()
    {
        collision.UpdateValues(Mathf.Round(rb1.linearVelocity.magnitude * 100f)/100f, rb1.mass, Mathf.Round(rb2.linearVelocity.magnitude * 100f)/100f, rb2.mass);
    }

    public void Play()
    {
        rb1.linearVelocity = Vector3.right * u1;
    }

    public void Reset()
    {
        cube1.transform.position = originalPos1;
        cube2.transform.position = originalPos2;
        transform.localEulerAngles = Vector3.zero;
        rb1.linearVelocity = Vector3.zero;
        rb2.linearVelocity = Vector3.zero;
    }

}
