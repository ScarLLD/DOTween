using DG.Tweening;
using UnityEngine;

public class CubeAnim : MonoBehaviour
{
    [SerializeField] private float _endScaleValue;
    [SerializeField] private Vector3 _endRotateValue;
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _speed;

    private void Awake()
    {
        transform.DOMove(_endPosition, _speed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        transform.DORotate(_endRotateValue, _speed, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        transform.DOScale(_endScaleValue, 1).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
