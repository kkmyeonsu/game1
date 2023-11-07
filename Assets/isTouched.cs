using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToPlayAnimation : MonoBehaviour
{
    private Animation objectAnimation; // ������Ʈ�� ����� �ִϸ��̼� ������Ʈ

    private Animator animator; // Animator ������Ʈ

    private void Start()
    {
        // ������Ʈ�� ����� �ִϸ��̼� ������Ʈ ã��
        objectAnimation = GetComponent<Animation>();

        // Animator ������Ʈ ã��
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Ŭ�� �̺�Ʈ �߻�");

        // Ŭ���� ������Ʈ�� ����� �ִϸ��̼� ������Ʈ�� �ִٸ� ����
        if (objectAnimation != null)
        {
            objectAnimation.Play();
        }

        // "Playanim" Ʈ���Ÿ� Ȱ��ȭ�Ͽ� Animator ��Ʈ�ѷ��� �ִϸ��̼� ����
        if (animator != null)
        {
            animator.SetTrigger("PlayAnim");
        }
    }
}
