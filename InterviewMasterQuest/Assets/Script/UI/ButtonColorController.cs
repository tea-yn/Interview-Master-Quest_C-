using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 
/// </summary>

public class ButtonColorController : MonoBehaviour
{
    [Header("�L�����N�^�[�I��")]
    public CanvasGroup charaC_GP;    //�L�����N�^�[�̃L�����p�XGP
    public Button[] charaButtonList;    //�L�����N�^�[��Button���X�g

    [Header("��Փx�I��")]
    public CanvasGroup diffC_GP;    //��Փx�̃L�����p�XGP
    public Button[] diffButtonList; //��Փx��Button���X�g

    [Header("�A���t�@�l�ݒ�")]
    [Range(0f, 100f)] public float selectedAlpha = 100.0f;   // �I�����̃A���t�@�l
    [Range(0f, 100f)] public float NormalAlpha = 60.0f; // ��I�����̃A���t�@�l

     // Start is called before the first frame update
    void Start()
    {
        SetGroupAlpha(charaC_GP, false);  // �L�����N�^�[�I���O���[�v �������: ��������
        SetGroupAlpha(diffC_GP, false); // ��Փx�I���O���[�v �������: ��������
    }

    // �L�����N�^�[�I���O���[�v���I�����ꂽ��
    public void OnCharacterGroupSelected()
    {
        SetGroupAlpha(charaC_GP, true);   // �L�����N�^�[�I���O���[�v �Z������
        SetGroupAlpha(diffC_GP, false);  // ��Փx�I���O���[�v ��������

        //tButtonInteractable(charaButtonList, true);    // �L�����N�^�[�I���O���[�v�̃{�^�����C���^���N�e�B�u��
        //SetButtonInteractable(diffButtonList, false);   // ��Փx�I���O���[�v�̃{�^�����C���^���N�e�B�u��
    }

    // ��Փx�I���O���[�v���I�����ꂽ��
    public void OnDifficultyGroupSelected()
    {
        SetGroupAlpha(charaC_GP, false);  // �L�����N�^�[�I���O���[�v ��������
        SetGroupAlpha(diffC_GP, true);   // ��Փx�I���O���[�v �Z������

        //SetButtonInteractable(charaButtonList, false);   // �L�����N�^�[�I���O���[�v�̃{�^�����C���^���N�e�B�u��
        //SetButtonInteractable(diffButtonList, true);    // ��Փx�I���O���[�v�̃{�^�����C���^���N�e�B�u��
    }

    // CanvasGroup�̃A���t�@�l��ݒ肵�A�C���^���N�e�B�u��Ԃ��K�v�ɉ����Đݒ肷��֐�
    private void SetGroupAlpha(CanvasGroup canvasGroup, bool isSelected)
    {
        canvasGroup.alpha = isSelected ? selectedAlpha : NormalAlpha; // �I����Ԃɂ���ăA���t�@�l��ύX
        canvasGroup.interactable = isSelected; // �O���[�v���I������Ă��鎞�̂݃C���^���N�e�B�u�ɂ��� (�K�v�ɉ�����)
        canvasGroup.blocksRaycasts = isSelected; // �O���[�v���I������Ă��鎞�̂� Raycast ���u���b�N���� (�K�v�ɉ�����)
    }

    /*
    // �{�^���̃C���^���N�e�B�u��Ԃ��O���[�v�P�ʂŐݒ肷��֐�
    private void SetButtonInteractable(Button[] buttons, bool isInteractable)
    {
        foreach (Button button in buttons)
        {
            button.interactable = isInteractable;
        }
    }*/
}
