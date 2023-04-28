using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionSystem : MonoBehaviour
{
    [SerializeField] private Unit selectedUnit;
    [SerializeField] private LayerMask unitLayerMask;


    private void Update()
    {
        HandleUnitSelection();


        if (selectedUnit != null && Input.GetMouseButtonDown(0))
        {
            selectedUnit.Move(MouseWorld.GetPosition());
        }

    }


    private void HandleUnitSelection()
    {

    }


}
