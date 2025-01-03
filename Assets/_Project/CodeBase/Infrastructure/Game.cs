using _Project.CodeBase.Services;
using UnityEngine;

namespace _Project.CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game() => 
            RegisterInput();

        private static void RegisterInput()
        {
            if (Application.isEditor)
                InputService = new StandaloneInputService();
            else
                InputService = new MobileInputService();
        }
    }
}