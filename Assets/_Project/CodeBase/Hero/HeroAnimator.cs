using _Project.CodeBase.Infrastructure;
using _Project.CodeBase.Services;
using UnityEngine;

namespace _Project.CodeBase.Hero
{
    public class HeroAnimator : MonoBehaviour
    {
        private static readonly int Walking = Animator.StringToHash("isWalking");
        
        [SerializeField] private Animator _animator;
        private IInputService _inputService;

        private void Awake() => 
            _inputService = Game.InputService;

        private void Update() => 
            _animator.SetBool(Walking, _inputService.Axis.magnitude > 0.001f);
    }
}