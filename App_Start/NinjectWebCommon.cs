private static void RegisterServices(IKernel kernel)
{
    // Bind interfaces to implementations
    kernel.Bind<IWeapon>().To<Sword>();
    kernel.Bind<IGameLogger>().To<ApiGameLogger>();
    kernel.Bind<IPlayerRepository>().To<PlayerRepository>();
    kernel.Bind<IAdventureService>().To<AdventureService>();
}
