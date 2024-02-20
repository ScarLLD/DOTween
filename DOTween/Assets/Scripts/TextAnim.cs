using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextAnim : MonoBehaviour
{
    [SerializeField] private string _textOne;
    [SerializeField] private string _textTwo;
    [SerializeField] private string _textThree;

    private Sequence _sequence;
    private Text _text;

    private void Awake()
    {
        _sequence = DOTween.Sequence().SetLoops(-1);
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        _sequence.Append(_text.DOText(_textOne, 1, true, ScrambleMode.None, "W"));
        _sequence.Append(_text.DOText(_textTwo, 3, false, ScrambleMode.Lowercase, "F"));
        _sequence.Append(_text.DOText(_textThree, 5, true, ScrambleMode.Numerals, "A"));
    }
}
