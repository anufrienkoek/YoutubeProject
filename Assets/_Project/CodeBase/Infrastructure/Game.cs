using _Project.CodeBase.Infrastructure.Services;
using _Project.CodeBase.Infrastructure.States;

namespace _Project.CodeBase.Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine StateMachine;

        public Game(ICoroutineRunner coroutineRunner, LoadingCurtain curtain) => 
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), curtain, AllServices.Container);
    }
}