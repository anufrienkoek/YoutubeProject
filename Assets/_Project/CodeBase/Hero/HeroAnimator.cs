using _Project.CodeBase.Infrastructure.Services;
using _Project.CodeBase.Infrastructure.Services.Input;
using UnityEngine;

namespace _Project.CodeBase.Hero
{
    public class HeroAnimator : MonoBehaviour
    {
        private static readonly int Walking = Animator.StringToHash("isWalking");
        
        [SerializeField] private Animator _animator;
        private IInputService _inputService;

        private void Awake() => 
            _inputService = AllServices.Container.Single<IInputService>();

        private void Update() => 
            _animator.SetBool(Walking, _inputService.Axis.magnitude > 0.001f);
    }
}