using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimationController : AnimationController
{
    const string RIFLE_AIMING_IDLE = "RifleAimingIdle";

    public void PlayRifleAimingIdleAnimation()
    {
        ChangeAnimationState(RIFLE_AIMING_IDLE);
    }


}
