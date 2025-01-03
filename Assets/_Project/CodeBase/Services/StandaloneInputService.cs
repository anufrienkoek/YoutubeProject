﻿using UnityEngine;

namespace _Project.CodeBase.Services
{
    public class StandaloneInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = SimpleInputAxis();

                if (axis == Vector2.zero)
                    axis = UnityAxis();

                return axis;
            }
        }

        private static Vector2 UnityAxis() => 
            new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}