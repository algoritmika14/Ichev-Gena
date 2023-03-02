using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
        //������ ������ ���� ������� NPC �� �����

        transform.position =
        Vector3.MoveTowards(transform.position,
        target.position, speed * Time.deltaTime);
        //������������� ������ ���� NPC ����� � ����
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
