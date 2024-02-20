using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextAnim : MonoBehaviour
{
    [SerializeField] private string _endText;
    [SerializeField] private float _speed;
    [SerializeField] private bool richTextEnabled;
    [SerializeField] private ScrambleMode scrambleMode;
    [SerializeField] private string scrambleChars;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        _text.DOText(_endText, _speed, richTextEnabled, scrambleMode, scrambleChars).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InBounce);
    }
}
