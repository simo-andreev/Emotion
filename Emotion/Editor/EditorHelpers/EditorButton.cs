﻿#nullable enable

#region Using

using Emotion.Game.World.Editor;
using Emotion.Graphics;
using Emotion.Platform.Input;
using Emotion.UI;
using Emotion.WIPUpdates.One.EditorUI.Helpers;

#endregion

namespace Emotion.Editor.EditorHelpers;

public class EditorButton : UICallbackButton
{
    public string? Text
    {
        get => _text;
        set
        {
            _text = value;
            if (_label != null) _label.Text = _text;
        }
    }

    private string? _text;

    #region Theme

    public Color NormalColor = MapEditorColorPalette.ButtonColor;
    public Color RolloverColor = MapEditorColorPalette.ActiveButtonColor;
    public Color ActiveColor = MapEditorColorPalette.ActiveButtonColor;
    public Color DisabledColor = MapEditorColorPalette.ButtonColorDisabled.SetAlpha(150);

    #endregion

    public object? UserData;

    protected bool _activeMode;
    protected EditorLabel _label;

    public EditorButton(string label) : this()
    {
        Text = label;
    }

    public EditorButton()
    {
        FillX = false;
        FillY = false;
        Paddings = new Rectangle(6, 3, 6, 3);

        _label = new EditorLabel
        {
            Id = "buttonText",
            Text = _text
        };
        AddChild(_label);
    }

    public override void AttachedToController(UIController controller)
    {
        base.AttachedToController(controller);
        RecalculateButtonColor();
    }

    protected override bool RenderInternal(RenderComposer c)
    {
        c.RenderSprite(Position, Size, _calculatedColor);
        return base.RenderInternal(c);
    }

    public override bool OnKey(Key key, KeyStatus status, Vector2 mousePos)
    {
        if (!Enabled) return false;
        return base.OnKey(key, status, mousePos);
    }

    public override void OnMouseEnter(Vector2 _)
    {
        if (!Enabled) return;
        base.OnMouseEnter(_);
        RecalculateButtonColor();
    }

    public override void OnMouseLeft(Vector2 _)
    {
        if (!Enabled) return;
        base.OnMouseLeft(_);
        RecalculateButtonColor();
    }

    public void SetActiveMode(bool activeLock)
    {
        _activeMode = activeLock;
        RecalculateButtonColor();
    }

    protected override void OnEnabledChanged()
    {
        base.OnEnabledChanged();
        RecalculateButtonColor();
    }

    protected virtual void RecalculateButtonColor()
    {
        if (_label != null)
            _label.IgnoreParentColor = Enabled;

        if (!Enabled)
        {
            WindowColor = DisabledColor;
            return;
        }

        if (_activeMode)
        {
            WindowColor = ActiveColor;
            return;
        }

        WindowColor = MouseInside ? RolloverColor : NormalColor;
    }
}