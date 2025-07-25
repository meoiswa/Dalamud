﻿namespace Dalamud.Game.Addon.Events;

/// <summary>
/// Object representing data that is relevant in handling native events.
/// </summary>
public class AddonEventData
{
    /// <summary>
    /// Gets the AtkEventType for this event.
    /// </summary>
    public AddonEventType AtkEventType { get; internal set; }

    /// <summary>
    /// Gets the param field for this event.
    /// </summary>
    public uint Param { get; internal set; }

    /// <summary>
    /// Gets the pointer to the AtkEvent object for this event.
    /// </summary>
    /// <remarks>Note: This is not a pointer to the AtkEventData object.<br/><br/></remarks>
    /// <remarks>Warning: AtkEvent->Node has been modified to be the AtkUnitBase*, and AtkEvent->Target has been modified to be the AtkResNode* that triggered this event.</remarks>
    public nint AtkEventPointer { get; internal set; }

    /// <summary>
    /// Gets the pointer to the AtkEventData object for this event.
    /// </summary>
    /// <remarks>This field will contain relevant data such as left vs right click, scroll up vs scroll down.</remarks>
    public nint AtkEventDataPointer { get; internal set; }

    /// <summary>
    /// Gets the pointer to the AtkUnitBase that is handling this event.
    /// </summary>
    public nint AddonPointer { get; internal set; }

    /// <summary>
    /// Gets the pointer to the AtkResNode that triggered this event.
    /// </summary>
    public nint NodeTargetPointer { get; internal set; }

    /// <summary>
    /// Gets or sets a pointer to the AtkEventListener responsible for handling this event.
    /// Note: As the event listener is dalamud allocated, there's no reason to expose this field.
    /// </summary>
    internal nint AtkEventListener { get; set; }
}
