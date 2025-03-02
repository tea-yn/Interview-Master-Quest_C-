using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonAlphaController : MonoBehaviour
{
    [Header("�L�����N�^�[ButtonGP")]
    public Button[] charaButtonL; 

    [Header("��Փx�I��ButtonGP")]
    public Button[] diffButtonL; 

    /*
    [Header("�A���t�@�l�ݒ�")]
    [Range(0f, 1.0f)] public float selectedAlpha = 1.0f;   // �I�����̃A���t�@�l
    [Range(0f, 1.0f)] public float NormalAlpha = 0.6f; // ��I�����̃A���t�@�l
    */

    private Button selectedCharaButton = null;  // �O���[�vA�̌��݂̑I���{�^��
    private Button selectedDiffButton = null;  // �O���[�vB�̌��݂̑I���{�^��


    private void Start()
    {
        foreach (Button btn in charaButtonL)
        {
            btn.onClick.AddListener(() => SelectButtonInGroup(btn, charaButtonL, ref selectedCharaButton));
        }
        foreach (Button btn in diffButtonL)
        {
            btn.onClick.AddListener(() => SelectButtonInGroup(btn, diffButtonL, ref selectedDiffButton));
        }
    }

    private void SelectButtonInGroup(Button clickedButton, Button[] groupButtons, ref Button selectedButton)
    {
        // �ȑO�I������Ă����{�^���� interactable = true �ɖ߂�
        if (selectedButton != null)
        {
            selectedButton.interactable = true;
        }

        // �V���������ꂽ�{�^����I����Ԃɂ���
        selectedButton = clickedButton;
        selectedButton.interactable = false; // ����ɂ�� SelectedColor ���K�p�����
    }
}