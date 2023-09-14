using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NPCButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorHover;
    public Texture2D CursorBasic;
    void Start() {

        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {
        Cursor.SetCursor(cursorHover, Vector2.zero, CursorMode.Auto);
    }
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    }

