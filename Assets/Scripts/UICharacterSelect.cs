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

    // UI 업데이트 개념 => 과일들 {사과, 바나나, 수박, 멜론}
    // 사과 페이지 (사과이름, 사과에 대한 설명, 달다 표현)
    // 다음 과일보기 => 과일들[0] = 사과 => 과일들[1] = 바나나
    // 과일 : 바나나
    // 바나나 페이지 (바나나이름, 바나나에 대한 설명, 바나나달다 표현)

    // AddEvent => 동전을 넣는행위 Action => 분류 => 100 500 => LED금액을 띄움
    //                                            => 돈이 X => 반환

    // 버튼에 대한 구현 핵심로직!!
    // 1번 컵라면, 2번 과자, 3번이 초콜릿
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

    // (1 - 1) % 3 =  1 - 1 = 0 => 3번
    // (1 + 3 - 1 - 1) % 3 = 1 + 0 - 1 - 1 = |-1| = 1


}
