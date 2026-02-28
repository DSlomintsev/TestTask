/*using System.Text;
using Common.Services;

namespace Common.Infrastructure.States
{
    public class BootstrapState : IState
    {
        private void Construct()
        {
            var tickService = ServiceLocator.Get<TickService>();

            var eventService = ServiceLocator.Get<EventService>();

            var appStateMachine = ServiceLocator.Get<AppStateMachine>();

            var gameModel = ModelLocator.Get<GameModel>();
            var dialogService = ServiceLocator.Get<DialogService>();
            var cameraController = ServiceLocator.Get<CameraController>();
            var externalDataService = ServiceLocator.Get<IExternalDataService>();
            var gameController = ServiceLocator.Get<GameController>();
            var analyticsService = ServiceLocator.Get<AnalyticsService>();
            var appStateHandlerService = ServiceLocator.Get<AppStateHandlerService>();
            var areaResService = ServiceLocator.Get<AreaResService>();
            var chestsService = ServiceLocator.Get<ChestsService>();
            var bossesService = ServiceLocator.Get<BossesService>();
            var compassService = ServiceLocator.Get<CompassService>();
            var eventSchedulerService = ServiceLocator.Get<EventSchedulerService>();
            var obelisksService = ServiceLocator.Get<ObelisksService>();
            var rewardsService = ServiceLocator.Get<RewardsService>();
            var tutorialService = ServiceLocator.Get<TutorialService>();
            var entitiesService = ServiceLocator.Get<EntitiesService>();
            var storeService = ServiceLocator.Get<StoreService>();
            var schedulerService = ServiceLocator.Get<NotificationsService>();

            var services = ServiceLocator.Inst.Services;
            
            var inputService = SpawnUtils.Spawn<InputService>("Input/InputService");
            Object.DontDestroyOnLoad(inputService);
            services.Add(typeof(InputService), inputService);
            var uiController = SpawnUtils.Spawn<UIController>("UI/UIController");
            Object.DontDestroyOnLoad(uiController);
            services.Add(typeof(UIController), uiController);

            externalDataService.Init(); // await UniTask.WaitUntil(() => ServiceLocator.Get<IExternalDataService>().IsServiceInited);

            inputService.Init();

            appStateHandlerService.Init();
            tickService.Init();
            eventService.Init();
            appStateMachine.Init();
            dialogService.Init();
            cameraController.Init();
            gameController.Init();
            analyticsService.Init();
            areaResService.Init();
            chestsService.Init();
            bossesService.Init();
            uiController.Init();
            compassService.Init();
            eventSchedulerService.Init();
            obelisksService.Init();
            rewardsService.Init();
            tutorialService.Init();
            entitiesService.Init();
            storeService.Init();
            schedulerService.Init();

            Debug.Log("UpdateUIService");
            ServiceLocator.Get<UpdateUIService>().Init();
            Debug.Log("TimeService");
            ServiceLocator.Get<TimeService>().Init();
            Debug.Log("DirtyFlagsService");
            ServiceLocator.Get<DirtyFlagsService>().Init();
            Debug.Log("TickService");
            ServiceLocator.Get<TickService>().Init();
            Debug.Log("HoverService");
            ServiceLocator.Get<HoverService>().Init();
            Debug.Log("CustomTaskService");
            ServiceLocator.Get<CustomTaskService>().Init();
            Debug.Log("ConditionManager");
            ServiceLocator.Get<ConditionManager>().Init();
            Debug.Log("GraphicsService");
            ServiceLocator.Get<GraphicsService>().Init();
            Debug.Log("AudioService");
            ServiceLocator.Get<AudioService>().Init();
            Debug.Log("ResourceLoaderService");
            ServiceLocator.Get<ResourceLoaderService>().Init();
            Debug.Log("ClansService");
            ServiceLocator.Get<ClansService>().Init();
            Debug.Log("ClansService");
            ModelLocator.Get<ClansModel>();
            
            #if UNITY_EDITOR
            
            Debug.Log("GameDebugService");
            ServiceLocator.Get<GameDebugService>().Init();
            #endif
            Debug.Log("ProjQuestsService");
            ServiceLocator.Get<ProjQuestsService>().Init();
            
            Debug.Log("PlayersService");
            ServiceLocator.Get<PlayersService>().Init();
            
            Debug.Log("HintService");
            ServiceLocator.Get<HintService>().Init();
            
            Debug.Log("CoinsView");
            ViewLocator.Get<CoinsView>().Init();

            InitEntities();
        }

        public void Enter()
        {
            Construct();
            
            //_gameModel = ModelLocator.Get<GameModel>();
            //_appStateMachine = ServiceLocator.Get<AppStateMachine>();
            //_dialogService = ServiceLocator.Get<DialogService>();
            
            //DSiT Comment before build
            //var str = PlayerPrefs.GetString("currentLog", "");
            //PlayerPrefs.SetString("prevLog", str);
            //Application.logMessageReceived += OnApplicationLogMessageReceived;

            //CheckVersion();
            
            //var loadingScreen = _dialogService.OpenDialog<LoadingScreenViewModel>(AudioId.NONE, config: DialogServiceUtils.StaticScreen);
            //loadingScreen.SetVersion(Application.version);
            
            //Random.InitState(0);
            //HandleSceneLoaded();
        }

        private int _itemId = 0;
        private StringBuilder _strBuilder = new ();

        private void OnApplicationLogMessageReceived(string condition, string stacktrace, LogType type)
        {
            _gameModel.LogItemsDatas.Add(new LogMessageItemData
            {
                Condition = condition,
                Stacktrace = stacktrace,
                LogType = type
            });
            _strBuilder.Append($"Id: {_itemId},Type: {type}, Condition: {condition}, Stacktrace: {stacktrace}\n");
            PlayerPrefs.SetString("currentLog", _strBuilder.ToString());
            _itemId++;
        }

        private static void CheckVersion()
        {
            var appVersion = "AppVersion";
            var currentVersion = AppConfig.VERSION;
            var savedVersion = PlayerPrefs.GetString(appVersion, "");

            if (!savedVersion.Equals(currentVersion))
            {
                PlayerPrefs.DeleteAll();
                PlayerPrefs.SetString(appVersion, currentVersion);
                PlayerPrefs.Save();
            }
        }

        public void Exit()
        {
        }

        private void HandleSceneLoaded() =>
            _appStateMachine.Enter<InitState>();
        
        private static void InitEntities()
        {
            Debug.Log("MobsService");
            ServiceLocator.Get<MobsService>().Init();
            
            //Debug.Log("AIService");
            //ServiceLocator.Get<AIService>().Init();
            Debug.Log("HealthService");
            ServiceLocator.Get<HealthService>().Init();
            Debug.Log("MoveService");
            ServiceLocator.Get<MoveService>().Init();
            Debug.Log("AttackService");
            ServiceLocator.Get<AttackService>().Init();
            Debug.Log("SpawnService");
            ServiceLocator.Get<SpawnEntityService>().Init();
            Debug.Log("DestroyService");
            ServiceLocator.Get<DestroyEntityService>().Init();
            Debug.Log("AnimationService");
            ServiceLocator.Get<AnimationService>().Init();
        }
    }
}*/