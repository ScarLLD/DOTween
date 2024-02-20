using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ColorAnim : MonoBehaviour
{
    [SerializeField] private Color _endColor;
    [SerializeField] private float _speed;

    private Image _material;

    private void Awake()
    {
        _material = GetComponent<Image>();        
    }

    private void Start()
    {
        _material.DOColor(_endColor, _speed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Flash);
    }
}
