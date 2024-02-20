using DG.Tweening;
using UnityEngine;

public class ScaleAnim : MonoBehaviour
{
    [SerializeField] private float _endValue;
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.DOScale(_endValue, 1).SetLoops(-1, LoopType.Yoyo);
    }
}