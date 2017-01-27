using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour
{
    public GameObject swordPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(swordPrefab, transform.position + new Vector3(0, 1, 0) + transform.forward * 1 + transform.right * 0.5f, Quaternion.identity);
        }
    }
}



