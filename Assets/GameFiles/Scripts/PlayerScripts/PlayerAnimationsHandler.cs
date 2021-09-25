using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsHandler : MonoBehaviour
{
    #region Properties
    [Header("Components Reference")]
    [SerializeField] private Animator playerAnimator = null;
    #endregion

    #region Public Core Functions
    public void SwitchAnimation(PlayerAnimationState state)
    {
        switch (state)
        {
            case PlayerAnimationState.Idle:
                playerAnimator.SetBool("b_Run", false);
                break;
            case PlayerAnimationState.Run:
                playerAnimator.SetBool("b_Run", true);
                break;
            case PlayerAnimationState.Victory:
                playerAnimator.SetTrigger("t_Victory");
                break;
            case PlayerAnimationState.Defeat:
                playerAnimator.SetTrigger("t_Defeat");
                break;
        }
    }
    #endregion
}
