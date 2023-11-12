using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterSelect : MonoBehaviour
{
    public Button LeftButton;
    public Button RightButton;

    public Character[] Characters;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _descriptionText;
    [SerializeField] private Image _portraitImage;
    private int _currentIndex = 0;

    void Start()
    {
        UpdateCharacterDisplay();
        AddEvent();
    }

    private void AddEvent()
    {
        LeftButton.onClick.AddListener(PreviousCharacter);
        RightButton.onClick.AddListener(NextCharacter);
    }

    private void UpdateCharacterDisplay()
    {
        Character currentCharacter = Characters[_currentIndex];
        _nameText.text = currentCharacter.Name;
        _descriptionText.text = currentCharacter.Descrption;
        _portraitImage.sprite = currentCharacter.Portrait;
    }

    private void NextCharacter()
    {
        _currentIndex = (_currentIndex + 1) % Characters.Length;
        UpdateCharacterDisplay();
    }

    private void PreviousCharacter()
    {
        _currentIndex = (_currentIndex + Characters.Length - 1) % Characters.Length;
        UpdateCharacterDisplay();
    }

    // UI ������Ʈ ���� => ���ϵ� {���, �ٳ���, ����, ���}
    // ��� ������ (����̸�, ����� ���� ����, �޴� ǥ��)
    // ���� ���Ϻ��� => ���ϵ�[0] = ��� => ���ϵ�[1] = �ٳ���
    // ���� : �ٳ���
    // �ٳ��� ������ (�ٳ����̸�, �ٳ����� ���� ����, �ٳ����޴� ǥ��)

    // AddEvent => ������ �ִ����� Action => �з� => 100 500 => LED�ݾ��� ���
    //                                            => ���� X => ��ȯ

    // ��ư�� ���� ���� �ٽɷ���!!
    // 1�� �Ŷ��, 2�� ����, 3���� ���ݸ�
    // < [1] >
    // < [1] [>]
    // < [2] >
    // < [2] [>]
    // < [3] >

    // next = current + 1
    // 1 2 3 4
    // previous = current - 1
    // 3 2 1 -1

    // 1 2 3 4
    // 4 + 1
    // 1 - 1

    // 3 + 1 => 1
    // 1 - 1 => 3

    // (3 + 1) / 3 =  1 + 0 = 1
    // (3 + 1) % 3 =  0 + 1 = 1

    // (1 - 1) % 3 =  1 - 1 = 0 => 3��
    // (1 + 3 - 1 - 1) % 3 = 1 + 0 - 1 - 1 = |-1| = 1


}
