using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f;        // �̵� �ӵ�
    public float moveDistance = 10f; // �̵��� �Ÿ�
    public float repeatDistance = 20f; // �ݺ��� ������ ����

    private Vector3 initialPosition; // �ʱ� ��ġ

    void Start()
    {
        // �ʱ� ��ġ ����
        initialPosition = transform.position;
    }

    void Update()
    {
        // ������Ʈ�� ���η� �̵�
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // �̵��� �Ÿ��� repeatDistance�� �Ѿ�� ó�� ��ġ�� ���ư�
        if (Mathf.Abs(transform.position.x - initialPosition.x) >= repeatDistance)
        {
            // ���� ��ġ�� �ʱ� ��ġ�� �缳��
            transform.position = initialPosition;
        }
    }
}
