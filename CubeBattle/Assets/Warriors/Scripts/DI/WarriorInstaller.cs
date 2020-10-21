using UnityEngine;
using Zenject;

namespace CubeBattle.Warrior.DI
{
    public class WarriorInstaller : MonoInstaller
    {
        [SerializeField]
        private WarriorMovening.Setting moveSetting;

        [SerializeField]
        private WarriorBorderChecker.Setting borderSetting;

        [SerializeField]
        private WarriorView.Setting viewSetting;

        [SerializeField]
        private WarriorPush.Setting pushSetting;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<WarriorMovening>().AsSingle();
            Container.BindInstance(moveSetting);

            Container.BindInterfacesAndSelfTo<WarriorBorderChecker>().AsSingle();
            Container.BindInstance(borderSetting);

            Container.Bind<WarriorView>().AsSingle();
            Container.BindInstance(viewSetting);

            Container.BindInterfacesAndSelfTo<WarriorPush>().AsSingle();
            Container.BindInstance(pushSetting);

            Container.BindInstance(gameObject.transform).WithId("Warrior");
        }
    }
}