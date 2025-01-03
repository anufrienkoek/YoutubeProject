using UnityEngine;

namespace _Project.CodeBase.Services
{
    public abstract class InputService : IInputService
    {
        protected const string Vertical = "Vertical";
        protected const string Horizontal = "Horizontal";
        private const string Button = "Fire";
        
        public abstract Vector2 Axis { get; }
        
        public bool IsAttackButtonUp() => 
            SimpleInput.GetButton(Button);

        protected static Vector2 SimpleInputAxis() => 
            new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
}