using Topshelf;

namespace Great.Services
{
    internal static class TopShelfWrapper
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<Service>(service =>
                {
                    service.ConstructUsing(s => new Service());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                //Setup Account that window service use to run.  
                configure.RunAsLocalSystem();
                configure.SetServiceName(Service.ServiceName);
                configure.SetDisplayName(Service.DisplayName);
                configure.SetDescription(Service.Description);
            });
        }

    }
}
