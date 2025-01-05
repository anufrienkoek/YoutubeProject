using UnityEngine;

namespace _Project.CodeBase.Infrastructure.Services.Input
{
    public class MobileInputService : InputService
    {
        public override Vector2 Axis => 
            SimpleInputAxis();
    }
}