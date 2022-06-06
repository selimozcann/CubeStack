using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    [SerializeField] protected float sensitivity;
    protected abstract void PlayerMovement();
    protected abstract Vector3 TargetVector();
}
