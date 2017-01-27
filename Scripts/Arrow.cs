using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * speed / 5, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
