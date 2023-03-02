using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
        //ћен€ет каждый кадр позицию NPC на новую

        transform.position =
        Vector3.MoveTowards(transform.position,
        target.position, speed * Time.deltaTime);
        //–азворачивает каждый кадр NPC лицом к цели
        transform.LoockAt(target.position);
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
