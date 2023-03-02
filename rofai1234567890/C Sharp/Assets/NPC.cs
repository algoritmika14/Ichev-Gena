using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int newPosition;
    public Vector3 newPosition = transform.position;
    public int health = 5;
    public int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        print(health);
        health = health + level;
        print(health);
        newPosition.z += speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // ваня марц;
    }
}
