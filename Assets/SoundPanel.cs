using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAnimator : MonoBehaviour
{
    public GameObject imageWindow;
    private Animator animator;

    private void Start()
    {
        animator = imageWindow.GetComponent<Animator>();
        imageWindow.SetActive(false); // �̹��� â�� �ʱ⿡ ��Ȱ�� ���·� ����
    }

    public void ShowImage()
    {
        if (!imageWindow.activeSelf)
        {
            imageWindow.SetActive(true); // �̹��� â�� Ȱ��ȭ
            animator.SetTrigger("doShow"); // "doShow" �ִϸ��̼��� ����
        }
    }

    public void HideImage()
    {
        if (imageWindow.activeSelf)
        {
            animator.SetTrigger("doHide"); // "doHide" �ִϸ��̼��� ����
        }
    }
}
