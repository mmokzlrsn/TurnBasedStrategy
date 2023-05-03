using UnityEngine;
using DG.Tweening;

public class Unit : MonoBehaviour
{
    readonly float _unitMoveDuration = 1f;
    readonly Ease _unitMoveEase = Ease.Linear;
    readonly float _unitRotationDuration = 0.3f;

    Sequence _sequence;

    [SerializeField] UnitAnimationController _unitAnimationController;

    // Start is called before the first frame update
    void Start()
    {
        GridPosition gridPosition = LevelGrid.instance.GetGridPosition(transform.position);
        LevelGrid.instance.SetUnitAtGridPosition(gridPosition, this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 targetPosition)
    {
        _sequence.Kill();
        _sequence = DOTween.Sequence(); 
        transform.DOLookAt(targetPosition, _unitRotationDuration);
        _unitAnimationController.PlayRifleRunAnimation();
        _sequence.Append(transform.DOMove(targetPosition, Vector3.Distance(transform.position, targetPosition) / 5f).SetEase(_unitMoveEase)).OnComplete(() =>
        {
            _unitAnimationController.PlayRifleAimingIdleAnimation();
        });
    }
    
}
