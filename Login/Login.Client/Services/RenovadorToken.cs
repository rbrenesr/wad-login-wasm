using System.Timers;
using Timer = System.Timers.Timer;

namespace Login.Client.Services
{
    public class RenovadorToken : IDisposable
    {
        private readonly ILoginService loginService;
        Timer? timer;

        public RenovadorToken(ILoginService loginService)
        {
            this.loginService = loginService;
        }
        public void Dispose()
        {
            timer?.Dispose();
        }

        public void Iniciar()
        {
            timer = new Timer();
            timer.Interval = 60 * 1000 * 10; //10 minutos            
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            loginService.ManejarRenovacionToken();
        }
    }
}
