using UnityEngine;

public enum GameState { None,Playing,Fail,Win }
public class PlayerController : PlayerBase
{
    public GameState gameState;
    private void Update()
    {
        switch (gameState)
        {
            case GameState.None:
                break;
            case GameState.Playing:
                PlayerMovement();
                break;
            case GameState.Win:
                break;
            case GameState.Fail:
                break;
        }
    }
    protected override void PlayerMovement()
    {
        transform.position = Vector3.Lerp(transform.position,TargetVector(),0.8f);
    }
    protected override Vector3 TargetVector()
    {
        var xMovement = (SwerveInput.Instance.MoveFactorX * sensitivity);
        return new Vector3(Mathf.Clamp(transform.position.x + xMovement,-3.5f,3.5f),transform.position.y,transform.position.z + Time.deltaTime * 2f);
    }
}
