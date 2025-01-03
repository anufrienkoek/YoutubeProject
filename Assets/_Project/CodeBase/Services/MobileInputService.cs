using UnityEngine;

namespace _Project.CodeBase.Services
{
    public class MobileInputService : InputService
    {
        public override Vector2 Axis => 
            SimpleInputAxis();
    }
}