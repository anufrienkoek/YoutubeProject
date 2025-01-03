using UnityEngine;

namespace _Project.CodeBase.Services
{
    public interface IInputService
    {
        Vector2 Axis { get; }

        bool IsAttackButtonUp();
    }
}