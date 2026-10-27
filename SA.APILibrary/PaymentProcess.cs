using Microsoft.Extensions.Options;

namespace SA.APILibrary
{
    public class PaymentProcess
    {
        private RatesOptions _ratesOptions;
        public PaymentProcess(IOptionsMonitor<RatesOptions> ratesMonitor)
        {
            _ratesOptions = ratesMonitor.CurrentValue;

            ratesMonitor.OnChange((newRatesOptions) =>
            {
                Console.WriteLine("taxes changed");
                _ratesOptions = newRatesOptions;
            });
        }

        public void ProcessPayment()
        {
            // Aqui usamos las tarias
            Console.WriteLine($"Processing payment with day rate: {_ratesOptions.Day} and night rate: {_ratesOptions.Night}");
        }

        public RatesOptions GetRates()
        {
            return _ratesOptions;
        }
    }
}
