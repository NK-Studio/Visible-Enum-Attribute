using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Method)]
public class VisibleEnumAttribute : PropertyAttribute
{
    public Type EnumType { get; }
    public VisibleEnumAttribute(Type enumType) => EnumType = enumType;
}