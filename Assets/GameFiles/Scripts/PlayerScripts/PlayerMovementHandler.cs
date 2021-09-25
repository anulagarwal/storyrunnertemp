using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 0f;

    [Header("Components Reference")]
    [SerializeField] private CharacterController characterController = null;

    private Vector3 movementDirection = Vector3.zero;
    private VariableJoystick movementJS = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        movementJS = LevelUIManager.Instance.GetMovementJS;

        //Testing
        PlayerSingleton.Instance.GetPlayerAnimationsHandler.SwitchAnimation(PlayerAnimationState.Run);
    }

    private void Update()
    {
        movementDirection = new Vector3(movementJS.Horizontal, 0, 1);
        characterController.Move(movementDirection * Time.deltaTime * moveSpeed);
    }
    #endregion
}
