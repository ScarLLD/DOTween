using DG.Tweening;
using UnityEngine;

public class MoveAnim : MonoBehaviour
{
    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.DOMove(_endPosition, _speed).SetLoops(-1, LoopType.Yoyo); 
    }
}
