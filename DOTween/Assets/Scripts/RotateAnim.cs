using DG.Tweening;
using UnityEngine;

public class RotateAnim : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.DORotate(_endValue, _speed, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart);
        
    }
}
