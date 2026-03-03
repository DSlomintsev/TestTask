using System.Threading;
using Azulon.Actors.Player.Commands;
using Common.Infrastructure.States;
using Common.Input;
using Common.Services;
using Common.Services.Dialogs;
using Common.Services.Tick;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Azulon.Infrastructure.States
{
    public class AppLoopState : IState
    {
        public void Enter() => EnterAsync().Forget();

        private CancellationTokenSource _ctx;

        private async UniTask EnterAsync()
        {
            Debug.Log("DSiT EnterAsync");
            var dialogService = ServiceLocator.Get<DialogService>();
            //var dialog = await dialogService.OpenDialogAsync<InfoDialogMediator>(null, config: new BaseDialogConfig(),prefabName: "Dialogs/InfoDialog");
            
            _ctx?.Cancel();
            _ctx = new CancellationTokenSource();
            //GameFlow(_ctx.Token, ServiceLocator.Get<InputService>(), dialog).Forget();
            //GameFlowMove(_ctx.Token, ServiceLocator.Get<InputService>()).Forget();

            StartFlow();
        }

        private void StartFlow()
        {
            var inputService = ServiceLocator.Get<InputService>();
            
            SpawnPlayerCommand.Do(true);
            //SpawnPoints
            
            //_playerController = new PlayerController(new PlayerModel(), playerView,inputService.InputReader);

            //var cameraService = ServiceLocator.Get<CameraService>();
            //cameraService.SetFollowTarget(playerView.transform);
            
            // add pool

            ServiceLocator.Get<TickService>().AddTickIndexAction(1, Update);
            //ServiceLocator.Get<TickService>().AddFixedTickAction(FixedUpdate);
        }
        
        private void Update(float deltaTime)
        {
            //_playerController.Update();
        }
        
        private async UniTask GameFlowMove(CancellationToken cancellationToken, InputService inputService)
        {
            /*var playerSpeed = 700;
            
            while (!cancellationToken.IsCancellationRequested)
            {
                var moveInput = inputService.InputReader.MovementInput;
                var targetMoveDir = cam.transform.forward * moveInput.y + cam.transform.right * moveInput.x;
                playerRigidBody.AddForce(targetMoveDir * Time.deltaTime * playerSpeed, ForceMode.VelocityChange);
                
                await UniTask.NextFrame();
            }
            HandleSceneLoaded();*/
        }

        public void Exit()
        {
        }

        private void HandleSceneLoaded()
        {
            //var dialogService = ServiceLocator.Get<DialogService>();
            //dialogService.CloseDialogAsync<InfoDialogMediator>();
            ServiceLocator.Get<AppStateMachine>().Enter<MissionEndState>();
        }
    }
}