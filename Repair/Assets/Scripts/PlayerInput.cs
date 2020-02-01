using UnityEngine;

public static class PlayerInput
{
    public const string AXIS_HORIZONTAL = "Horizontal";
    public const string AXIS_VERTICAL = "Vertical";   

    public static Vector2 GetDirectionalInput()
    {
        return new Vector2(Input.GetAxisRaw(AXIS_HORIZONTAL), Input.GetAxisRaw(AXIS_VERTICAL));
    }

    public static bool WasLMBPressed()
    {
        return Input.GetMouseButtonDown(0);
    }

    public static bool WasRMBPressed()
    {
        return Input.GetMouseButton(1);
    }

    public static bool WasSpacePressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public static bool WasCPressed()
    {
        return Input.GetKeyDown(KeyCode.C);
    }

    public static Vector2 GetMouseInput()
    {
        return Input.mousePosition;
    }
}
