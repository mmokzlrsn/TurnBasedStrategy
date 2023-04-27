using UnityEngine;
using DG.Tweening;

public class Unit : MonoBehaviour
{
    readonly float _unitMoveDuration = 1f;
    readonly Ease _unitMoveEase = Ease.Linear;
    readonly float _unitRotationDuration = 0.3f;

    Sequence _sequence;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        _sequence.Kill();
        _sequence = DOTween.Sequence(); 
        transform.DOLookAt(targetPosition, _unitRotationDuration);
        _sequence.Append(transform.DOMove(targetPosition, Vector3.Distance(transform.position, targetPosition) / 5f).SetEase(_unitMoveEase));
    }
    
}
