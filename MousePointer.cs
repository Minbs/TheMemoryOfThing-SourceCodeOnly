using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MousePointer : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public bool autoCenterHotSpot = false;
    public Vector2 hotSpotCustom = Vector2.zero;
    private Vector2 hotSpotAuto;

    void Start()
    {
        Vector2 hotSpot;
        if (autoCenterHotSpot)
        {
            hotSpotAuto = new Vector2(cursorTexture.width * 0.5f, cursorTexture.height);
            hotSpot = hotSpotAuto;

        }
        else { hotSpot = hotSpotCustom; }

        //Cursor.SetCursor (cursorTexture, new Vector2( centerX,centerY) ,CursorMode.ForceSoftware);
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.ForceSoftware);
    }
}
