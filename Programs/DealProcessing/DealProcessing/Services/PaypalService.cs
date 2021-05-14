namespace Services
{
    class PaypalService : IOnlinePaymentService
    {
        // Informações do serviço Paypal
        private const float _FeePercentage = 0.02f;
        private const float _MonthlyInterest = 0.01f;

        public float PaymentFee(float amount)
        { return amount * _FeePercentage; }

        public float Interest(float amount, int months)
        { return amount * months * _MonthlyInterest; }        
    }
}
